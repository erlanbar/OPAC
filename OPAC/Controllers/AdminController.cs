using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OPAC.Data;
using OPAC.Models;
using OPAC.ViewModels;

namespace OPAC.Controllers
{
    public class AdminController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly BookContext _context;
        private readonly GeneralController gc;
        private string sess_nip = "";

        public AdminController(IWebHostEnvironment env, BookContext context)
        {
            _env = env;
            _context = context;
            gc = new GeneralController(env);
        }

        public IActionResult Index()
        {
            sess_nip = HttpContext.Session.GetString("NIP");

            if (sess_nip == null || sess_nip == "") {

                return View("Index", "Login");
            }

            ViewBag.Tab = TempData["Tab"] == null ? "Category" : TempData["Tab"];

            ViewBag.ResultCode = TempData["ResultCode"];
            ViewBag.ResultMessage = TempData["ResultMessage"];

            return View();
        }

        #region Category

        public async Task<IActionResult> Category(string searchStr, int? pageIndex)
        {
            ViewBag.LoadingData = true;

            try
            {

                if (searchStr == null) {
                    searchStr = "";
                }
                searchStr = searchStr.ToLower();

                var query_data = from datas in _context.Categories
                    where datas.Status == true && datas.Description.ToLower().Contains(searchStr)
                    select datas;

                IQueryable<Category> dataIQ = query_data;

                int pageSize = 3;
                var data = await PaginatedList<Category>.CreateAsync(
                dataIQ, pageIndex ?? 1, pageSize);

                ViewBag.SearchStr = searchStr;

                ViewBag.Data = data;
                ViewBag.Mode = "View";

                CategoryViewModel dataInViewModel = new CategoryViewModel();
                dataInViewModel.dataPaging = data;

                return PartialView("Category", dataInViewModel);
            }
            catch (Exception ex)
            {
                
                TempData["Tab"] = "Category";   
                TempData["ResultCode"] = 0;
                TempData["ResultMessage"] = ex.Message;

                return RedirectToAction("Index", "Admin");
            }
        }

        public IActionResult CreateCategory()
        {
            string sess_nip = HttpContext.Session.GetString("NIP");

            if (sess_nip == null || sess_nip == "") {

                return View("Index", "Login");
            }

            Category data = new Category();
            data.ID = 0;
            data.Description = "";
            data.Creator = "";

            CategoryViewModel dataInViewModel = new CategoryViewModel();
            dataInViewModel.category = data;

            ViewBag.Mode = "Create";

            return PartialView("Category", dataInViewModel);
        }

