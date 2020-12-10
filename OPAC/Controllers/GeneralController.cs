using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OPAC.ViewModels;

namespace OPAC.Controllers
{
    public class GeneralController
    {

        private readonly IWebHostEnvironment _env;

        public GeneralController(IWebHostEnvironment env)
        {
            _env = env;
        }

        [NonAction]
        public void SendEmailResetPassword(string email, string newPassword)
        {
            try
            {
                var fromEmail = new MailAddress("opac.balitbang@gmail.com", "OPAC Mail System");
                var toEmail = new MailAddress(email);
                var fromEmailPassword = "opac1122"; //"@litbang2019!"; // Replace with actual password
                string subject = "OPAC - Reset Password";

                string body = "<html><body>" +
                    "<p>Selamat, anda telah berhasil mereset password. </p>" +
                    "Password baru anda : " + newPassword + "<br/><br/>" +
                    "<p><i>Email ini dikirim secara otomatis oleh sistem, diharapkan tidak membalas email ini.</i></p>" +
                    "</body></html>";

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromEmail.Address, fromEmailPassword)
                };

                MailMessage message = new MailMessage();  
                message.From = fromEmail;  
                message.To.Add(toEmail);  
                message.Subject = subject;  
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = body;

                smtp.Send(message);   
            }
            catch (Exception ex)
            {
                throw ex;                
            }
        }

        [NonAction]
        public void SendEmailRegistration(string email, string username, string password)
        {
            try
            {
                var fromEmail = new MailAddress("opac.balitbang@gmail.com", "OPAC Mail System");
                var toEmail = new MailAddress(email);
                var fromEmailPassword = "opac1122"; //"@litbang2019!"; // Replace with actual password
                string subject = "OPAC - Registration Success";

                string body = "<html><body>" +
                    "<p>Selamat, anda telah berhasil registrasi ke dalam sistem OPAC. </p>" +
                    "<br/>" +
                    "Username : " + username + "<br/>" +
                    "Password : " + password + "<br/>" +
                    "<br/>" +
                    "<p><i>Email ini dikirim secara otomatis oleh sistem, diharapkan tidak membalas email ini.</i></p>" +
                    "</body></html>";

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromEmail.Address, fromEmailPassword)
                };

                MailMessage message = new MailMessage();  
                message.From = fromEmail;  
                message.To.Add(toEmail);  
                message.Subject = subject;  
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = body;

                smtp.Send(message);   
            }
            catch (Exception ex)
            {
                throw ex;                
            }
        }

        public string UploadAvatarAccount(AccountViewModel model)
        {
            try
            {
                string fileName = "";
                if (model.userViewModel != null)
                {

                    if (model.userViewModel.PhotoBase64 != null)
                    {
                        string uploadFolder = Path.Combine(_env.WebRootPath, "Content/profpic");
                        fileName = model.user.ID.ToString() + "_" + model.user.NIP + "_" + model.userViewModel.Photo.FileName;
                        string filePath = Path.Combine(uploadFolder, fileName);

                        string filesToDelete = @"user_" + model.user.ID.ToString() + "*";   // Only delete files containing user id
                        string[] fileList = System.IO.Directory.GetFiles(uploadFolder, filesToDelete);
                        foreach (string file in fileList)
                        {
                            //System.Diagnostics.Debug.WriteLine(file + "will be deleted");
                            System.IO.File.Delete(file);
                        }

                        File.WriteAllBytes(filePath, Convert.FromBase64String(model.userViewModel.PhotoBase64.Split(",")[1]));

                        return fileName;
                    }
                    else
                    {
                        return "";
                    }
                }
                else
                {
                    return "";
                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public string UploadImage(AccountViewModel model) {
            try
            {
                string fileName = "";
                if (model.userViewModel != null) {

                    if (model.userViewModel.Photo != null) {
                        string uploadFolder = Path.Combine(_env.WebRootPath, "Content/profpic");
                        fileName = model.user.ID.ToString() + "_" + model.user.NIP + "_" + model.userViewModel.Photo.FileName;
                        string filePath = Path.Combine(uploadFolder, fileName);

                        string filesToDelete = @"user_" + model.user.ID.ToString() + "*";   // Only delete files containing user id
                        string[] fileList = System.IO.Directory.GetFiles(uploadFolder, filesToDelete);
                        foreach(string file in fileList)
                        {
                            //System.Diagnostics.Debug.WriteLine(file + "will be deleted");
                            System.IO.File.Delete(file);
                        }

                        model.userViewModel.Photo.CopyTo(new FileStream(filePath, FileMode.Create));

                        return fileName;
                    }
                    else {
                        return "";
                    }
                }
                else {
                    return "";
                }
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public string UploadAvatarAuthor(AuthorViewModel model)
        {
            string fileName = "";
            if (model.author != null)
            {

                if (model.PhotoBase64 != null)
                {
                    string uploadFolder = Path.Combine(_env.WebRootPath, "Content/profpic");
                    fileName = "author_" + model.author.ID.ToString() + "_" + model.Photo.FileName;
                    string filePath = Path.Combine(uploadFolder, fileName);

                    string filesToDelete = @"author_" + model.author.ID.ToString() + "*";   // Only delete files containing author id
                    string[] fileList = System.IO.Directory.GetFiles(uploadFolder, filesToDelete);
                    foreach (string file in fileList)
                    {
                        //System.Diagnostics.Debug.WriteLine(file + "will be deleted");
                        System.IO.File.Delete(file);
                    }

                    File.WriteAllBytes(filePath, Convert.FromBase64String(model.PhotoBase64.Split(",")[1]));

                    return fileName;
                }
                else
                {
                    return "";
                }
            }
            else
            {
                return "";
            }
        }

        public string UploadImageAuthor(AuthorViewModel model) {
            try
            {
                string fileName = "";
                if (model.author != null) {

                    if (model.Photo != null) {
                        string uploadFolder = Path.Combine(_env.WebRootPath, "Content/profpic");
                        fileName = "author_" + model.author.ID.ToString() + "_" + model.Photo.FileName;
                        string filePath = Path.Combine(uploadFolder, fileName);

                        string filesToDelete = @"author_" + model.author.ID.ToString() + "*";   // Only delete files containing author id
                        string[] fileList = System.IO.Directory.GetFiles(uploadFolder, filesToDelete);
                        foreach(string file in fileList)
                        {
                            //System.Diagnostics.Debug.WriteLine(file + "will be deleted");
                            System.IO.File.Delete(file);
                        }

                        model.Photo.CopyTo(new FileStream(filePath, FileMode.Create));

                        return fileName;
                    }
                    else {
                        return "";
                    }
                }
                else {
                    return "";
                }
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public string UploadImageBook(BookViewModel model) {
            try
            {
                string fileName = "";
                Guid g = Guid.NewGuid();
                if (model.book != null) {

                    if (model.Cover != null) {
                        string uploadFolder = Path.Combine(_env.WebRootPath, "Content/cover");
                        fileName = "bookCover_" + g.ToString() + "_" + model.Cover.FileName;
                        string filePath = Path.Combine(uploadFolder, fileName);

                        // string filesToDelete = @"bookCover_" + model.book.ID.ToString() + "*";   // Only delete files containing book id
                        // string[] fileList = System.IO.Directory.GetFiles(uploadFolder, filesToDelete);
                        // foreach(string file in fileList)
                        // {
                        //     //System.Diagnostics.Debug.WriteLine(file + "will be deleted");
                        //     System.IO.File.Delete(file);
                        // }

                        model.Cover.CopyTo(new FileStream(filePath, FileMode.Create));

                        return fileName;
                    }
                    else {
                        return "";
                    }
                }
                else {
                    return "";
                }
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public string UploadEBook(BookViewModel model) {
            try
            {
                string fileName = "";
                if (model.book != null) {

                    if (model.FileURL != null) {
                        string uploadFolder = Path.Combine(_env.WebRootPath, "Content/files");
                        fileName = "eBook_" + model.book.ID.ToString() + "_" + model.FileURL.FileName;
                        string filePath = Path.Combine(uploadFolder, fileName);

                        // string filesToDelete = @"eBook_" + model.book.ID.ToString() + "*";   // Only delete files containing book id
                        // string[] fileList = System.IO.Directory.GetFiles(uploadFolder, filesToDelete);
                        // foreach(string file in fileList)
                        // {
                        //     //System.Diagnostics.Debug.WriteLine(file + "will be deleted");
                        //     System.IO.File.Delete(file);
                        // }

                        model.FileURL.CopyTo(new FileStream(filePath, FileMode.Create));

                        return fileName;
                    }
                    else {
                        return "";
                    }
                }
                else {
                    return "";
                }
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }

    public class PaginatedList<T> : List<T>
    {
        public int PageIndex { get; private set; }
        public int TotalPages { get; private set; }
        public int PageSize { get; private set; }

        private const int defaultPageSize = 5;

        public PaginatedList(List<T> items, int count, int pageIndex, int pageSize = defaultPageSize)
        {
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);

            PageSize = pageSize;

            this.AddRange(items);
        }

        public bool HasPreviousPage
        {
            get
            {
                return (PageIndex > 1);
            }
        }

        public bool HasNextPage
        {
            get
            {
                return (PageIndex < TotalPages);
            }
        }

        public static async Task<PaginatedList<T>> CreateAsync(
            IQueryable<T> source, int pageIndex, int pageSize = defaultPageSize)
        {
            var count = await source.CountAsync();
            var items = await source.Skip(
                (pageIndex - 1) * pageSize)
                .Take(pageSize).ToListAsync();
            return new PaginatedList<T>(items, count, pageIndex, pageSize);
        }
    }
}