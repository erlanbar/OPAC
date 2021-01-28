using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OPAC.Data;
using OPAC.Models;
using OPAC.ViewModels;

using System.Web;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Hosting;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace OPAC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly BookContext _context;
        private readonly InlistContext _inlistContext;

        private readonly GeneralController gc;

        public HomeController(IWebHostEnvironment env, BookContext context, InlistContext inlistContext)
        {
            _env = env;
            _context = context;
            _inlistContext = inlistContext;

            gc = new GeneralController(env);
        }

        public IActionResult Index()
        {

            int? userID = HttpContext.Session.GetInt32("UserID");
            string sess_guest = HttpContext.Session.GetString("Guest");

            ViewBag.UITitle = "Index";
            ViewBag.UI = "Featured";
            if (userID.HasValue) {

                ViewBag.SessionID = userID.Value;
            }

            var categories = (
                from datas in _context.Categories
                where datas.Status == true
                select datas
            ).ToList();

            ViewBag.Categories = categories;

            var tags = (
                from datas in _context.Tags
                where datas.Status == true
                select datas
            ).ToList();

            ViewBag.Tags = tags;

            ViewBag.SessionGuest = sess_guest;

            return View();
        }

        public async Task<IActionResult> Detail(int? id) {
            
            ViewBag.UITitle = "Detail";
            ViewBag.UI = "Featured";

            int? bookID = id;
            int? sess_ID = HttpContext.Session.GetInt32("UserID");
            int userID = 0;

            try
            {
                if (sess_ID.HasValue) {
                    userID = sess_ID.Value;
                }

                if (bookID == null)
                {
                    return NotFound();
                }

                double dblID = Convert.ToDouble(bookID);
                var query_catalog = from catalog in _inlistContext.Catalogs
                                    join catalogFiles in _inlistContext.Catalogfiles
                                    on catalog.Id equals catalogFiles.CatalogId

                                    join collection in _inlistContext.Collections
                                    on catalog.Id equals collection.CatalogId

                                    join collectionMedia in _inlistContext.Collectionmedias
                                    on collection.MediaId equals collectionMedia.Id

                                    join worksheet in _inlistContext.Worksheets
                                    on collectionMedia.WorksheetId equals worksheet.Id
                                    select new
                                    {
                                        CatalogID = catalog.Id,
                                        CatalogTitle = catalog.Title,
                                        CatalogDesc = catalog.Note,
                                        CatalogFileURL = catalogFiles.FileUrl,
                                        CatalogFolder = worksheet.Name,
                                        CatalogCover = catalog.CoverUrl,
                                        CatalogPublisher = catalog.Publisher,
                                        CatalogPublishPlace = catalog.PublishLocation,
                                        CatalogPublishYear = catalog.PublishYear,
                                        CatalogPhysDesc = catalog.PhysicalDescription,
                                        CatalogCallNumber = catalog.CallNumber,
                                        CatalogLang = catalog.Languages
                                    };
                var catalogData = await query_catalog.Distinct().ToListAsync();

                var bookDetail = await (from book in _context.Books
                                        where book.ID == bookID
                                        select book).ToListAsync();

                var bookFolder = (from book in bookDetail
                                  join catalog in catalogData
                                 on book.InlistID equals (int)catalog.CatalogID into book_catalog

                                 from lj_book_catalog in book_catalog.DefaultIfEmpty()
                                 select new {
                                     Cover = lj_book_catalog == null ? "" : lj_book_catalog.CatalogCover,
                                     Title = lj_book_catalog == null ? "" : lj_book_catalog.CatalogTitle,
                                     Description = lj_book_catalog == null ? "" : lj_book_catalog.CatalogDesc,
                                     FileURL = lj_book_catalog == null ? "" : lj_book_catalog.CatalogFileURL,
                                     FileFolder = lj_book_catalog == null ? "" : lj_book_catalog.CatalogFolder,

                                     Publisher = lj_book_catalog == null ? "" : lj_book_catalog.CatalogPublisher,
                                     PublishLocation = lj_book_catalog == null ? "" : lj_book_catalog.CatalogPublishPlace,
                                     PublishYear = lj_book_catalog == null ? "" : lj_book_catalog.CatalogPublishYear,
                                     PhysDesc = lj_book_catalog == null ? "" : lj_book_catalog.CatalogPhysDesc,
                                     CallNumber = lj_book_catalog == null ? "" : lj_book_catalog.CatalogCallNumber,
                                     Language = lj_book_catalog == null ? "" : lj_book_catalog.CatalogLang
                                 }).FirstOrDefault();

                var bookTransFlag = (
                    from bookTrans in _context.BookTransaction
                    where bookTrans.UserID == userID && bookTrans.BookID == bookID
                    select new {bookTrans.Flag}
                ).SingleOrDefault();

                var bookTransID = (
                    from bookTrans in _context.BookTransaction
                    where bookTrans.UserID == userID && bookTrans.BookID == bookID
                    select new {bookTrans.ID}
                ).SingleOrDefault();

                var detail_Books = await (
                                    from books in _context.Books
                                    join bookTrans in _context.BookTransaction
                                    on new {
                                        BookID = books.ID,
                                        UserID = userID
                                    } equals new {
                                        bookTrans.BookID,
                                        bookTrans.UserID
                                    }  into book_bookTrans
                                    from lj_book_bookTrans in book_bookTrans.DefaultIfEmpty()
                                    join bookReview in _context.BookReview
                                    on lj_book_bookTrans.ID equals bookReview.BookTransID into bookTrans_bookReview
                                    from lj_bookTrans_bookReview in bookTrans_bookReview.DefaultIfEmpty()
                                    join bookAuthor in _context.Author
                                    on books.AuthorID equals bookAuthor.ID
                                    where books.ID == bookID
                                    group new{
                                        books,
                                        lj_book_bookTrans,
                                        lj_bookTrans_bookReview,
                                        bookAuthor
                                    } by new {
                                        books.ID,
                                        // bookTransID = lj_book_bookTrans.ID,
                                        books.AuthorID,
                                        bookAuthor.Alias,
                                        books.Cover,
                                        books.Title,
                                        books.Description,
                                        books.FileURL,
                                        books.IsPublished,
                                        books.Flag,
                                        // lj_bookTrans_bookReview.Rating,
                                        books.CreatedDate
                                    } into bookGrouped
                                    orderby bookGrouped.Key.CreatedDate descending//books.CreatedDate descending
                                    select new{
                                        BookID = bookGrouped.Key.ID,
                                        //BookCover = bookGrouped.Key.Cover,
                                        BookCover = bookFolder.Cover,
                                        BookAuthor = bookGrouped.Key.Alias,
                                        BookAuthorID = bookGrouped.Key.AuthorID,
                                        //BookTitle = bookGrouped.Key.Title,
                                        //BookDesc = bookGrouped.Key.Description,
                                        //BookFileURL = bookGrouped.Key.FileURL,
                                        BookTitle = bookFolder.Title,
                                        BookDesc = bookFolder.Description,
                                        BookFileURL = bookFolder.FileURL,
                                        BookIsPublished = bookGrouped.Key.IsPublished,
                                        BookFlag = bookGrouped.Key.Flag,
                                        BookRating = bookGrouped.Average(t => t.lj_bookTrans_bookReview.Rating),
                                        BookTransID = bookTransID == null ? 0 : bookTransID.ID,
                                        BookTransFlag = bookTransFlag == null ? 0 : bookTransFlag.Flag,
                                        UserID = userID,
                                        FileFolder = bookFolder.FileFolder,
                                        Publisher = bookFolder.Publisher,
                                        PublishLocation = bookFolder.PublishLocation,
                                        PublishYear = bookFolder.PublishYear,
                                        PhysDesc = bookFolder.PhysDesc,
                                        CallNumber = bookFolder.CallNumber,
                                        Language = bookFolder.Language,
                                        TotalReviewer = (
                                            from reviewer in _context.BookReview
                                            join reviewerBookTrans in _context.BookTransaction
                                            on reviewer.BookTransID equals reviewerBookTrans.ID
                                            where reviewerBookTrans.BookID == bookGrouped.Key.ID
                                            select reviewer
                                        ).Count(),
                                        TotalView = (
                                            from viewedBook in _context.BookTransaction
                                            where viewedBook.BookID == bookGrouped.Key.ID
                                            select viewedBook
                                        ).Count()
                                    }).FirstAsync();

                ViewBag.DetailBooksData = detail_Books;

                var detail_BookLearns = await (
                    from bookLearns in _context.BookLearns
                    where bookLearns.BookID == bookID
                    select bookLearns
                ).ToListAsync();
                ViewBag.DetailBookLearns = detail_BookLearns;

                var detail_BookRequirements = await (
                    from bookRequirements in _context.BookRequirements
                    where bookRequirements.BookID == bookID
                    select bookRequirements
                ).ToListAsync();
                ViewBag.DetailBookRequirements = detail_BookRequirements;

                var detail_BookCategories = await (
                    from bookCategories in _context.BookCategories
                    join categories in _context.Categories
                    on bookCategories.CategoryID equals categories.ID
                    where bookCategories.BookID == bookID
                    select categories
                ).ToListAsync();
                ViewBag.DetailBookCategories = detail_BookCategories;

                var detail_BookTags = await (
                    from bookTags in _context.BookTags
                    join tags in _context.Tags
                    on bookTags.TagID equals tags.ID
                    where bookTags.BookID == bookID
                    select tags
                ).ToListAsync();
                ViewBag.DetailBookTags = detail_BookTags;

                // var userRole = await (
                //     from userRoles in _context.UserRole
                //     join roles in _context.Role
                //     on userRoles.RoleID equals roles.ID
                //     select roles
                // ).FirstOrDefaultAsync();
                // ViewBag.UserRole = userRole;

                return View();
            }
            catch (Exception ex)
            {
                Response.Cookies.Append("Error", ex.Message.ToString(), new CookieOptions());
                return View();
            }
            finally
            {
                GC.Collect();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Read()
        {

            int? userID = HttpContext.Session.GetInt32("UserID");
            string sess_nip = HttpContext.Session.GetString("NIP");
            int bookID = Convert.ToInt32(Request.Form["bookID"]);
            int? bookTransID = Convert.ToInt32(Request.Form["bookTransID"]);
            string bookFileURL = Request.Form["bookFileURL"];
            // bookTransID = bookTransID.HasValue ? bookTransID.Value : 0;

            int lastPageNumber = 1;

            BookActivity bookActivity = new BookActivity();

            try
            {
                // if (userID.ToString() == "" || userID == null) {

                //     return RedirectToAction("Index", "Login");
                // }

                // jika sudah login, simpan activitynya
                if (userID.HasValue) {

                    if (bookTransID == 0 || bookTransID == null) { //blm pernah read atau wishlist

                        //add transaction
                        BookTransaction bookTransaction = new BookTransaction();

                        bookTransaction.UserID = userID.Value;
                        bookTransaction.BookID = bookID;
                        bookTransaction.Flag = 2; //reading
                        bookTransaction.Status = true;
                        bookTransaction.Creator = userID.ToString();
                        bookTransaction.CreatedDate = DateTime.Now;

                        _context.Add(bookTransaction);
                        _context.SaveChanges();

                        bookTransID = bookTransaction.ID; //get inserted ID
                    }
                    else { //sudah pernah reading atau baru di add to my list

                        bookTransID = bookTransID.Value;

                        var _bookTransaction = (
                            from bookTrans in _context.BookTransaction
                            where bookTrans.ID == bookTransID
                            select bookTrans
                        ).SingleOrDefault();

                        _bookTransaction.Flag = 2; //update ke reading jika sudah pernah reading / add to my list
                        _bookTransaction.Modifier = userID.ToString();
                        _bookTransaction.ModifiedDate = DateTime.Now;

                        _context.Update(_bookTransaction);
                        _context.SaveChanges();
                    }

                    //ambil page terakhir yang dibaca
                    var lastPage = (
                        from bookActivities in _context.BookActivities
                        where bookActivities.BookTransID == bookTransID
                        orderby bookActivities.ID descending
                        select bookActivities
                    ).FirstOrDefault();

                    // int lastPageNumber = 1;
                    if (lastPage != null) {

                        lastPageNumber = lastPage.PageNumber;
                    }

                }

                //ambil previewed pages
                var bookData = (
                    from datas in _context.Books
                    where datas.ID == bookID
                    select datas
                ).FirstOrDefault();

                int previewedPages = bookData.PreviewedPages;
                
                //add activity
                bookActivity.BookTransID = bookTransID.Value;
                bookActivity.PageNumber = lastPageNumber;
                bookActivity.Status = true;
                bookActivity.Creator = userID.ToString();
                bookActivity.CreatedDate = DateTime.Now;

                _context.Add(bookActivity);
                await _context.SaveChangesAsync();

                ViewBag.BookActivityID = bookActivity.ID;
                ViewBag.LastPageNumber = bookActivity.PageNumber;
                ViewBag.BookFileURL = bookFileURL;
                ViewBag.PreviewedPages = previewedPages;
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw ex;
            }
            return View("Read", bookActivity);
        }

        [HttpPost]
        // [ValidateAntiForgeryToken]
        public JsonResult UpdateBookActivity([Bind("ID, PageNumber")] BookActivity bookActivity, int currentPageNumber, int previewedPages )
        {

            try
            {

                string sess_nip = HttpContext.Session.GetString("NIP");

                if (sess_nip == null || sess_nip == "") {

                    if (currentPageNumber > previewedPages) {

                        TempData["ResultCode"] = 0;
                        TempData["ResultMessage"] = "Anda perlu login untuk melihat lebih lanjut";

                        return Json(new {status = 2, message = "Anda perlu login untuk melihat lebih lanjut"});
                    }
                    else {

                        goto nextStep;
                    }
                }
                else {

                    goto nextStep;
                }
                
                nextStep:
                    var _bookActivity = (
                        from bookActivities in _context.BookActivities
                        where bookActivities.ID == bookActivity.ID
                        select bookActivities
                    ).SingleOrDefault();

                    if (bookActivity.PageNumber > _bookActivity.PageNumber) { //update last page yang dibaca jika last pagenya lebih besar

                        _bookActivity.PageNumber = bookActivity.PageNumber;
                        _bookActivity.Modifier = HttpContext.Session.GetInt32("UserID").ToString();
                        _bookActivity.ModifiedDate = DateTime.Now;

                        _context.Update(_bookActivity);
                        _context.SaveChanges();
                    }
            }
            catch (DbUpdateConcurrencyException ex)
            {
                // throw;
                return Json(new {status = 0, message = ex.ToString()});
            }
            return Json(new {status = 1, message = "Activity updated"});
        }

        public async Task<IActionResult> UserReview(int? bookID)
        {
            ViewBag.LoadingUserReview = true;

            try
            {

                int? userID = HttpContext.Session.GetInt32("UserID");

                // if (!userID.HasValue) {
                    
                //     return RedirectToAction("Index", "Login");
                // }

                /* average rating and count per rating */
                var userReviewAvg = await (
                    from bookTrans in _context.BookTransaction
                    join bookReviews in _context.BookReview
                    on bookTrans.ID equals bookReviews.BookTransID into bookTrans_bookReviews
                    from lj_bookTrans_bookReview in bookTrans_bookReviews.DefaultIfEmpty()
                    where lj_bookTrans_bookReview.Flag == 1 //approved review
                    group new {
                        bookTrans,
                        lj_bookTrans_bookReview
                    } by new {
                        bookTrans.BookID
                    } into bookReviewsGrouped
                    where bookReviewsGrouped.Key.BookID == bookID.Value
                    select new {
                        BookRating = bookReviewsGrouped.Average(t => t.lj_bookTrans_bookReview.Rating),
                        Rating5Count = (
                            from bookTrans in _context.BookTransaction
                            join bookReviews in _context.BookReview
                            on bookTrans.ID equals bookReviews.BookTransID into bookTrans_bookReviews
                            from lj_bookTrans_bookReview in bookTrans_bookReviews.DefaultIfEmpty()
                            where bookTrans.BookID == bookID.Value && lj_bookTrans_bookReview.Rating == 5
                            group new {
                                bookTrans,
                                lj_bookTrans_bookReview
                            } by new {
                                bookTrans.BookID
                            } into bookRatingCount
                            select bookRatingCount.Count()
                        ).SingleOrDefault(),
                        Rating4Count = (
                            from bookTrans in _context.BookTransaction
                            join bookReviews in _context.BookReview
                            on bookTrans.ID equals bookReviews.BookTransID into bookTrans_bookReviews
                            from lj_bookTrans_bookReview in bookTrans_bookReviews.DefaultIfEmpty()
                            where bookTrans.BookID == bookID.Value && lj_bookTrans_bookReview.Rating == 4
                            group new {
                                bookTrans,
                                lj_bookTrans_bookReview
                            } by new {
                                bookTrans.BookID
                            } into bookRatingCount
                            select bookRatingCount.Count()
                        ).SingleOrDefault(),
                        Rating3Count = (
                            from bookTrans in _context.BookTransaction
                            join bookReviews in _context.BookReview
                            on bookTrans.ID equals bookReviews.BookTransID into bookTrans_bookReviews
                            from lj_bookTrans_bookReview in bookTrans_bookReviews.DefaultIfEmpty()
                            where bookTrans.BookID == bookID.Value && lj_bookTrans_bookReview.Rating == 3
                            group new {
                                bookTrans,
                                lj_bookTrans_bookReview
                            } by new {
                                bookTrans.BookID
                            } into bookRatingCount
                            select bookRatingCount.Count()
                        ).SingleOrDefault(),
                        Rating2Count = (
                            from bookTrans in _context.BookTransaction
                            join bookReviews in _context.BookReview
                            on bookTrans.ID equals bookReviews.BookTransID into bookTrans_bookReviews
                            from lj_bookTrans_bookReview in bookTrans_bookReviews.DefaultIfEmpty()
                            where bookTrans.BookID == bookID.Value && lj_bookTrans_bookReview.Rating == 2
                            group new {
                                bookTrans,
                                lj_bookTrans_bookReview
                            } by new {
                                bookTrans.BookID
                            } into bookRatingCount
                            select bookRatingCount.Count()
                        ).SingleOrDefault(),
                        Rating1Count = (
                            from bookTrans in _context.BookTransaction
                            join bookReviews in _context.BookReview
                            on bookTrans.ID equals bookReviews.BookTransID into bookTrans_bookReviews
                            from lj_bookTrans_bookReview in bookTrans_bookReviews.DefaultIfEmpty()
                            where bookTrans.BookID == bookID.Value && lj_bookTrans_bookReview.Rating == 1
                            group new {
                                bookTrans,
                                lj_bookTrans_bookReview
                            } by new {
                                bookTrans.BookID
                            } into bookRatingCount
                            select bookRatingCount.Count()
                        ).SingleOrDefault()
                    }
                ).FirstOrDefaultAsync();

                ViewBag.UserReviewData = userReviewAvg;

                var userReviewDetail = await (
                    from bookTrans in _context.BookTransaction
                    join bookReviews in _context.BookReview
                    on bookTrans.ID equals bookReviews.BookTransID into bookTrans_bookReviews
                    from lj_bookTrans_bookReview in bookTrans_bookReviews.DefaultIfEmpty()
                    join user in _context.User
                    on bookTrans.UserID equals user.ID
                    where bookTrans.BookID == bookID.Value && lj_bookTrans_bookReview.Review != null
                    && lj_bookTrans_bookReview.Flag == 1 //approved review
                    select new {
                        UserRating = lj_bookTrans_bookReview.Rating,
                        UserReview = lj_bookTrans_bookReview.Review,
                        ReviewDate = lj_bookTrans_bookReview.ModifiedDate == null ? 
                                        lj_bookTrans_bookReview.CreatedDate : lj_bookTrans_bookReview.ModifiedDate,
                        UserName = user.Name                        
                    }
                ).ToListAsync();

                ViewBag.UserReviewDetail = userReviewDetail;

                return PartialView("UserReview");
            }
            catch (Exception ex)
            {
                Response.Cookies.Append("Error", ex.Message.ToString(), new CookieOptions());
                return PartialView("UserReview");
            }
            finally
            {
                GC.Collect();
            }
        }

        [HttpPost]
        // [ValidateAntiForgeryToken]
        public EmptyResult Review([Bind("ID, BookTransID, Rating, Review")] BookReview bookReview)
        {

            int? userID = HttpContext.Session.GetInt32("UserID");

            int bookReviewID = bookReview.ID;

            BookActivity bookActivity = new BookActivity();

            try
            {
                // if (userID.ToString() == "" || userID == null) {
                //     return NotFound();
                // }

                if (bookReviewID == 0) { //blm pernah review

                    //add transaction
                    bookReview.Status = true;
                    bookReview.Creator = userID.ToString();
                    bookReview.CreatedDate = DateTime.Now;

                    _context.Add(bookReview);
                    _context.SaveChanges();

                    bookReviewID = bookReview.ID; //get inserted ID
                }
                else { //sudah pernah review

                    var _bookReview = (
                        from bookReviews in _context.BookReview
                        where bookReview.ID == bookReviewID
                        select bookReviews
                    ).SingleOrDefault();

                    _bookReview.Review = bookReview.Review;
                    _bookReview.Rating = bookReview.Rating;
                    _bookReview.Modifier = userID.ToString();
                    _bookReview.ModifiedDate = DateTime.Now;

                    _context.Update(_bookReview);
                    _context.SaveChanges();
                }
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw ex;
            }
            return new EmptyResult();
        }
        public IActionResult AllBooks(int? id, int? categoryID, int? tagID, string homeSearch)
        {
            ViewBag.UITitle = "All Books";
            ViewBag.UI = "Featured";
            
            ViewBag.OrderBy = id ?? 1;
            ViewBag.SelectedCategory = categoryID.ToString() ?? "0";
            ViewBag.SelectedTag = tagID.ToString() ?? "0";

            var categories = (
                from datas in _context.Categories
                where datas.Status == true
                select datas
            ).ToList();

            // ViewBag.Categories = categories.Select(x => new SelectListItem{ Value = x.ID.ToString(), Text = x.Description });
            ViewBag.Categories = categories;

            var tags = (
                from datas in _context.Tags
                where datas.Status == true
                select datas
            ).ToList();

            ViewBag.Tags = tags;

            ViewBag.Search = homeSearch ?? "";

            return View();
        }

        public async Task<IActionResult> AllBooksContent(int orderBy, string searchStr, string[] categories, string[] tags)
        {
            ViewBag.LoadingAllBooks = true;

            try
            {
                // orderBy = 1;
                if (searchStr == null) {
                    searchStr = "";
                }
                searchStr = searchStr.ToLower();

                var query_catalog = from catalog in _inlistContext.Catalogs
                                    join catalogFiles in _inlistContext.Catalogfiles
                                    on catalog.Id equals catalogFiles.CatalogId

                                    join collection in _inlistContext.Collections
                                    on catalog.Id equals collection.CatalogId

                                    join collectionMedia in _inlistContext.Collectionmedias
                                    on collection.MediaId equals collectionMedia.Id

                                    join worksheet in _inlistContext.Worksheets
                                    on collectionMedia.WorksheetId equals worksheet.Id
                                    select new
                                    {
                                        catalog.Id,
                                        worksheet.Name
                                    };

                var catalogData = await query_catalog.Distinct().ToListAsync();

                var query_bookList = from books in _context.Books
                                    join bookTrans in _context.BookTransaction
                                    on books.ID equals bookTrans.BookID into book_bookTrans
                                    from lj_book_bookTrans in book_bookTrans.DefaultIfEmpty()
                                    join bookReview in _context.BookReview
                                    on lj_book_bookTrans.ID equals bookReview.BookTransID into bookTrans_bookReview
                                    from lj_bookTrans_bookReview in bookTrans_bookReview.DefaultIfEmpty()
                                    join bookAuthor in _context.Author
                                    on books.AuthorID equals bookAuthor.ID
                                    
                                    join bookCategories in _context.BookCategories
                                    on books.ID equals bookCategories.BookID into books_bookCategories
                                    from lj_books_bookCategories in books_bookCategories.DefaultIfEmpty()
                                    join category in _context.Categories
                                    on lj_books_bookCategories.CategoryID equals category.ID into bookCategories_categories
                                    from lj_bookCategories_categories in bookCategories_categories.DefaultIfEmpty()

                                    join bookTags in _context.BookTags
                                    on books.ID equals bookTags.BookID into book_bookTags
                                    from lj_books_bookTags in book_bookTags.DefaultIfEmpty()
                                    join tag in _context.Tags
                                    on lj_books_bookTags.TagID equals tag.ID into bookTags_tags
                                    from lj_bookTags_tags in bookTags_tags.DefaultIfEmpty()

                                    where books.Status == true 
                                    && categories.Contains(lj_bookCategories_categories.ID.ToString()) || categories.Contains("0") //&& tags.Contains(lj_bookTags_tags.ID)

                                    group new{
                                        books,
                                        lj_book_bookTrans,
                                        lj_bookTrans_bookReview,
                                        // lj_bookCategories_categories,
                                        // lj_bookTags_tags,
                                        bookAuthor
                                    } by new {
                                        books.ID,
                                        // bookTransID = lj_book_bookTrans.ID,
                                        books.AuthorID,
                                        bookAuthor.Alias,
                                        books.Cover,
                                        books.Description,
                                        books.Title,
                                        // lj_bookTrans_bookReview.Rating,
                                        books.CreatedDate,
                                        books.InlistID
                                    } into bookGrouped
                                    select new{
                                        BookID = bookGrouped.Key.ID,
                                        BookCover = bookGrouped.Key.Cover,
                                        BookAuthor = bookGrouped.Key.Alias,
                                        BookDesc = bookGrouped.Key.Description,
                                        BookTitle = bookGrouped.Key.Title,
                                        BookRating = bookGrouped.Average(t => t.lj_bookTrans_bookReview.Rating),
                                        CreatedDate = bookGrouped.Key.CreatedDate,
                                        // CategoryList = string.Join(", ", bookGrouped.Select(x => x.lj_bookCategories_categories.Description)),
                                        // TagList = string.Join(" ", bookGrouped.Select(x => x.lj_bookTags_tags.Description)),
                                        bookGrouped.Key.InlistID,
                                        TotalReviewer = (
                                            from reviewer in _context.BookReview
                                            join reviewerBookTrans in _context.BookTransaction
                                            on reviewer.BookTransID equals reviewerBookTrans.ID
                                            where reviewerBookTrans.BookID == bookGrouped.Key.ID
                                            select reviewer
                                        ).Count(),
                                        TotalView = (
                                            from viewedBook in _context.BookTransaction
                                            where viewedBook.BookID == bookGrouped.Key.ID
                                            select viewedBook
                                        ).Count()
                                    };

                var allBooks_data = await (from bookList in query_bookList
                                        where bookList.BookDesc.ToLower().Contains(searchStr)
                                        orderby bookList.TotalView descending
                                        select bookList).ToListAsync();

                var allBooks = (from book in allBooks_data
                                      join catalog in catalogData
                                      on book.InlistID equals (int)catalog.Id into book_catalog

                                      from lj_book_catalog in book_catalog.DefaultIfEmpty()
                                      select new
                                      {
                                          book.BookID,
                                          book.BookCover,
                                          book.BookAuthor,
                                          book.BookDesc,
                                          book.BookTitle,
                                          book.BookRating,
                                          book.CreatedDate,
                                          book.InlistID,
                                          book.TotalReviewer,
                                          book.TotalView,
                                          FileFolder = lj_book_catalog == null ? "../../Content/cover/" : "http://elibrary.dephub.go.id/uploaded_files/sampul_koleksi/original/" + lj_book_catalog.Name + "/"
                                      }).ToList();

                if (allBooks.Count > 0) {
                
                    if (orderBy == 1) { //New Arrival

                        ViewBag.AllBooksData = allBooks.OrderByDescending(x => x.CreatedDate);
                    }
                    else if (orderBy == 2) { //Top Rating

                        ViewBag.AllBooksData = allBooks.OrderByDescending(x => x.BookRating);
                    }
                    else if (orderBy == 3) { //Top View

                        ViewBag.AllBooksData = allBooks.OrderByDescending(x => x.TotalView);
                    }
                }                

                ViewBag.OrderBy = orderBy;

                return PartialView("AllBooksContent");
            }
            catch (Exception ex)
            {
                Response.Cookies.Append("Error", ex.Message.ToString(), new CookieOptions());
                return PartialView("AllBooksContent");
            }
            finally
            {
                GC.Collect();
            }
        }

        public IActionResult MyList()
        {
            ViewBag.UITitle = "My List";
            ViewBag.UI = "MyList";

            int? userID = HttpContext.Session.GetInt32("UserID");

            if (!userID.HasValue) {

                return RedirectToAction("Index", "Login");
            }
            else {

                ViewBag.SessionID = userID.Value;
            }

            return View();
        }

        public async Task<IActionResult> MyListContent(string searchStr)
        {
            ViewBag.LoadingMyList = true;

            int? userID = HttpContext.Session.GetInt32("UserID");

            try
            {

                // orderBy = 1;
                if (searchStr == null) {
                    searchStr = "";
                }
                searchStr = searchStr.ToLower();

                var query_catalog = from catalog in _inlistContext.Catalogs
                                    join catalogFiles in _inlistContext.Catalogfiles
                                    on catalog.Id equals catalogFiles.CatalogId

                                    join collection in _inlistContext.Collections
                                    on catalog.Id equals collection.CatalogId

                                    join collectionMedia in _inlistContext.Collectionmedias
                                    on collection.MediaId equals collectionMedia.Id

                                    join worksheet in _inlistContext.Worksheets
                                    on collectionMedia.WorksheetId equals worksheet.Id
                                    select new
                                    {
                                        catalog.Id,
                                        worksheet.Name
                                    };

                var catalogData = await query_catalog.Distinct().ToListAsync();

                var query_myList = from bookTrans in _context.BookTransaction
                                    join books in _context.Books
                                    on bookTrans.BookID equals books.ID
                                    where bookTrans.UserID == userID && bookTrans.Flag == 1 //wishlist
                                    select new{
                                        BookID = books.ID,
                                        BookCover = books.Cover,
                                        BookDesc = books.Description,
                                        BookTitle = books.Title,
                                        books.InlistID,
                                        CreatedDate = bookTrans.CreatedDate,
                                        ModifiedDate = bookTrans.ModifiedDate
                                    };

                var myList_data = await (from bookList in query_myList
                                        where bookList.BookDesc.ToLower().Contains(searchStr)
                                        // orderby bookList.CreatedDate descending, bookList.ModifiedDate descending
                                        select bookList).ToListAsync();

                var myList = (from book in myList_data
                              join catalog in catalogData
                                on book.InlistID equals (int)catalog.Id into book_catalog

                              from lj_book_catalog in book_catalog.DefaultIfEmpty()
                              select new
                              {
                                  book.BookID,
                                  book.BookCover,
                                  book.BookDesc,
                                  book.BookTitle,
                                  book.CreatedDate,
                                  book.ModifiedDate,
                                  book.InlistID,
                                  FileFolder = lj_book_catalog == null ? "../../Content/cover/" : "http://elibrary.dephub.go.id/uploaded_files/sampul_koleksi/original/" + lj_book_catalog.Name + "/"
                              }).ToList();

                if (myList.Count > 0) {
                
                    ViewBag.MyListData = myList.OrderByDescending(x => x.CreatedDate).ThenByDescending(x => x.ModifiedDate);
                }                

                return PartialView("MyListContent");
            }
            catch (Exception ex)
            {
                Response.Cookies.Append("Error", ex.Message.ToString(), new CookieOptions());
                return PartialView("MyListContent");
            }
            finally
            {
                GC.Collect();
            }
        }

        public IActionResult MyBook()
        {
            ViewBag.UITitle = "My Book";
            ViewBag.UI = "MyBook";

            int? userID = HttpContext.Session.GetInt32("UserID");

            if (!userID.HasValue) {

                return RedirectToAction("Index", "Login");
            }
            else {

                ViewBag.SessionID = userID.Value;
            }

            return View();
        }

        public async Task<IActionResult> MyBookContent(string searchStr)
        {
            ViewBag.LoadingMyBook = true;

            int? userID = HttpContext.Session.GetInt32("UserID");

            try
            {
                // orderBy = 1;
                if (searchStr == null) {
                    searchStr = "";
                }
                searchStr = searchStr.ToLower();

                var query_catalog = from catalog in _inlistContext.Catalogs
                                    join catalogFiles in _inlistContext.Catalogfiles
                                    on catalog.Id equals catalogFiles.CatalogId

                                    join collection in _inlistContext.Collections
                                    on catalog.Id equals collection.CatalogId

                                    join collectionMedia in _inlistContext.Collectionmedias
                                    on collection.MediaId equals collectionMedia.Id

                                    join worksheet in _inlistContext.Worksheets
                                    on collectionMedia.WorksheetId equals worksheet.Id
                                    select new
                                    {
                                        catalog.Id,
                                        worksheet.Name
                                    };

                var catalogData = await query_catalog.Distinct().ToListAsync();

                var query_myBook = from bookTrans in _context.BookTransaction
                                    join books in _context.Books
                                    on bookTrans.BookID equals books.ID
                                    join bookReview in _context.BookReview
                                    on bookTrans.ID equals bookReview.BookTransID into bookTrans_bookReview
                                    from lj_bookTrans_bookReview in bookTrans_bookReview.DefaultIfEmpty()
                                    where bookTrans.UserID == userID && bookTrans.Flag == 2 //reading
                                    select new{
                                        BookID = books.ID,
                                        BookCover = books.Cover,
                                        BookDesc = books.Description,
                                        BookTitle = books.Title,
                                        BookTransID = bookTrans.ID,
                                        BookReviewID = lj_bookTrans_bookReview.ID,
                                        BookReview = lj_bookTrans_bookReview.Review,
                                        BookRating = lj_bookTrans_bookReview.Rating,
                                        books.InlistID,
                                        CreatedDate = bookTrans.CreatedDate,
                                        ModifiedDate = bookTrans.ModifiedDate
                                    };

                var myBook_data = await (from bookList in query_myBook
                                        where bookList.BookDesc.ToLower().Contains(searchStr)
                                        // orderby bookList.CreatedDate descending, bookList.ModifiedDate descending
                                        select bookList).ToListAsync();

                var myBook = (from book in myBook_data
                              join catalog in catalogData
                                on book.InlistID equals (int)catalog.Id into book_catalog

                                from lj_book_catalog in book_catalog.DefaultIfEmpty()
                                select new
                                {
                                    book.BookID,
                                    book.BookCover,
                                    book.BookDesc,
                                    book.BookTitle,
                                    book.BookTransID,
                                    book.BookReviewID,
                                    book.BookReview,
                                    book.BookRating,
                                    book.CreatedDate,
                                    book.ModifiedDate,
                                    book.InlistID,
                                    FileFolder = lj_book_catalog == null ? "../../Content/cover/" : "http://elibrary.dephub.go.id/uploaded_files/sampul_koleksi/original/" + lj_book_catalog.Name + "/"
                                }).ToList();

                if (myBook.Count > 0) {
                
                    ViewBag.MyBookData = myBook.OrderByDescending(x => x.CreatedDate).ThenByDescending(x => x.ModifiedDate);
                    ViewBag.UserID = userID;
                }                

                return PartialView("MyBookContent");
            }
            catch (Exception ex)
            {
                Response.Cookies.Append("Error", ex.Message.ToString(), new CookieOptions());
                return PartialView("MyBookContent");
            }
            finally
            {
                GC.Collect();
            }
        }


        [HttpPost]
        // [ValidateAntiForgeryToken]
        public JsonResult AddToMyList(BookTransaction bookTransaction)
        {
            try
            {

                var _bookTransaction = (
                    from bookTrans in _context.BookTransaction
                    where bookTrans.UserID == bookTransaction.UserID && bookTrans.BookID == bookTransaction.BookID
                    select bookTrans
                ).SingleOrDefault();

                if (_bookTransaction == null) { //insert baru

                    BookTransaction bookTrans = new BookTransaction {
                        BookID = bookTransaction.BookID,
                        CreatedDate = DateTime.Now,
                        Creator = bookTransaction.UserID.ToString(),
                        Flag = bookTransaction.Flag,
                        Status = true,
                        UserID = bookTransaction.UserID
                    };

                    _context.Add(bookTrans);
                    _context.SaveChanges();
                }
                else {

                    _bookTransaction.Flag = bookTransaction.Flag;
                    _bookTransaction.Modifier = bookTransaction.UserID.ToString();
                    _bookTransaction.ModifiedDate = DateTime.Now;

                    _context.Update(_bookTransaction);
                    _context.SaveChanges();
                }
            }
            catch (DbUpdateConcurrencyException ex)
            {
                // throw;
                return Json(new {status = 0, message = ex.ToString()});
            }
            return Json(new {status = 1, message = "Data berhasil disimpan"});
        }

        public async Task<IActionResult> Author(int? id) {

            int? authorID = id;
            int? userID = HttpContext.Session.GetInt32("UserID");

            try
            {
                // if (!userID.HasValue)
                // {
                //     return RedirectToAction("Index", "Login");
                // }

                var authorData = await (
                    from author in _context.Author
                    where author.ID == authorID.Value
                    select new {
                        AuthorID = author.ID,
                        AuthorFirstName = author.FirstName,
                        AuthorLastName = author.LastName,
                        AuthorAlias = author.Alias,
                        AuthorDesc = author.Description,
                        AuthorPhoto = author.Photo
                        // AuthorContactLabel = lj_authorContact_contactLabel.Description,
                        // AuthorContactDesc = lj_author_authorContact.Description
                    }
                ).FirstOrDefaultAsync();

                ViewBag.AuthorData = authorData;

                var authorContactData = await (
                    from author in _context.Author
                    join authorContact in _context.AuthorContacts
                    on author.ID equals authorContact.AuthorID into author_authorContact
                    from lj_author_authorContact in author_authorContact.DefaultIfEmpty()
                    join contactLabel in _context.ContactLabels
                    on lj_author_authorContact.ContactLabelID equals contactLabel.ID into authorContact_contactLabel
                    from lj_authorContact_contactLabel in authorContact_contactLabel.DefaultIfEmpty()
                    where author.ID == authorID.Value
                    select new {
                        AuthorContactLabel = lj_authorContact_contactLabel.Description,
                        AuthorContactDesc = lj_author_authorContact.Description
                    }
                ).ToListAsync();

                ViewBag.AuthorContactData = authorContactData;

                return View();
            }
            catch (Exception ex)
            {
                Response.Cookies.Append("Error", ex.Message.ToString(), new CookieOptions());
                return View();
            }
            finally
            {
                GC.Collect();
            }
        }
        
        public async Task<IActionResult> AuthorCollection(int authorID, string searchStr)
        {
            ViewBag.LoadingAuthorCollection = true;

            int? userID = HttpContext.Session.GetInt32("UserID");

            try
            {

                // if (!userID.HasValue) {

                //     return RedirectToAction("Index", "Login");
                // }
                
                if (searchStr == null) {
                    searchStr = "";
                }
                searchStr = searchStr.ToLower();

                var query_catalog = from catalog in _inlistContext.Catalogs
                                    join catalogFiles in _inlistContext.Catalogfiles
                                    on catalog.Id equals catalogFiles.CatalogId

                                    join collection in _inlistContext.Collections
                                    on catalog.Id equals collection.CatalogId

                                    join collectionMedia in _inlistContext.Collectionmedias
                                    on collection.MediaId equals collectionMedia.Id

                                    join worksheet in _inlistContext.Worksheets
                                    on collectionMedia.WorksheetId equals worksheet.Id
                                    select new
                                    {
                                        catalog.Id,
                                        worksheet.Name
                                    };

                var catalogData = await query_catalog.Distinct().ToListAsync();

                var query_authorCollection = from books in _context.Books
                                    join bookTrans in _context.BookTransaction
                                    on books.ID equals bookTrans.BookID into book_bookTrans
                                    from lj_book_bookTrans in book_bookTrans.DefaultIfEmpty()
                                    join bookReview in _context.BookReview
                                    on lj_book_bookTrans.ID equals bookReview.BookTransID into bookTrans_bookReview
                                    from lj_bookTrans_bookReview in bookTrans_bookReview.DefaultIfEmpty()
                                    where books.AuthorID == authorID
                                    group new{
                                        books,
                                        lj_book_bookTrans,
                                        lj_bookTrans_bookReview
                                    } by new {
                                        books.ID,
                                        // bookTransID = lj_book_bookTrans.ID,
                                        books.AuthorID,
                                        books.Cover,
                                        books.Description,
                                        books.Title,
                                        books.InlistID,
                                        // lj_bookTrans_bookReview.Rating,
                                        books.CreatedDate,
                                        books.ModifiedDate
                                    } into bookGrouped
                                    select new{
                                        BookID = bookGrouped.Key.ID,
                                        BookCover = bookGrouped.Key.Cover,
                                        BookDesc = bookGrouped.Key.Description,
                                        BookTitle = bookGrouped.Key.Title,
                                        BookRating = bookGrouped.Average(t => t.lj_bookTrans_bookReview.Rating),
                                        CreatedDate = bookGrouped.Key.CreatedDate,
                                        ModifiedDate = bookGrouped.Key.ModifiedDate,
                                        bookGrouped.Key.InlistID,
                                        TotalReviewer = (
                                            from reviewer in _context.BookReview
                                            join reviewerBookTrans in _context.BookTransaction
                                            on reviewer.BookTransID equals reviewerBookTrans.ID
                                            where reviewerBookTrans.BookID == bookGrouped.Key.ID
                                            select reviewer
                                        ).Count(),
                                        TotalView = (
                                            from viewedBook in _context.BookTransaction
                                            where viewedBook.BookID == bookGrouped.Key.ID
                                            select viewedBook
                                        ).Count()
                                    };

                var authorCollection_data = await (from bookList in query_authorCollection
                                        where bookList.BookDesc.ToLower().Contains(searchStr)
                                        select bookList).ToListAsync();

                var authorCollection = (from book in authorCollection_data
                                        join catalog in catalogData
                                        on book.InlistID equals (int)catalog.Id into book_catalog

                                      from lj_book_catalog in book_catalog.DefaultIfEmpty()
                                      select new
                                      {
                                          book.BookID,
                                          book.BookCover,
                                          book.BookDesc,
                                          book.BookTitle,
                                          book.BookRating,
                                          book.TotalReviewer,
                                          book.TotalView,
                                          book.CreatedDate,
                                          book.ModifiedDate,
                                          book.InlistID,
                                          FileFolder = lj_book_catalog == null ? "../../Content/cover/" : "http://elibrary.dephub.go.id/uploaded_files/sampul_koleksi/original/" + lj_book_catalog.Name + "/"
                                      }).ToList();

                if (authorCollection.Count > 0) {
                
                    ViewBag.AuthorCollectionData = authorCollection.OrderByDescending(x => x.CreatedDate).ThenByDescending(x => x.ModifiedDate);
                }                

                return PartialView("AuthorCollection");
            }
            catch (Exception ex)
            {
                Response.Cookies.Append("Error", ex.Message.ToString(), new CookieOptions());
                return PartialView("AuthorCollection");
            }
            finally
            {
                GC.Collect();
            }
        }

        public async Task<IActionResult> Account() 
        {
            ViewBag.UITitle = "Account";
            ViewBag.UI = "Account";

            string ses_NIP = HttpContext.Session.GetString("NIP");

            try
            {
                if (ses_NIP == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                else {

                    ViewBag.SessionID = ses_NIP;
                }

                var user = await (
                    from users in _context.User
                    where users.NIP == ses_NIP
                    select users
                ).FirstAsync();

                var userRole = await (
                    from userRoles in _context.UserRole
                    join roles in _context.Role
                    on userRoles.RoleID equals roles.ID
                    where userRoles.NIP == ses_NIP
                    select new {
                        userRoles, roles
                    }
                ).FirstAsync();

                if (user == null)
                {
                    return RedirectToAction("Index", "Login");
                }

                if (user.Password == "") {
                    ViewBag.IsFromSocmed = true;
                }
                else {
                    ViewBag.IsFromSocmed = false;
                }
                ViewBag.ResultCode = TempData["ResultCode"];
                ViewBag.ResultMessage = TempData["ResultMessage"];

                AccountViewModel accountViewModel = new AccountViewModel();

                accountViewModel.user = user;
                accountViewModel.Code = userRole.roles.Code;
                accountViewModel.Type = userRole.roles.Type;
                accountViewModel.Level = userRole.roles.Level;

                return View(accountViewModel);
            }
            catch (Exception ex)
            {
                Response.Cookies.Append("Error", ex.Message.ToString(), new CookieOptions());
                return View();
            }
            finally
            {
                GC.Collect();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Account(AccountViewModel account)
        {

            ViewBag.UITitle = "Account";
            ViewBag.UI = "Account";

            int? userID = HttpContext.Session.GetInt32("UserID");

            if (ModelState.IsValid)
            {
                try
                {
                    if (!userID.HasValue) {

                        return RedirectToAction("Index", "Login");
                    }

                    if (account.user.ID == 0) { //insert

                        User _user = new User();

                        _user.NIP = account.user.NIP;
                        _user.Name = account.user.Name;
                        _user.Photo = gc.UploadAvatarAccount(account); //gc.UploadImage(account);
                        _user.Email = account.user.Email;
                        _user.Phone = account.user.Phone;
                        _user.NIK = account.user.NIK;
                        _user.Alamat = account.user.Alamat;
                        _user.PendidikanTerakhir = account.user.PendidikanTerakhir;
                        _user.Pekerjaan = account.user.Pekerjaan;

                        _user.Status = true;
                        _user.Creator = userID.Value.ToString();
                        _user.CreatedDate = DateTime.Now;

                        _context.Add(account.user);
                        await _context.SaveChangesAsync();
                    }
                    else { //update

                        var _user = (
                            from users in _context.User
                            where users.ID == account.user.ID
                            select users
                        ).FirstOrDefault();

                        _user.Name = account.user.Name;
                        _user.NIP = account.user.NIP;
                        if (account.userViewModel == null) {

                            _user.Photo = account.user.Photo;
                        }
                        else {

                            _user.Photo = gc.UploadAvatarAccount(account); //gc.UploadImage(account);
                        }
                        // _user.Photo = (account.userViewModel.Photo == null) ? account.user.Photo : UploadImage(account);
                        _user.Email = account.user.Email;
                        _user.Phone = account.user.Phone;
                        _user.NIK = account.user.NIK;
                        _user.Alamat = account.user.Alamat;
                        _user.PendidikanTerakhir = account.user.PendidikanTerakhir;
                        _user.Pekerjaan = account.user.Pekerjaan;
                        _user.LastLogin = account.user.LastLogin;
                        _user.Note = account.user.Note;
                        _user.Keyword = account.user.Keyword;
                        _user.Password = account.user.Password;
                        _user.Modifier = userID.Value.ToString();
                        _user.ModifiedDate = DateTime.Now;

                        _context.Update(_user);
                        await _context.SaveChangesAsync();
                    }

                    TempData["ResultCode"] = 1;
                    TempData["ResultMessage"] = "Data Berhasil disimpan";
                }
                catch (Exception ex)
                {
                    Response.Cookies.Append("Error", ex.Message.ToString(), new CookieOptions());
                    ViewBag.ResultCode = 0;
                    ViewBag.ResultMessage = ex.Message.ToString();

                    return View(account);
                }
            }            

            return RedirectToAction(nameof(Account));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(AccountViewModel account)
        {

            ViewBag.UITitle = "Account";
            ViewBag.UI = "Account";

            int? userID = HttpContext.Session.GetInt32("UserID");

            if (ModelState.IsValid)
            {
                try
                {
                    if (!userID.HasValue) {

                        return RedirectToAction("Index", "Login");
                    }

                    var _user = (
                        from users in _context.User
                        where users.ID == account.changePasswordViewModel.ID
                        select users
                    ).FirstOrDefault();

                    account.user = _user;

                    if (_user.Password != getSHA1Hash(account.changePasswordViewModel.Password)) {

                        ViewBag.ResultCode = 0;
                        ViewBag.ResultMessage = "Password anda salah. Mohon input ulang password anda saat ini";
                        ViewBag.IsChangePassword = 1;

                        return View("Account", account);
                    }

                    _user.Password = getSHA1Hash(account.changePasswordViewModel.ConfirmNewPassword);
                    _user.Modifier = userID.Value.ToString();
                    _user.ModifiedDate = DateTime.Now;

                    _context.Update(_user);
                    await _context.SaveChangesAsync();

                    TempData["ResultCode"] = 1;
                    TempData["ResultMessage"] = "Data Berhasil disimpan";
                }
                catch (Exception ex)
                {
                    Response.Cookies.Append("Error", ex.Message.ToString(), new CookieOptions());
                    ViewBag.ResultCode = 0;
                    ViewBag.ResultMessage = ex.Message.ToString();

                    return View("Account", account);
                }
            }            

            return RedirectToAction(nameof(Account));
        }

        public string getSHA1Hash(string strToHash)
        {
            string strResult = "";
            try
            {
                SHA1CryptoServiceProvider sha1Obj = new SHA1CryptoServiceProvider();
                byte[] bytesToHash = System.Text.Encoding.ASCII.GetBytes(strToHash);

                bytesToHash = sha1Obj.ComputeHash(bytesToHash);

                foreach (byte b in bytesToHash)
                    strResult += b.ToString("x2");

                return strResult;
            }
            catch(Exception ex)
            {
                return strResult;
            }
        }

        // private string UploadImage(AccountViewModel account) {
        //     try
        //     {
        //         string fileName = "";
        //         if (account.userViewModel.Photo != null) {
        //             string uploadFolder = Path.Combine(_env.WebRootPath, "Content/profpic");
        //             fileName = account.user.ID.ToString() + "_" + account.user.NIP + account.userViewModel.Photo.FileName;
        //             string filePath = Path.Combine(uploadFolder, fileName);

        //             account.userViewModel.Photo.CopyTo(new FileStream(filePath, FileMode.Create));

        //             return fileName;
        //         }
        //         else {
        //             return null;
        //         }
        //     }
        //     catch (System.Exception)
        //     {
                
        //         throw;
        //     }
        // }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> NewArrival()
        {
            ViewBag.LoadingNewArrival = true;

            try
            {
                ViewBag.NewArrival = true;

                var query_catalog = from catalog in _inlistContext.Catalogs
                                    join catalogFiles in _inlistContext.Catalogfiles
                                    on catalog.Id equals catalogFiles.CatalogId

                                    join collection in _inlistContext.Collections
                                    on catalog.Id equals collection.CatalogId

                                    join collectionMedia in _inlistContext.Collectionmedias
                                    on collection.MediaId equals collectionMedia.Id

                                    join worksheet in _inlistContext.Worksheets
                                    on collectionMedia.WorksheetId equals worksheet.Id
                                    select new
                                    {
                                        catalog.Id,
                                        worksheet.Name,
                                        catalogFiles.FileUrl,
                                        catalog.CoverUrl,
                                        catalog.Note,
                                        catalog.Title
                                    };

                var catalogData = await query_catalog.Distinct().ToListAsync();

                var newArrival_Books = await (
                                    from books in _context.Books
                                    join bookTrans in _context.BookTransaction
                                    on books.ID equals bookTrans.BookID into book_bookTrans
                                    from lj_book_bookTrans in book_bookTrans.DefaultIfEmpty()
                                    join bookReview in _context.BookReview
                                    on lj_book_bookTrans.ID equals bookReview.BookTransID into bookTrans_bookReview
                                    from lj_bookTrans_bookReview in bookTrans_bookReview.DefaultIfEmpty()
                                    join bookAuthor in _context.Author
                                    on books.AuthorID equals bookAuthor.ID
                                    where books.Status == true
                                    group new{
                                        books,
                                        lj_book_bookTrans,
                                        lj_bookTrans_bookReview,
                                        bookAuthor
                                    } by new {
                                        books.ID,
                                        // bookTransID = lj_book_bookTrans.ID,
                                        books.AuthorID,
                                        bookAuthor.Alias,
                                        books.Cover,
                                        books.Title,
                                        books.Description,
                                        // lj_bookTrans_bookReview.Rating,
                                        books.CreatedDate,
                                        books.InlistID
                                    } into bookGrouped
                                    orderby bookGrouped.Key.CreatedDate descending//books.CreatedDate descending
                                    select new{
                                        BookID = bookGrouped.Key.ID,
                                        BookCover = bookGrouped.Key.Cover,
                                        BookAuthorID = bookGrouped.Key.AuthorID,
                                        BookAuthor = bookGrouped.Key.Alias,
                                        BookTitle = bookGrouped.Key.Title,
                                        BookDesc = bookGrouped.Key.Description,
                                        BookRating = bookGrouped.Average(t => t.lj_bookTrans_bookReview.Rating),
                                        bookGrouped.Key.InlistID,
                                        TotalReviewer = (
                                            from reviewer in _context.BookReview
                                            join reviewerBookTrans in _context.BookTransaction
                                            on reviewer.BookTransID equals reviewerBookTrans.ID
                                            where reviewerBookTrans.BookID == bookGrouped.Key.ID
                                            select reviewer
                                        ).Count()
                                    }).Take(3).ToListAsync();

                var newArrival_data = from book in newArrival_Books
                                      join catalog in catalogData
                                      on book.InlistID equals (int)catalog.Id into book_catalog

                                      from lj_book_catalog in book_catalog.DefaultIfEmpty()
                                      select new
                                      {
                                          book.BookID,
                                          //book.BookCover,
                                          BookCover = lj_book_catalog == null ? "" : lj_book_catalog.CoverUrl,
                                          book.BookAuthorID,
                                          book.BookAuthor,
                                          //book.BookTitle,
                                          //book.BookDesc,
                                          BookTitle = lj_book_catalog == null ? "" : lj_book_catalog.Title,
                                          BookDesc = lj_book_catalog == null ? "" : lj_book_catalog.Note,
                                          book.BookRating,
                                          book.InlistID,
                                          book.TotalReviewer,
                                          FileFolder = lj_book_catalog == null ? "" : lj_book_catalog.Name
                                      };

                ViewBag.NewArrivalData = newArrival_data.Distinct().ToList(); //newArrival_Books;

                return PartialView("NewArrival");
            }
            catch (Exception ex)
            {
                Response.Cookies.Append("Error", ex.Message.ToString(), new CookieOptions());
                return PartialView("NewArrival");
            }
            finally
            {
                GC.Collect();
            }
        }
        // public IActionResult NewArrival()
        // {
        //     ViewBag.LoadingNewArrival = true;

        //     try
        //     {
        //         ViewBag.NewArrival = true;
        //         return PartialView("NewArrival");
        //     }
        //     catch (Exception ex)
        //     {
        //         Response.Cookies.Append("Error", ex.Message.ToString(), new CookieOptions());
        //         return PartialView("NewArrival");
        //     }
        //     finally
        //     {
        //         GC.Collect();
        //     }
        // }

        public async Task<IActionResult> TopRating()
        {
            ViewBag.LoadingTopRating = true;

            try
            {
                ViewBag.TopRating = true;

                var query_catalog = from catalog in _inlistContext.Catalogs
                                    join catalogFiles in _inlistContext.Catalogfiles
                                    on catalog.Id equals catalogFiles.CatalogId

                                    join collection in _inlistContext.Collections
                                    on catalog.Id equals collection.CatalogId

                                    join collectionMedia in _inlistContext.Collectionmedias
                                    on collection.MediaId equals collectionMedia.Id

                                    join worksheet in _inlistContext.Worksheets
                                    on collectionMedia.WorksheetId equals worksheet.Id
                                    select new
                                    {
                                        catalog.Id,
                                        worksheet.Name,
                                        catalogFiles.FileUrl,
                                        catalog.CoverUrl,
                                        catalog.Note,
                                        catalog.Title
                                    };

                var catalogData = await query_catalog.Distinct().ToListAsync();

                var query_bookList = await (from books in _context.Books
                                    join bookTrans in _context.BookTransaction
                                    on books.ID equals bookTrans.BookID into book_bookTrans
                                    from lj_book_bookTrans in book_bookTrans.DefaultIfEmpty()
                                    join bookReview in _context.BookReview
                                    on lj_book_bookTrans.ID equals bookReview.BookTransID into bookTrans_bookReview
                                    from lj_bookTrans_bookReview in bookTrans_bookReview.DefaultIfEmpty()
                                    join bookAuthor in _context.Author
                                    on books.AuthorID equals bookAuthor.ID
                                    where books.Status == true
                                    group new{
                                        books,
                                        lj_book_bookTrans,
                                        lj_bookTrans_bookReview,
                                        bookAuthor
                                    } by new {
                                        books.ID,
                                        // bookTransID = lj_book_bookTrans.ID,
                                        books.AuthorID,
                                        bookAuthor.Alias,
                                        books.Cover,
                                        books.Title,
                                        books.Description,
                                        // lj_bookTrans_bookReview.Rating,
                                        books.CreatedDate,
                                        books.InlistID
                                    } into bookGrouped
                                    select new{
                                        BookID = bookGrouped.Key.ID,
                                        BookCover = bookGrouped.Key.Cover,
                                        BookAuthorID = bookGrouped.Key.AuthorID,
                                        BookAuthor = bookGrouped.Key.Alias,
                                        BookTitle = bookGrouped.Key.Title,
                                        BookDesc = bookGrouped.Key.Description,
                                        BookRating = bookGrouped.Average(t => t.lj_bookTrans_bookReview.Rating),
                                        bookGrouped.Key.InlistID,
                                        TotalReviewer = (
                                            from reviewer in _context.BookReview
                                            join reviewerBookTrans in _context.BookTransaction
                                            on reviewer.BookTransID equals reviewerBookTrans.ID
                                            where reviewerBookTrans.BookID == bookGrouped.Key.ID
                                            select reviewer
                                        ).Count()
                                    }).Take(3).ToListAsync();

                var topRating_data = from book in query_bookList
                                      join catalog in catalogData
                                      on book.InlistID equals (int)catalog.Id into book_catalog

                                      from lj_book_catalog in book_catalog.DefaultIfEmpty()
                                      select new
                                      {
                                          book.BookID,
                                          //book.BookCover,
                                          BookCover = lj_book_catalog == null ? "" : lj_book_catalog.CoverUrl,
                                          book.BookAuthorID,
                                          book.BookAuthor,
                                          //book.BookTitle,
                                          //book.BookDesc,
                                          BookTitle = lj_book_catalog == null ? "" : lj_book_catalog.Title,
                                          BookDesc = lj_book_catalog == null ? "" : lj_book_catalog.Note,
                                          book.BookRating,
                                          book.InlistID,
                                          book.TotalReviewer,
                                          FileFolder = lj_book_catalog == null ? "" : lj_book_catalog.Name
                                      };

                var topRating_books = (from bookList in topRating_data
                                        orderby bookList.BookRating descending
                                        select bookList).Distinct().ToList();

                ViewBag.TopRatingData = topRating_books.OrderByDescending(x => x.BookRating);

                return PartialView("TopRating");
            }
            catch (Exception ex)
            {
                Response.Cookies.Append("Error", ex.Message.ToString(), new CookieOptions());
                return PartialView("TopRating");
            }
            finally
            {
                GC.Collect();
            }
        }
        // public IActionResult TopRating()
        // {
        //     ViewBag.LoadingTopRating = true;

        //     try
        //     {
        //         ViewBag.TopRating = true;
        //         return PartialView("TopRating");
        //     }
        //     catch (Exception ex)
        //     {
        //         Response.Cookies.Append("Error", ex.Message.ToString(), new CookieOptions());
        //         return PartialView("TopRating");
        //     }
        //     finally
        //     {
        //         GC.Collect();
        //     }
        // }

        public async Task<IActionResult> TopView()
        {
            ViewBag.LoadingTopView = true;

            try
            {
                ViewBag.TopView = true;

                var query_catalog = from catalog in _inlistContext.Catalogs
                                    join catalogFiles in _inlistContext.Catalogfiles
                                    on catalog.Id equals catalogFiles.CatalogId

                                    join collection in _inlistContext.Collections
                                    on catalog.Id equals collection.CatalogId

                                    join collectionMedia in _inlistContext.Collectionmedias
                                    on collection.MediaId equals collectionMedia.Id

                                    join worksheet in _inlistContext.Worksheets
                                    on collectionMedia.WorksheetId equals worksheet.Id
                                    select new
                                    {
                                        catalog.Id,
                                        worksheet.Name,
                                        catalogFiles.FileUrl,
                                        catalog.CoverUrl,
                                        catalog.Note,
                                        catalog.Title
                                    };

                var catalogData = await query_catalog.Distinct().ToListAsync();

                var query_bookList = await (from books in _context.Books
                                    join bookTrans in _context.BookTransaction
                                    on books.ID equals bookTrans.BookID into book_bookTrans
                                    from lj_book_bookTrans in book_bookTrans.DefaultIfEmpty()
                                    join bookReview in _context.BookReview
                                    on lj_book_bookTrans.ID equals bookReview.BookTransID into bookTrans_bookReview
                                    from lj_bookTrans_bookReview in bookTrans_bookReview.DefaultIfEmpty()
                                    join bookAuthor in _context.Author
                                    on books.AuthorID equals bookAuthor.ID
                                    where books.Status == true
                                    group new{
                                        books,
                                        lj_book_bookTrans,
                                        lj_bookTrans_bookReview,
                                        bookAuthor
                                    } by new {
                                        books.ID,
                                        // bookTransID = lj_book_bookTrans.ID,
                                        books.AuthorID,
                                        bookAuthor.Alias,
                                        books.Cover,
                                        books.Title,
                                        books.Description,
                                        // lj_bookTrans_bookReview.Rating,
                                        books.CreatedDate,
                                        books.InlistID
                                    } into bookGrouped
                                    select new{
                                        BookID = bookGrouped.Key.ID,
                                        BookCover = bookGrouped.Key.Cover,
                                        BookAuthorID = bookGrouped.Key.AuthorID,
                                        BookAuthor = bookGrouped.Key.Alias,
                                        BookTitle = bookGrouped.Key.Title,
                                        BookDesc = bookGrouped.Key.Description,
                                        BookRating = bookGrouped.Average(t => t.lj_bookTrans_bookReview.Rating),
                                        bookGrouped.Key.InlistID,
                                        TotalReviewer = (
                                            from reviewer in _context.BookReview
                                            join reviewerBookTrans in _context.BookTransaction
                                            on reviewer.BookTransID equals reviewerBookTrans.ID
                                            where reviewerBookTrans.BookID == bookGrouped.Key.ID
                                            select reviewer
                                        ).Count(),
                                        TotalView = (
                                            from viewedBook in _context.BookTransaction
                                            where viewedBook.BookID == bookGrouped.Key.ID
                                            select viewedBook
                                        ).Count()
                                    }).Take(3).ToListAsync();

                var topRating_data = from book in query_bookList
                                     join catalog in catalogData
                                      on book.InlistID equals (int)catalog.Id into book_catalog

                                      from lj_book_catalog in book_catalog.DefaultIfEmpty()
                                      select new
                                      {
                                          book.BookID,
                                          //book.BookCover,
                                          BookCover = lj_book_catalog == null ? "" : lj_book_catalog.CoverUrl,
                                          book.BookAuthorID,
                                          book.BookAuthor,
                                          //book.BookTitle,
                                          //book.BookDesc,
                                          BookTitle = lj_book_catalog == null ? "" : lj_book_catalog.Title,
                                          BookDesc = lj_book_catalog == null ? "" : lj_book_catalog.Note,
                                          book.BookRating,
                                          book.InlistID,
                                          book.TotalReviewer,
                                          book.TotalView,
                                          FileFolder = lj_book_catalog == null ? "" : lj_book_catalog.Name
                                      };

                var topView_books = (from bookList in topRating_data
                                           orderby bookList.TotalView descending
                                        select bookList).Distinct().ToList();

                ViewBag.TopViewData = topView_books.OrderByDescending(x => x.TotalView);

                return PartialView("TopView");
            }
            catch (Exception ex)
            {
                Response.Cookies.Append("Error", ex.Message.ToString(), new CookieOptions());
                return PartialView("TopView");
            }
            finally
            {
                GC.Collect();
            }
        }
        // public IActionResult TopView()
        // {
        //     ViewBag.LoadingTopView = true;

        //     try
        //     {
        //         ViewBag.TopView = true;
        //         return PartialView("TopView");
        //     }
        //     catch (Exception ex)
        //     {
        //         Response.Cookies.Append("Error", ex.Message.ToString(), new CookieOptions());
        //         return PartialView("TopView");
        //     }
        //     finally
        //     {
        //         GC.Collect();
        //     }
        // }

        public IActionResult TopRatingByCategory()
        {
            ViewBag.LoadingTopRatingByCategory = true;

            try
            {
                ViewBag.TopRatingByCategory = true;
                return PartialView("TopRatingByCategory");
            }
            catch (Exception ex)
            {
                Response.Cookies.Append("Error", ex.Message.ToString(), new CookieOptions());
                return PartialView("TopRatingByCategory");
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