        public async Task<IActionResult> EditCategory(int id)
        {
            ViewBag.LoadingData = true;

            try
            {
                var data = await (
                    from datas in _context.Categories
                    where datas.ID == id
                    select datas
                ).FirstAsync();

                CategoryViewModel dataInViewModel = new CategoryViewModel();
                dataInViewModel.category = data;

                ViewBag.Data = data;
                ViewBag.Mode = "Edit";

                return PartialView("Category", dataInViewModel);
            }
            catch (Exception ex)
            {
                
                TempData["Tab"] = "Category";   
                TempData["ResultCode"] = 0;
                TempData["ResultMessage"] = ex.Message;

                return RedirectToAction("Index", "Admin");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddEditCategory(CategoryViewModel model)
        {
            try
            {

                string sess_nip = HttpContext.Session.GetString("NIP");

                if (sess_nip == null || sess_nip == "") {

                    return View("Index", "Login");
                }

                if (ModelState.IsValid)
                {

                    if (model.category.ID == 0) { //insert

                        if (IsCategoryExist(model.category.Description)) {

                            TempData["ResultCode"] = 0;
                            TempData["ResultMessage"] = "Data sudah ada. Mohon input data lain";
                        }
                        else {

                            model.category.Status = true;
                            model.category.Creator = sess_nip.ToString();
                            model.category.CreatedDate = DateTime.Now;

                            _context.Add(model.category);
                            await _context.SaveChangesAsync();

                            TempData["ResultCode"] = 1;
                            TempData["ResultMessage"] = "Data Berhasil disimpan";
                        }

                        // ViewBag.Mode = "Create";
                    }
                    else { //update

                        var _model = (
                            from datas in _context.Categories
                            where datas.ID == model.category.ID
                            select datas
                        ).FirstOrDefault();

                        _model.Description = model.category.Description;
                        _model.Modifier = sess_nip.ToString();
                        _model.ModifiedDate = DateTime.Now;

                        _context.Update(_model);
                        await _context.SaveChangesAsync();

                        model.category = _model;

                        TempData["ResultCode"] = 1;
                        TempData["ResultMessage"] = "Data Berhasil disimpan";
                    }
                }

                TempData["Tab"] = "Category";

                return RedirectToAction("Index", "Admin");
            }
            catch (Exception ex)
            {

                TempData["Tab"] = "Category";   
                TempData["ResultCode"] = 0;
                TempData["ResultMessage"] = ex.Message;

                return RedirectToAction("Index", "Admin");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteCategory(CategoryViewModel model)
        {
            try
            {

                string sess_nip = HttpContext.Session.GetString("NIP");

                if (sess_nip == null || sess_nip == "") {

                    return RedirectToAction("Index", "Login");
                }

                var _datas = (
                    from datas in _context.Categories
                    where datas.ID == model.category.ID
                    select datas
                ).FirstOrDefault();

                if (_datas != null) {

                    _datas.Status = false;
                    _datas.Modifier = sess_nip;
                    _datas.ModifiedDate = DateTime.Now;

                    _context.Update(_datas);
                    await _context.SaveChangesAsync();

                    TempData["ResultCode"] = 1;
                    TempData["ResultMessage"] = "Data Berhasil dihapus";
                }
                else {

                    TempData["ResultCode"] = 0;
                    TempData["ResultMessage"] = "Data tidak ditemukan";
                }

                TempData["Tab"] = "Category";

                return RedirectToAction("Index", "Admin");
            }
            catch (Exception ex)
            {
                
                TempData["Tab"] = "Category";   
                TempData["ResultCode"] = 0;
                TempData["ResultMessage"] = ex.Message;

                return RedirectToAction("Index", "Admin");
            }
        }

        private bool IsCategoryExist(string description)
        {
            return _context.Categories.Any(e => e.Description == description && e.Status == true);
        }
    
        #endregion
        #region "Tag"

        public async Task<IActionResult> Tag(string searchStr, int? pageIndex)
        {
            ViewBag.LoadingData = true;

            try
            {

                if (searchStr == null) {
                    searchStr = "";
                }
                searchStr = searchStr.ToLower();

                var query_data = from datas in _context.Tags
                    where datas.Status == true && datas.Description.ToLower().Contains(searchStr)
                    select datas;

                IQueryable<Tag> dataIQ = query_data;

                int pageSize = 3;
                var data = await PaginatedList<Tag>.CreateAsync(
                dataIQ, pageIndex ?? 1, pageSize);

                ViewBag.SearchStr = searchStr;

                ViewBag.Data = data;
                ViewBag.Mode = "View";

                TagViewModel dataInViewModel = new TagViewModel();
                dataInViewModel.dataPaging = data;

                return PartialView("Tag", dataInViewModel);
            }
            catch (Exception ex)
            {
                
                TempData["Tab"] = "Tag";   
                TempData["ResultCode"] = 0;
                TempData["ResultMessage"] = ex.Message;

                return RedirectToAction("Index", "Admin");
            }
        }

        public IActionResult CreateTag()
        {
            string sess_nip = HttpContext.Session.GetString("NIP");

            if (sess_nip == null || sess_nip == "") {

                return View("Index", "Login");
            }

            Tag data = new Tag();
            data.ID = 0;
            data.Description = "";
            data.Creator = "";

            TagViewModel dataInViewModel = new TagViewModel();
            dataInViewModel.tag = data;

            ViewBag.Mode = "Create";

            return PartialView("Tag", dataInViewModel);
        }

        public async Task<IActionResult> EditTag(int id)
        {
            ViewBag.LoadingData = true;

            try
            {
                var data = await (
                    from datas in _context.Tags
                    where datas.ID == id
                    select datas
                ).FirstAsync();

                TagViewModel dataInViewModel = new TagViewModel();
                dataInViewModel.tag = data;

                ViewBag.Data = data;
                ViewBag.Mode = "Edit";

                return PartialView("Tag", dataInViewModel);
            }
            catch (Exception ex)
            {
                
                TempData["Tab"] = "Tag";   
                TempData["ResultCode"] = 0;
                TempData["ResultMessage"] = ex.Message;

                return RedirectToAction("Index", "Admin");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddEditTag(TagViewModel model)
        {
            try
            {

                string sess_nip = HttpContext.Session.GetString("NIP");

                if (sess_nip == null || sess_nip == "") {

                    return View("Index", "Login");
                }

                if (ModelState.IsValid)
                {

                    if (model.tag.ID == 0) { //insert

                        if (IsTagExist(model.tag.Description)) {

                            TempData["ResultCode"] = 0;
                            TempData["ResultMessage"] = "Data sudah ada. Mohon input data lain";
                        }
                        else {

                            model.tag.Status = true;
                            model.tag.Creator = sess_nip.ToString();
                            model.tag.CreatedDate = DateTime.Now;

                            _context.Add(model.tag);
                            await _context.SaveChangesAsync();

                            TempData["ResultCode"] = 1;
                            TempData["ResultMessage"] = "Data Berhasil disimpan";
                        }

                        // ViewBag.Mode = "Create";
                    }
                    else { //update

                        var _model = (
                            from datas in _context.Tags
                            where datas.ID == model.tag.ID
                            select datas
                        ).FirstOrDefault();

                        _model.Description = model.tag.Description;
                        _model.Modifier = sess_nip.ToString();
                        _model.ModifiedDate = DateTime.Now;

                        _context.Update(_model);
                        await _context.SaveChangesAsync();

                        model.tag = _model;

                        TempData["ResultCode"] = 1;
                        TempData["ResultMessage"] = "Data Berhasil disimpan";
                    }
                }

                TempData["Tab"] = "Tag";

                return RedirectToAction("Index", "Admin");
            }
            catch (Exception ex)
            {

                TempData["Tab"] = "Tag";   
                TempData["ResultCode"] = 0;
                TempData["ResultMessage"] = ex.Message;

                return RedirectToAction("Index", "Admin");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteTag(TagViewModel model)
        {
            try
            {

                string sess_nip = HttpContext.Session.GetString("NIP");

                if (sess_nip == null || sess_nip == "") {

                    return RedirectToAction("Index", "Login");
                }

                var _datas = (
                    from datas in _context.Tags
                    where datas.ID == model.tag.ID
                    select datas
                ).FirstOrDefault();

                if (_datas != null) {

                    _datas.Status = false;
                    _datas.Modifier = sess_nip;
                    _datas.ModifiedDate = DateTime.Now;

                    _context.Update(_datas);
                    await _context.SaveChangesAsync();

                    TempData["ResultCode"] = 1;
                    TempData["ResultMessage"] = "Data Berhasil dihapus";
                }
                else {

                    TempData["ResultCode"] = 0;
                    TempData["ResultMessage"] = "Data tidak ditemukan";
                }

                TempData["Tab"] = "Tag";

                return RedirectToAction("Index", "Admin");
            }
            catch (Exception ex)
            {
                
                TempData["Tab"] = "Tag";   
                TempData["ResultCode"] = 0;
                TempData["ResultMessage"] = ex.Message;

                return RedirectToAction("Index", "Admin");
            }
        }

        private bool IsTagExist(string description)
        {
            return _context.Tags.Any(e => e.Description == description && e.Status == true);
        }

        #endregion
    
        #region "Author"

        public async Task<IActionResult> Author(string searchStr, int? pageIndex)
        {
            ViewBag.LoadingData = true;

            try
            {

                if (searchStr == null) {
                    searchStr = "";
                }
                searchStr = searchStr.ToLower();

                var query_data = from datas in _context.Author
                    where datas.Status == true && (
                        datas.Description.ToLower().Contains(searchStr) ||
                        datas.FirstName.ToLower().Contains(searchStr) ||
                        datas.LastName.ToLower().Contains(searchStr) ||
                        datas.Alias.ToLower().Contains(searchStr)
                    )
                    select datas;

                IQueryable<Author> dataIQ = query_data;

                int pageSize = 3;
                var data = await PaginatedList<Author>.CreateAsync(
                dataIQ, pageIndex ?? 1, pageSize);

                ViewBag.SearchStr = searchStr;

                ViewBag.Data = data;
                ViewBag.Mode = "View";

                AuthorViewModel dataInViewModel = new AuthorViewModel();
                dataInViewModel.dataPaging = data;

                return PartialView("Author", dataInViewModel);
            }
            catch (Exception ex)
            {
                
                TempData["Tab"] = "Author";   
                TempData["ResultCode"] = 0;
                TempData["ResultMessage"] = ex.Message;

                return RedirectToAction("Index", "Admin");
            }
        }

        public IActionResult CreateAuthor()
        {
            string sess_nip = HttpContext.Session.GetString("NIP");

            if (sess_nip == null || sess_nip == "") {

                return View("Index", "Login");
            }

            Author data = new Author();
            data.ID = 0;
            data.FirstName = "";
            data.LastName = "";
            data.Alias = "";
            data.Phone = "";
            data.Email = "";
            data.OtherContact = "";
            data.Description = "";
            data.Creator = "";

            AuthorViewModel dataInViewModel = new AuthorViewModel();
            dataInViewModel.author = data;

            ViewBag.Mode = "Create";

            return PartialView("Author", dataInViewModel);
        }

        public async Task<IActionResult> EditAuthor(int id)
        {
            ViewBag.LoadingData = true;

            try
            {
                var data = await (
                    from datas in _context.Author
                    where datas.ID == id
                    select datas
                ).FirstAsync();

                AuthorViewModel dataInViewModel = new AuthorViewModel();
                dataInViewModel.author = data;

                ViewBag.Data = data;
                ViewBag.Mode = "Edit";

                return PartialView("Author", dataInViewModel);
            }
            catch (Exception ex)
            {
                
                TempData["Tab"] = "Author";   
                TempData["ResultCode"] = 0;
                TempData["ResultMessage"] = ex.Message;

                return RedirectToAction("Index", "Admin");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddEditAuthor(AuthorViewModel model)
        {
            try
            {

                string sess_nip = HttpContext.Session.GetString("NIP");

                if (sess_nip == null || sess_nip == "") {

                    return View("Index", "Login");
                }

                if (ModelState.IsValid)
                {

                    if (model.author.ID == 0) { //insert

                        if (IsAuthorExist(model.author.FirstName, model.author.LastName)) {

                            TempData["ResultCode"] = 0;
                            TempData["ResultMessage"] = "Data sudah ada. Mohon input data lain";
                        }
                        else {

                            model.author.Photo = gc.UploadImageAuthor(model);
                            model.author.Status = true;
                            model.author.Creator = sess_nip.ToString();
                            model.author.CreatedDate = DateTime.Now;

                            _context.Add(model.author);
                            await _context.SaveChangesAsync();

                            TempData["ResultCode"] = 1;
                            TempData["ResultMessage"] = "Data Berhasil disimpan";
                        }

                        // ViewBag.Mode = "Create";
                    }
                    else { //update

                        var _model = (
                            from datas in _context.Author
                            where datas.ID == model.author.ID
                            select datas
                        ).FirstOrDefault();

                        _model.FirstName = model.author.FirstName;
                        _model.LastName = model.author.LastName;
                        _model.Alias = model.author.Alias;
                        if (model.Photo != null) {
                            _model.Photo = gc.UploadImageAuthor(model);
                        }
                        _model.Phone = model.author.Phone;
                        _model.Email = model.author.Email;
                        _model.OtherContact = model.author.OtherContact;
                        _model.Description = model.author.Description;
                        _model.Modifier = sess_nip.ToString();
                        _model.ModifiedDate = DateTime.Now;

                        _context.Update(_model);
                        await _context.SaveChangesAsync();

                        model.author = _model;

                        TempData["ResultCode"] = 1;
                        TempData["ResultMessage"] = "Data Berhasil disimpan";
                    }
                }

                TempData["Tab"] = "Author";

                return RedirectToAction("Index", "Admin");
            }
            catch (Exception ex)
            {

                TempData["Tab"] = "Author";   
                TempData["ResultCode"] = 0;
                TempData["ResultMessage"] = ex.Message;

                return RedirectToAction("Index", "Admin");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteAuthor(AuthorViewModel model)
        {
            try
            {

                string sess_nip = HttpContext.Session.GetString("NIP");

                if (sess_nip == null || sess_nip == "") {

                    return RedirectToAction("Index", "Login");
                }

                var _datas = (
                    from datas in _context.Author
                    where datas.ID == model.author.ID
                    select datas
                ).FirstOrDefault();

                if (_datas != null) {

                    _datas.Status = false;
                    _datas.Modifier = sess_nip;
                    _datas.ModifiedDate = DateTime.Now;

                    _context.Update(_datas);
                    await _context.SaveChangesAsync();

                    TempData["ResultCode"] = 1;
                    TempData["ResultMessage"] = "Data Berhasil dihapus";
                }
                else {

                    TempData["ResultCode"] = 0;
                    TempData["ResultMessage"] = "Data tidak ditemukan";
                }

                TempData["Tab"] = "Author";

                return RedirectToAction("Index", "Admin");
            }
            catch (Exception ex)
            {
                
                TempData["Tab"] = "Author";   
                TempData["ResultCode"] = 0;
                TempData["ResultMessage"] = ex.Message;

                return RedirectToAction("Index", "Admin");
            }
        }

        private bool IsAuthorExist(string firstName, string lastName)
        {
            return _context.Author.Any(e => e.FirstName == firstName && e.LastName == lastName && e.Status == true);
        }

        #endregion
    
        #region "Book"

        public async Task<IActionResult> Book(string searchStr, int? pageIndex)
        {
            ViewBag.LoadingData = true;

            try
            {

                if (searchStr == null) {
                    searchStr = "";
                }
                searchStr = searchStr.ToLower();

                var query_data = from datas in _context.Books
                    where datas.Status == true && (
                        datas.Description.ToLower().Contains(searchStr) ||
                        datas.Title.ToLower().Contains(searchStr)
                    )
                    select datas;
                    

                IQueryable<Book> dataIQ = query_data;

                int pageSize = 3;
                var data = await PaginatedList<Book>.CreateAsync(
                dataIQ, pageIndex ?? 1, pageSize);

                var query_bookCategory = from book in data
                    join bookCategories in _context.BookCategories
                    on book.ID equals bookCategories.BookID into books_bookCategories
                    from lj_books_bookCategories in books_bookCategories.DefaultIfEmpty()
                    join categories in _context.Categories
                    on lj_books_bookCategories.CategoryID equals categories.ID into bookCategories_categories
                    from lj_bookCategories_categories in bookCategories_categories.DefaultIfEmpty()
                    join bookAuthor in _context.Author
                    on book.AuthorID equals bookAuthor.ID
                    where book.Status == true && (
                        book.Description.ToLower().Contains(searchStr) ||
                        book.Title.ToLower().Contains(searchStr)
                    )
                    group new {
                        book,
                        lj_books_bookCategories,
                        lj_bookCategories_categories,
                        bookAuthor
                    }
                    by new {
                        book.ID,
                        book.Title,
                        book.Description,
                        bookAuthor.Alias,
                        book.Creator
                    } into bookGrouped
                    select new {
                        BookID = bookGrouped.Key.ID,
                        BookTitle = bookGrouped.Key.Title,
                        BookDesc = bookGrouped.Key.Description,
                        CategoryList = string.Join(",", bookGrouped.Select(x => x.lj_bookCategories_categories.Description)),
                        Author = bookGrouped.Key.Alias,
                        Creator = bookGrouped.Key.Creator
                    };

                var query_bookCategory_bookTag = from bookCategories in query_bookCategory
                    join bookTag in _context.BookTags
                    on bookCategories.BookID equals bookTag.BookID into book_bookTags
                    from lj_books_bookTags in book_bookTags.DefaultIfEmpty()
                    join tags in _context.Tags
                    on lj_books_bookTags.TagID equals tags.ID into bookTags_tags
                    from lj_bookTags_tags in bookTags_tags.DefaultIfEmpty()
                    group new {
                        bookCategories,
                        lj_books_bookTags,
                        lj_bookTags_tags
                    }
                    by new {
                        bookCategories.BookID,
                        bookCategories.BookTitle,
                        bookCategories.BookDesc,
                        bookCategories.CategoryList,
                        bookCategories.Author,
                        bookCategories.Creator
                    } into bookGrouped
                    select new {
                        BookID = bookGrouped.Key.BookID,
                        BookTitle = bookGrouped.Key.BookTitle,
                        BookDesc = bookGrouped.Key.BookDesc,
                        CategoryList = bookGrouped.Key.CategoryList,
                        TagList = string.Join(",", bookGrouped.Select(x => x.lj_bookTags_tags.Description)),
                        Author = bookGrouped.Key.Author,
                        Creator = bookGrouped.Key.Creator
                    };

                ViewBag.SearchStr = searchStr;

                ViewBag.Data = query_bookCategory_bookTag.Count() == 0 ? null : query_bookCategory_bookTag.ToList();
                ViewBag.Mode = "View";

                BookViewModel dataInViewModel = new BookViewModel();
                dataInViewModel.dataPaging = data;

                return PartialView("Book", dataInViewModel);
            }
            catch (Exception ex)
            {
                
                TempData["Tab"] = "Book";   
                TempData["ResultCode"] = 0;
                TempData["ResultMessage"] = ex.Message;

                return RedirectToAction("Index", "Admin");
            }
        }

        public IActionResult CreateBook()
        {
            string sess_nip = HttpContext.Session.GetString("NIP");

            if (sess_nip == null || sess_nip == "") {

                return View("Index", "Login");
            }

            Book data = new Book();
            data.ID = 0;
            data.Title = "";
            data.Description = "";
            data.FileURL = "";
            data.AuthorID = 0;
            data.Note = "";
            data.IsPublished = false;
            data.Creator = "";

            BookLearn bookLearn = new BookLearn {
                ID = 0,
                BookID = 0,
                Description = "",
                Creator = ""
            };

            BookRequirement bookRequirement = new BookRequirement {
                ID = 0,
                BookID = 0,
                Description = "",
                ReferalBookID = 0,
                Creator = ""
            };

            BookCategory bookCategory = new BookCategory();
            bookCategory.ID = 0;
            bookCategory.BookID = 0;
            bookCategory.CategoryID = 0;
            bookCategory.Creator = "";

            var categoryData = from categories in _context.Categories
                where categories.Status == true
                select categories;

            ViewBag.CategoryData = categoryData;
            ViewBag.CategoryIDList = categoryData.Select(x => new SelectListItem{ Value = x.ID.ToString(), Text = x.Description }); //new MultiSelectList(_context.Categories.Select(x => x.Status == true), "ID", "Description");

            BookTag bookTag = new BookTag();
            bookTag.ID = 0;
            bookTag.BookID = 0;
            bookTag.TagID = 0;
            bookTag.Creator = "";

            var tagData = from tags in _context.Tags
                where tags.Status == true
                select tags;

            ViewBag.TagData = tagData;
            ViewBag.TagIDList = tagData.Select(x => new SelectListItem{ Value = x.ID.ToString(), Text = x.Description }); //new MultiSelectList(_context.Tags.Select(x => x.Status == true), "ID", "Description");

            var authorData = from authors in _context.Author
                where authors.Status == true
                select authors;

            ViewBag.AuthorData = authorData.Select(x => new SelectListItem{ Value = x.ID.ToString(), Text = x.Alias });

            BookViewModel dataInViewModel = new BookViewModel();
            dataInViewModel.book = data;
            dataInViewModel.categories = categoryData.ToList();
            dataInViewModel.tags = tagData.ToList();

            ViewBag.Mode = "Create";

            return PartialView("Book", dataInViewModel);
        }

        public async Task<IActionResult> EditBook(int id)
        {
            ViewBag.LoadingData = true;

            try
            {
                var data = await (
                    from datas in _context.Books
                    where datas.ID == id
                    select datas
                ).FirstAsync();

                var bookLearn = await (
                    from bookLearns in _context.BookLearns
                    where bookLearns.BookID == id
                    select bookLearns
                ).FirstOrDefaultAsync();

                var bookRequirement = await (
                    from bookRequirements in _context.BookRequirements
                    where bookRequirements.BookID == id
                    select bookRequirements
                ).FirstOrDefaultAsync();

                var bookCategory = await (
                    from bookCategories in _context.BookCategories
                    where bookCategories.BookID == id
                    select bookCategories
                ).ToListAsync();

                var categoryData = from categories in _context.Categories
                where categories.Status == true
                select categories;

                var bookTag = await (
                    from bookTags in _context.BookTags
                    where bookTags.BookID == id
                    select bookTags
                ).ToListAsync();

                var tagData = from tags in _context.Tags
                where tags.Status == true
                select tags;

                var authorData = from authors in _context.Author
                where authors.Status == true
                select authors;

                BookViewModel dataInViewModel = new BookViewModel();
                dataInViewModel.book = data;
                dataInViewModel.bookLearns = bookLearn;
                dataInViewModel.bookRequirements = bookRequirement;
                dataInViewModel.bookCategories = bookCategory;
                dataInViewModel.bookTags = bookTag;
                dataInViewModel.categoryIDList = bookCategory.Select(x => x.CategoryID).ToArray();
                dataInViewModel.tagIDList = bookTag.Select(x => x.TagID).ToArray();

                ViewBag.Data = data;
                ViewBag.Mode = "Edit";
                ViewBag.CategoryIDList = categoryData.Select(x => new SelectListItem{ Value = x.ID.ToString(), Text = x.Description });
                ViewBag.TagIDList = tagData.Select(x => new SelectListItem{ Value = x.ID.ToString(), Text = x.Description });
                ViewBag.AuthorData = authorData.Select(x => new SelectListItem{ Value = x.ID.ToString(), Text = x.Alias });

                return PartialView("Book", dataInViewModel);
            }
            catch (Exception ex)
            {
                
                TempData["Tab"] = "Book";   
                TempData["ResultCode"] = 0;
                TempData["ResultMessage"] = ex.Message;

                return RedirectToAction("Index", "Admin");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddEditBook(BookViewModel model)
        {

            using (var _contextTran = await _context.Database.BeginTransactionAsync()) 
            {
                try
                {

                    string sess_nip = HttpContext.Session.GetString("NIP");

                    if (sess_nip == null || sess_nip == "") {

                        return View("Index", "Login");
                    }

                    if (ModelState.IsValid)
                    {

                        string defaultFileName = "default.png";

                        if (model.book.ID == 0) { //insert

                            if (IsBookExist(model.book.Title, model.book.AuthorID)) {

                                TempData["ResultCode"] = 0;
                                TempData["ResultMessage"] = "Data sudah ada. Mohon input data lain";
                            }
                            else {

                                if (model.Cover != null) {
                                    model.book.Cover = gc.UploadImageBook(model);
                                }
                                else {
                                    model.book.Cover = defaultFileName;
                                }
                                model.book.FileURL = gc.UploadEBook(model);
                                model.book.Status = true;
                                model.book.Creator = sess_nip.ToString();
                                model.book.CreatedDate = DateTime.Now;

                                _context.Add(model.book);
                                await _context.SaveChangesAsync();

                                model.bookLearns.BookID = model.book.ID;
                                model.bookLearns.Creator = sess_nip;
                                model.bookLearns.CreatedDate = DateTime.Now;
                                model.bookLearns.Status = true;

                                _context.Add(model.bookLearns);
                                await _context.SaveChangesAsync();

                                model.bookRequirements.BookID = model.book.ID;
                                model.bookRequirements.Creator = sess_nip;
                                model.bookRequirements.CreatedDate = DateTime.Now;
                                model.bookRequirements.Status = true;

                                _context.Add(model.bookRequirements);
                                await _context.SaveChangesAsync();

                                BookCategory bookCategory;
                                foreach (var item in model.categoryIDList)
                                {
                                    bookCategory = new BookCategory();
                                    bookCategory.BookID = model.book.ID;
                                    bookCategory.CategoryID = item;
                                    bookCategory.CreatedDate = DateTime.Now;
                                    bookCategory.Creator = sess_nip;
                                    bookCategory.Status = true;

                                    _context.Add(bookCategory);
                                }
                                await _context.SaveChangesAsync();

                                BookTag bookTag;
                                foreach (var item in model.tagIDList)
                                {
                                    bookTag = new BookTag();
                                    bookTag.BookID = model.book.ID;
                                    bookTag.TagID = item;
                                    bookTag.CreatedDate = DateTime.Now;
                                    bookTag.Creator = sess_nip;
                                    bookTag.Status = true;

                                    _context.Add(bookTag);
                                }
                                await _context.SaveChangesAsync();

                                await _contextTran.CommitAsync();

                                TempData["ResultCode"] = 1;
                                TempData["ResultMessage"] = "Data Berhasil disimpan";
                            }
                        }
                        else { //update

                            var _model = (
                                from datas in _context.Books
                                where datas.ID == model.book.ID
                                select datas
                            ).FirstOrDefault();

                            _model.Title = model.book.Title;
                            _model.Description = model.book.Description;
                            _model.AuthorID = model.book.AuthorID;
                            if (model.Cover != null) {
                                _model.Cover = gc.UploadImageBook(model);
                            }
                            if (model.FileURL != null) {
                                _model.FileURL = gc.UploadEBook(model);
                            }
                            _model.IsPublished = model.book.IsPublished;
                            _model.Flag = model.book.Flag;
                            _model.PreviewedPages = model.book.PreviewedPages;
                            _model.Note = model.book.Note;
                            _model.Modifier = sess_nip.ToString();
                            _model.ModifiedDate = DateTime.Now;

                            _context.Update(_model);
                            await _context.SaveChangesAsync();

                            var bookLearn = await (
                                from datas in _context.BookLearns
                                where datas.ID == model.book.ID
                                select datas
                            ).FirstOrDefaultAsync();

                            if (bookLearn == null) {
                                model.bookLearns.BookID = model.book.ID;
                                model.bookLearns.CreatedDate = DateTime.Now;
                                model.bookLearns.Creator = sess_nip;
                                model.bookLearns.Status = true;

                                bookLearn = model.bookLearns;
                            }
                            else {

                                bookLearn.Description = model.bookLearns.Description;
                                bookLearn.Modifier = sess_nip;
                                bookLearn.ModifiedDate = DateTime.Now;
                            }

                            _context.Update(bookLearn);
                            await _context.SaveChangesAsync();

                            var bookRequirement = await (
                                from datas in _context.BookRequirements
                                where datas.ID == model.book.ID
                                select datas
                            ).FirstOrDefaultAsync();

                            if (bookRequirement == null) {
                                model.bookRequirements.BookID = model.book.ID;
                                model.bookRequirements.CreatedDate = DateTime.Now;
                                model.bookRequirements.Creator = sess_nip;
                                model.bookRequirements.Status = true;

                                bookRequirement = model.bookRequirements;
                            }
                            else {

                                bookRequirement.Description = model.bookRequirements.Description;
                                bookRequirement.Modifier = sess_nip;
                                bookRequirement.ModifiedDate = DateTime.Now;
                            }

                            _context.Update(bookRequirement);
                            await _context.SaveChangesAsync();

                            //hapus data kategori sebelumnya
                            var prevBookCategory = (
                                from prevBookCategories in _context.BookCategories
                                where prevBookCategories.BookID == model.book.ID
                                select prevBookCategories
                            ).ToList();

                            _context.RemoveRange(prevBookCategory);
                            await _context.SaveChangesAsync();

                            //insert data kategori terbaru
                            BookCategory bookCategory;
                            foreach (var item in model.categoryIDList)
                            {
                                bookCategory = new BookCategory();
                                bookCategory.BookID = model.book.ID;
                                bookCategory.CategoryID = item;
                                bookCategory.CreatedDate = DateTime.Now;
                                bookCategory.Creator = sess_nip;
                                bookCategory.Status = true;

                                _context.Add(bookCategory);
                            }
                            await _context.SaveChangesAsync();

                            //hapus data tag sebelumnya
                            var prevBookTag = (
                                from prevBookTags in _context.BookTags
                                where prevBookTags.BookID == model.book.ID
                                select prevBookTags
                            ).ToList();

                            _context.RemoveRange(prevBookTag);
                            await _context.SaveChangesAsync();

                            //insert data tag terbaru
                            BookTag bookTag;
                            foreach (var item in model.tagIDList)
                            {
                                bookTag = new BookTag();
                                bookTag.BookID = model.book.ID;
                                bookTag.TagID = item;
                                bookTag.CreatedDate = DateTime.Now;
                                bookTag.Creator = sess_nip;
                                bookTag.Status = true;

                                _context.Add(bookTag);
                            }
                            await _context.SaveChangesAsync();

                            model.book = _model;

                            await _contextTran.CommitAsync();

                            TempData["ResultCode"] = 1;
                            TempData["ResultMessage"] = "Data Berhasil disimpan";
                        }
                    }

                    TempData["Tab"] = "Book";

                    return RedirectToAction("Index", "Admin");
                }
                catch (Exception ex)
                {

                    TempData["Tab"] = "Book";   
                    TempData["ResultCode"] = 0;
                    TempData["ResultMessage"] = ex.Message;

                    await _contextTran.RollbackAsync();

                    return RedirectToAction("Index", "Admin");
                }
            
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteBook(BookViewModel model)
        {

            using (var _contextTran = await _context.Database.BeginTransactionAsync()) 
            {
                try
                {

                    string sess_nip = HttpContext.Session.GetString("NIP");

                    if (sess_nip == null || sess_nip == "") {

                        return RedirectToAction("Index", "Login");
                    }

                    var _datas = (
                        from datas in _context.Books
                        where datas.ID == model.book.ID
                        select datas
                    ).FirstOrDefault();

                    if (_datas != null) {

                        _datas.Status = false;
                        _datas.Modifier = sess_nip;
                        _datas.ModifiedDate = DateTime.Now;

                        _context.Update(_datas);
                        await _context.SaveChangesAsync();

                        var bookLearn = await (
                            from datas in _context.BookLearns
                            where datas.ID == model.book.ID
                            select datas
                        ).FirstOrDefaultAsync();

                        bookLearn.Status = false;
                        bookLearn.Modifier = sess_nip;
                        bookLearn.ModifiedDate = DateTime.Now;

                        _context.Update(bookLearn);
                        await _context.SaveChangesAsync();

                        var bookRequirement = await (
                            from datas in _context.BookRequirements
                            where datas.ID == model.book.ID
                            select datas
                        ).FirstOrDefaultAsync();

                        bookRequirement.Status = false;
                        bookRequirement.Modifier = sess_nip;
                        bookRequirement.ModifiedDate = DateTime.Now;

                        _context.Update(bookRequirement);
                        await _context.SaveChangesAsync();

                        var bookCategories = (
                            from datas in _context.BookCategories
                            where datas.BookID == model.book.ID
                            select datas
                        ).ToList();

                        foreach (var item in bookCategories)
                        {
                            item.ModifiedDate = DateTime.Now;
                            item.Modifier = sess_nip;
                            item.Status = false;

                            _context.Update(item);
                        }
                        await _context.SaveChangesAsync();

                        var bookTags = (
                            from datas in _context.BookTags
                            where datas.BookID == model.book.ID
                            select datas
                        ).ToList();

                        foreach (var item in bookTags)
                        {
                            item.ModifiedDate = DateTime.Now;
                            item.Modifier = sess_nip;
                            item.Status = false;

                            _context.Update(item);
                        }
                        await _context.SaveChangesAsync();

                        await _contextTran.CommitAsync();

                        TempData["ResultCode"] = 1;
                        TempData["ResultMessage"] = "Data Berhasil dihapus";
                    }
                    else {

                        TempData["ResultCode"] = 0;
                        TempData["ResultMessage"] = "Data tidak ditemukan";
                    }

                    TempData["Tab"] = "Book";

                    return RedirectToAction("Index", "Admin");
                }
                catch (Exception ex)
                {
                    
                    TempData["Tab"] = "Book";   
                    TempData["ResultCode"] = 0;
                    TempData["ResultMessage"] = ex.Message;

                    await _contextTran.RollbackAsync();

                    return RedirectToAction("Index", "Admin");
                }
            }

        }

        private bool IsBookExist(string title, int authorID)
        {
            return _context.Books.Any(e => e.Title == title && e.AuthorID == authorID && e.Status == true);
        }

        #endregion
   
        #region Role

        public async Task<IActionResult> Role(string searchStr, int? pageIndex)
        {
            ViewBag.LoadingData = true;

            try
            {

                if (searchStr == null) {
                    searchStr = "";
                }
                searchStr = searchStr.ToLower();

                var query_data = from datas in _context.Role
                    where datas.Status == true && datas.Description.ToLower().Contains(searchStr)
                    select datas;

                IQueryable<Role> dataIQ = query_data;

                int pageSize = 3;
                var data = await PaginatedList<Role>.CreateAsync(
                dataIQ, pageIndex ?? 1, pageSize);

                ViewBag.SearchStr = searchStr;

                ViewBag.Data = data;
                ViewBag.Mode = "View";

                RoleViewModel dataInViewModel = new RoleViewModel();
                dataInViewModel.dataPaging = data;

                return PartialView("Role", dataInViewModel);
            }
            catch (Exception ex)
            {
                
                TempData["Tab"] = "Role";   
                TempData["ResultCode"] = 0;
                TempData["ResultMessage"] = ex.Message;

                return RedirectToAction("Index", "Admin");
            }
        }

        public IActionResult CreateRole()
        {
            string sess_nip = HttpContext.Session.GetString("NIP");

            if (sess_nip == null || sess_nip == "") {

                return RedirectToAction("Index", "Login");
            }

            Role data = new Role();
            data.ID = 0;
            data.Description = "";
            data.Creator = "";

            RoleViewModel dataInViewModel = new RoleViewModel();
            dataInViewModel.role = data;

            ViewBag.Mode = "Create";

            return PartialView("Role", dataInViewModel);
        }

        public async Task<IActionResult> EditRole(int id)
        {
            ViewBag.LoadingData = true;

            try
            {
                var data = await (
                    from datas in _context.Role
                    where datas.ID == id
                    select datas
                ).FirstAsync();

                RoleViewModel dataInViewModel = new RoleViewModel();
                dataInViewModel.role = data;

                ViewBag.Data = data;
                ViewBag.Mode = "Edit";

                return PartialView("Role", dataInViewModel);
            }
            catch (Exception ex)
            {
                
                TempData["Tab"] = "Role";   
                TempData["ResultCode"] = 0;
                TempData["ResultMessage"] = ex.Message;

                return RedirectToAction("Index", "Admin");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddEditRole(RoleViewModel model)
        {
            try
            {

                string sess_nip = HttpContext.Session.GetString("NIP");

                if (sess_nip == null || sess_nip == "") {

                    return View("Index", "Login");
                }

                if (ModelState.IsValid)
                {

                    if (model.role.ID == 0) { //insert

                        if (IsRoleExist(model.role.Description)) {

                            TempData["ResultCode"] = 0;
                            TempData["ResultMessage"] = "Data sudah ada. Mohon input data lain";
                        }
                        else {

                            model.role.Status = true;
                            model.role.Creator = sess_nip.ToString();
                            model.role.CreatedDate = DateTime.Now;

                            _context.Add(model.role);
                            await _context.SaveChangesAsync();

                            TempData["ResultCode"] = 1;
                            TempData["ResultMessage"] = "Data Berhasil disimpan";
                        }

                        // ViewBag.Mode = "Create";
                    }
                    else { //update

                        var _model = (
                            from datas in _context.Role
                            where datas.ID == model.role.ID
                            select datas
                        ).FirstOrDefault();

                        _model.Description = model.role.Description;
                        _model.Modifier = sess_nip.ToString();
                        _model.ModifiedDate = DateTime.Now;

                        _context.Update(_model);
                        await _context.SaveChangesAsync();

                        model.role = _model;

                        TempData["ResultCode"] = 1;
                        TempData["ResultMessage"] = "Data Berhasil disimpan";
                    }
                }

                TempData["Tab"] = "Role";

                return RedirectToAction("Index", "Admin");
            }
            catch (Exception ex)
            {

                TempData["Tab"] = "Role";   
                TempData["ResultCode"] = 0;
                TempData["ResultMessage"] = ex.Message;

                return RedirectToAction("Index", "Admin");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteRole(RoleViewModel model)
        {
            try
            {

                string sess_nip = HttpContext.Session.GetString("NIP");

                if (sess_nip == null || sess_nip == "") {

                    return RedirectToAction("Index", "Login");
                }

                var _datas = (
                    from datas in _context.Role
                    where datas.ID == model.role.ID
                    select datas
                ).FirstOrDefault();

                if (_datas != null) {

                    _datas.Status = false;
                    _datas.Modifier = sess_nip;
                    _datas.ModifiedDate = DateTime.Now;

                    _context.Update(_datas);
                    await _context.SaveChangesAsync();

                    TempData["ResultCode"] = 1;
                    TempData["ResultMessage"] = "Data Berhasil dihapus";
                }
                else {

                    TempData["ResultCode"] = 0;
                    TempData["ResultMessage"] = "Data tidak ditemukan";
                }

                TempData["Tab"] = "Role";

                return RedirectToAction("Index", "Admin");
            }
            catch (Exception ex)
            {
                
                TempData["Tab"] = "Role";   
                TempData["ResultCode"] = 0;
                TempData["ResultMessage"] = ex.Message;

                return RedirectToAction("Index", "Admin");
            }
        }

        private bool IsRoleExist(string description)
        {
            return _context.Role.Any(e => e.Description == description && e.Status == true);
        }
    
        #endregion
        
        #region "UserRole"

        public async Task<IActionResult> UserRole(string searchStr, int? pageIndex)
        {
            ViewBag.LoadingData = true;

            try
            {

                if (searchStr == null) {
                    searchStr = "";
                }
                searchStr = searchStr.ToLower();

                var query_data = from datas in _context.User
                    join userRoles in _context.UserRole
                    on datas.NIP equals userRoles.NIP //into user_userRoles
                    where datas.Status == true && userRoles.Status == true && (
                        datas.Name.ToLower().Contains(searchStr) ||
                        datas.NIP.ToLower().Contains(searchStr)
                    )
                    select datas;
                    

                IQueryable<User> dataIQ = query_data;

                int pageSize = 3;
                var data = await PaginatedList<User>.CreateAsync(
                dataIQ, pageIndex ?? 1, pageSize);

                var query_userRoles = from user in data
                    join userRoles in _context.UserRole
                    on user.NIP equals userRoles.NIP //into user_userRoles
                    join roles in _context.Role
                    on userRoles.RoleID equals roles.ID
                    // from lj_user_userRoles in user_userRoles.DefaultIfEmpty()
                    // join roles in _context.Role
                    // on lj_user_userRoles.RoleID equals roles.ID into userRoles_roles
                    // from lj_userRoles_roles in userRoles_roles.DefaultIfEmpty()
                    // where lj_user_userRoles.Status == true
                    group new {
                        user,
                        userRoles,
                        roles
                        // lj_user_userRoles,
                        // lj_userRoles_roles
                    }
                    by new {
                        user.ID,
                        user.NIP,
                        user.Name,
                        user.Creator
                    } into userGrouped
                    select new {
                        UserID = userGrouped.Key.ID,
                        UserNIP = userGrouped.Key.NIP,
                        UserName = userGrouped.Key.Name,
                        UserRoleDesc = string.Join(",", userGrouped.Select(x => x.roles.Description)),
                        // UserRoleDesc = string.Join(",", userGrouped.Select(x => x.lj_userRoles_roles.Description)),
                        Creator = userGrouped.Key.Creator
                    };

                ViewBag.SearchStr = searchStr;

                ViewBag.Data = query_userRoles.Count() == 0 ? null : query_userRoles.ToList();
                ViewBag.Mode = "View";

                UserRoleViewModel dataInViewModel = new UserRoleViewModel();
                dataInViewModel.dataPaging = data;

                return PartialView("UserRole", dataInViewModel);
            }
            catch (Exception ex)
            {
                
                TempData["Tab"] = "UserRole";   
                TempData["ResultCode"] = 0;
                TempData["ResultMessage"] = ex.Message;

                return RedirectToAction("Index", "Admin");
            }
        }

        public IActionResult CreateUserRole()
        {
            string sess_nip = HttpContext.Session.GetString("NIP");

            if (sess_nip == null || sess_nip == "") {

                return View("Index", "Login");
            }

            var data = (
                from datas in _context.User
                where datas.Status == true
                select datas
            ).ToList();

            ViewBag.UserNameList = data.Select(x => new SelectListItem{ Value = x.ID.ToString(), Text = x.Name });

            UserRole userRole = new UserRole();
            userRole.ID = 0;
            userRole.NIP = "";
            userRole.RoleID = 0;
            userRole.Creator = "";

            var roleData = from roles in _context.Role
                where roles.Status == true
                select roles;

            ViewBag.RoleData = roleData;
            ViewBag.RoleIDList = roleData.Select(x => new SelectListItem{ Value = x.ID.ToString(), Text = x.Description });

            UserRoleViewModel dataInViewModel = new UserRoleViewModel();
            // dataInViewModel.user = data;
            dataInViewModel.roles = roleData.ToList();
            dataInViewModel.roleID = 0;

            ViewBag.Mode = "Create";

            return PartialView("UserRole", dataInViewModel);
        }

        public async Task<IActionResult> EditUserRole(int id)
        {
            ViewBag.LoadingData = true;

            try
            {
                var data = await (
                    from datas in _context.User
                    where datas.ID == id
                    select datas
                ).ToListAsync();

                ViewBag.UserNameList = data.Select(x => new SelectListItem{ Value = x.ID.ToString(), Text = x.Name });

                var userRole = await (
                    from userRoles in _context.UserRole
                    join users in _context.User
                    on userRoles.NIP equals users.NIP
                    where users.ID == id
                    select new {
                        userRoles, 
                        users
                    }
                ).ToListAsync();

                var roleData = from roles in _context.Role
                where roles.Status == true
                select roles;

                UserRoleViewModel dataInViewModel = new UserRoleViewModel();
                dataInViewModel.user = userRole.Select(x => x.users).First();
                dataInViewModel.userRoles = userRole.Select(x => x.userRoles).ToList();
                dataInViewModel.roleIDList = userRole.Select(x => x.userRoles.RoleID).ToArray();
                dataInViewModel.roleID = userRole.Select(x => x.userRoles.RoleID).First();

                ViewBag.Data = data;
                ViewBag.Mode = "Edit";
                ViewBag.RoleIDList = roleData.Select(x => new SelectListItem{ Value = x.ID.ToString(), Text = x.Description });

                return PartialView("UserRole", dataInViewModel);
            }
            catch (Exception ex)
            {
                
                TempData["Tab"] = "UserRole";   
                TempData["ResultCode"] = 0;
                TempData["ResultMessage"] = ex.Message;

                return RedirectToAction("Index", "Admin");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddEditUserRole(UserRoleViewModel model)
        {

            using (var _contextTran = await _context.Database.BeginTransactionAsync()) 
            {
                try
                {

                    string sess_nip = HttpContext.Session.GetString("NIP");

                    if (sess_nip == null || sess_nip == "") {

                        return View("Index", "Login");
                    }

                    if (ModelState.IsValid)
                    {
                        // if (model.user.ID == 0) { //insert

                        if (IsUserRoleExist(model.user.ID, model.roleID)) {

                            TempData["ResultCode"] = 0;
                            TempData["ResultMessage"] = "Data sudah ada. Mohon input data lain";
                        }
                        else {

                            var userRoleData = (
                                from userRoles in _context.UserRole
                                join user in _context.User
                                on userRoles.NIP equals user.NIP
                                where user.ID == model.user.ID
                                select userRoles
                            );

                            if (userRoleData == null) {

                                UserRole userRole = new UserRole();
                                userRole.NIP = model.user.NIP;
                                userRole.RoleID = model.roleID;
                                userRole.CreatedDate = DateTime.Now;
                                userRole.Creator = sess_nip;
                                userRole.Status = true;

                                _context.Add(userRole);
                                await _context.SaveChangesAsync();

                                await _contextTran.CommitAsync();

                                TempData["ResultCode"] = 1;
                                TempData["ResultMessage"] = "Data Berhasil disimpan";
                            }
                            else {

                                var _model = (
                                    from datas in _context.UserRole
                                    join user in _context.User
                                    on datas.NIP equals user.NIP
                                    where user.ID == model.user.ID
                                    select datas
                                ).FirstOrDefault();

                                _model.RoleID = model.roleID;
                                _model.Modifier = sess_nip;
                                _model.ModifiedDate = DateTime.Now;
                                _context.Update(_model);
                                await _context.SaveChangesAsync();

                                await _contextTran.CommitAsync();

                                TempData["ResultCode"] = 1;
                                TempData["ResultMessage"] = "Data Berhasil disimpan";
                            }
                        }
                        // }
                        // else { //update

                        //     var _model = (
                        //         from datas in _context.UserRole
                        //         where datas.NIP == model.user.NIP
                        //         select datas
                        //     ).FirstOrDefault();

                        //     _model.RoleID = model.roleID;
                        //     _model.Modifier = sess_nip;
                        //     _model.ModifiedDate = DateTime.Now;
                        //     _context.Update(_model);

                        //     await _contextTran.CommitAsync();

                        //     TempData["ResultCode"] = 1;
                        //     TempData["ResultMessage"] = "Data Berhasil disimpan";
                        // }
                    }

                    TempData["Tab"] = "UserRole";

                    return RedirectToAction("Index", "Admin");
                }
                catch (Exception ex)
                {

                    TempData["Tab"] = "UserRole";   
                    TempData["ResultCode"] = 0;
                    TempData["ResultMessage"] = ex.Message;

                    await _contextTran.RollbackAsync();

                    return RedirectToAction("Index", "Admin");
                }
            
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteUserRole(UserRoleViewModel model)
        {
            try
            {

                string sess_nip = HttpContext.Session.GetString("NIP");

                if (sess_nip == null || sess_nip == "") {

                    return RedirectToAction("Index", "Login");
                }

                var _datas = (
                    from datas in _context.UserRole
                    join user in _context.User
                    on datas.NIP equals user.NIP
                    where user.ID == model.user.ID
                    select datas
                ).FirstOrDefault();

                if (_datas != null) {

                    _datas.Status = false;
                    _datas.Modifier = sess_nip;
                    _datas.ModifiedDate = DateTime.Now;

                    _context.Update(_datas);
                    await _context.SaveChangesAsync();

                    TempData["ResultCode"] = 1;
                    TempData["ResultMessage"] = "Data Berhasil dihapus";
                }
                else {

                    TempData["ResultCode"] = 0;
                    TempData["ResultMessage"] = "Data tidak ditemukan";
                }

                TempData["Tab"] = "UserRole";

                return RedirectToAction("Index", "Admin");
            }
            catch (Exception ex)
            {
                
                TempData["Tab"] = "UserRole";   
                TempData["ResultCode"] = 0;
                TempData["ResultMessage"] = ex.Message;

                return RedirectToAction("Index", "Admin");
            }
        }

        [HttpGet]
        private string GetUserName(int ID) {

            try
            {
                var data = (
                    from datas in _context.User
                    where datas.ID == ID
                    select datas
                ).FirstOrDefault();

                return data.Name;
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        private bool IsUserRoleExist(int ID, int roleID)
        {
            var userNIP = (
                from userRole in _context.UserRole
                join user in _context.User
                on userRole.NIP equals user.NIP
                where user.ID == ID && userRole.RoleID == roleID
                select userRole
            ).FirstOrDefault();

            if (userNIP != null) {
                return true;
            }
            else {
                return false;
            }

            // return _context.UserRole.Any(e => e.NIP == nip && e.Status == true);
        }

        #endregion
   
    }
}
