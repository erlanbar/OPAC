using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OPAC.Data;
using OPAC.Models;
using OPAC.ViewModels;

using Microsoft.AspNetCore.Identity;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Http;
using System.Net.Mail;
using System.Net;

using System.Web;
using Microsoft.AspNetCore.Hosting;

namespace OPAC.Controllers
{
    public class LoginController : Controller
    {
        private readonly BookContext _context;
        private readonly GeneralController gc;

        public LoginController(IWebHostEnvironment env, BookContext context)
        {
            _context = context;

            gc = new GeneralController(env);
        }

        public IActionResult Index()
        {
            ViewBag.ResultCode = TempData["ResultCode"];
            ViewBag.ResultMessage = TempData["ResultMessage"];

            if (HttpContext.Session.GetString("NIP") == null || HttpContext.Session.GetString("NIP") == "") {

                return View();
            }
            else {

                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult ForgotPassword()
        {
            // ViewBag.ResultCode = TempData["ResultCode"];
            // ViewBag.ResultMessage = TempData["ResultMessage"];

            return View();
        }

        // POST: Book/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel login)
        {

            using (var _contextTran = await _context.Database.BeginTransactionAsync()) 
            {
                try
                {
                    if (HttpContext.Session.GetString("NIP") == null || HttpContext.Session.GetString("NIP") == "") {

                        //login dari socmed
                        if (login.IsFromSocmed) {

                            if (login.SocmedToken != "") {

                                //cek emailnya sudah terdaftar atau belum
                                var signInResult = await (
                                    from users in _context.User
                                    where users.Email == login.Email
                                    select users
                                ).FirstOrDefaultAsync();

                                if (signInResult != null) { //sudah pernah register

                                    HttpContext.Session.SetString("NIP", signInResult.NIP);
                                    HttpContext.Session.SetInt32("UserID", signInResult.ID);

                                    signInResult.LastLogin = DateTime.Now; //update last login
                                    _context.Update(signInResult);
                                    await _context.SaveChangesAsync();

                                    return RedirectToAction("Index", "Home");
                                }
                                else { //login dengan akun socmed

                                    User user = new User{
                                        CreatedDate = DateTime.Now,
                                        Creator = "Socmed",
                                        Email = login.Email,
                                        LastLogin = DateTime.Now,
                                        Name = login.Name,
                                        NIP = login.Email.Split("@")[0].ToLower(),
                                        SocmedToken = login.SocmedToken,
                                        NIK = "",
                                        Photo = "default.png",
                                        Status = true
                                    };

                                    _context.Add(user);
                                    await _context.SaveChangesAsync();

                                    UserRole userRole = new UserRole();
                                    userRole.NIP = login.Email.Split("@")[0].ToLower();
                                    userRole.RoleID = 3; //hardcore role user reader
                                    userRole.Status = true;
                                    userRole.CreatedDate = DateTime.Now;
                                    userRole.Creator = "Socmed";

                                    _context.Add(userRole);
                                    await _context.SaveChangesAsync();

                                    await _contextTran.CommitAsync();

                                    HttpContext.Session.SetString("NIP", user.NIP);
                                    HttpContext.Session.SetInt32("UserID", signInResult.ID);

                                    signInResult.LastLogin = DateTime.Now; //update last login
                                    _context.Update(signInResult);
                                    await _context.SaveChangesAsync();

                                    return RedirectToAction("Index", "Home");
                                }
                            }
                            else {

                                ViewBag.ResultCode = 0;
                                ViewBag.ResultMessage = "Token not valid";
                                return View("Index", login);
                            }
                        }
                        else if (ModelState.IsValid)
                        {
                            var signInResult = await (
                                from users in _context.User
                                where users.NIP == login.NIP && users.Password == getSHA1Hash(login.Password)
                                select users
                            ).FirstOrDefaultAsync();

                            if (signInResult != null) {

                                HttpContext.Session.SetString("NIP", login.NIP);
                                HttpContext.Session.SetInt32("UserID", signInResult.ID);

                                HttpContext.Session.SetString("Guest", login.NIP);

                                signInResult.LastLogin = DateTime.Now; //update last login
                                _context.Update(signInResult);
                                await _context.SaveChangesAsync();

                                return RedirectToAction("Index", "Home");
                            }
                            else 
                            {

                                ViewBag.ResultCode = 0;
                                ViewBag.ResultMessage = "Username / Password salah";
                                return View("Index", login);
                            }
                        }
                        else 
                        {
                            return View("Index", login);
                        }
                    }
                    else {

                        return RedirectToAction("Index", "Home");
                    }
                }
                catch (System.Exception)
                {
                    
                    throw;
                }
            }
        }

        // [HttpPost]
        // [ValidateAntiForgeryToken]
        public IActionResult LogOut()
        {

            try
            {
                HttpContext.Session.Clear();

                return RedirectToAction("Index", "Login");
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel model) 
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var user = await (
                        from users in _context.User
                        where users.NIP == model.NIP && users.Email == model.Email
                        select users
                    ).FirstOrDefaultAsync();

                    if (user != null) {

                        string tempPassword = GenerateRandomString(8);

                        gc.SendEmailResetPassword(model.Email, tempPassword);

                        user.Password = getSHA1Hash(tempPassword);
                        _context.Update(user);
                        await _context.SaveChangesAsync();

                        TempData["ResultCode"] = 1;
                        TempData["ResultMessage"] = "Password berhasil direset. Mohon cek email anda untuk melihat password baru anda dan dimohon untuk mengganti password anda dengan yang baru di halaman Account";

                        return RedirectToAction("Index", "Login");
                    }
                    else {

                        TempData["ResultCode"] = 0;
                        TempData["ResultMessage"] = "Username / email anda tidak ditemukan";

                        return RedirectToAction("Index", "Login");
                    }
                }
                else {

                    return View("Index");
                }
            }
            catch (Exception ex)
            {
                
                TempData["ResultCode"] = 0;
                TempData["ResultMessage"] = ex.ToString();

                return RedirectToAction("Index", "Login");
            }
        }

        public IActionResult Register()
        {
            ViewBag.ResultCode = TempData["ResultCode"];
            ViewBag.ResultMessage = TempData["ResultMessage"];

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model) 
        {
            using (var _contextTran = await _context.Database.BeginTransactionAsync()) 
            {
                try
                {
                    //guest mode
                    if (model.account.user.Pekerjaan.ToLower() == "guest")
                    {
                        model.account.user.NIP = Guid.NewGuid().ToString().Substring(0, 8);
                        model.account.user.NIK = "";
                        model.account.user.Email = "";
                        model.account.user.Alamat = "";
                        model.account.user.PendidikanTerakhir = "";
                        model.account.user.Password = Guid.NewGuid().ToString().Substring(0, 8);
                        model.account.user.Creator = "GUEST";
                        model.account.user.CreatedDate = DateTime.Now;
                        model.account.user.Status = true;

                        _context.Add(model.account.user);
                        await _context.SaveChangesAsync();

                        HttpContext.Session.SetString("Guest", model.account.user.NIP);

                        await _contextTran.CommitAsync();

                        TempData["ResultCode"] = 1;
                        TempData["ResultMessage"] = "Selamat datang " + model.account.user.Name;

                        return RedirectToAction("Index", "Home");
                    }
                    //register mode
                    else
                    {
                        if (ModelState.IsValid)
                        {
                            var user = await (
                                from users in _context.User
                                where users.NIP == model.account.user.NIP || users.Email == model.account.user.Email
                                select users
                            ).FirstOrDefaultAsync();

                            if (user == null)
                            {

                                // model.account.user.Photo = "";
                                // string photoPath = gc.UploadImage(model.account);
                                if (model.account.userViewModel == null)
                                {
                                    model.account.user.Photo = "";
                                }
                                else
                                {
                                    model.account.user.Photo = gc.UploadAvatarAccount(model.account); //gc.UploadImage(model.account);
                                }
                                model.account.user.Password = getSHA1Hash(model.account.changePasswordViewModel.ConfirmNewPassword);
                                model.account.user.Status = true;
                                model.account.user.Creator = "REGISTER";
                                model.account.user.CreatedDate = DateTime.Now;

                                _context.Add(model.account.user);
                                await _context.SaveChangesAsync();

                                UserRole userRole = new UserRole();
                                userRole.NIP = model.account.user.NIP;
                                userRole.RoleID = 3; //hardcore role user reader
                                userRole.Status = true;
                                userRole.CreatedDate = DateTime.Now;
                                userRole.Creator = "REGISTER";

                                _context.Add(userRole);
                                await _context.SaveChangesAsync();

                                gc.SendEmailRegistration(model.account.user.Email, model.account.user.NIP, model.account.changePasswordViewModel.ConfirmNewPassword);

                                await _contextTran.CommitAsync();

                                TempData["ResultCode"] = 1;
                                TempData["ResultMessage"] = "Registrasi berhasil. Mohon login dengan username dan password yang sudah anda daftarkan";

                                // return View("Index");
                                return RedirectToAction("Index", "Login");
                            }
                            else
                            {

                                ViewBag.ResultCode = 0;
                                ViewBag.ResultMessage = "Username / Email sudah digunakan. Mohon input username / email lain";

                                return View("Register");
                            }

                        }
                        else
                        {

                            ViewBag.ResultCode = 0;
                            ViewBag.ResultMessage = "Mohon isi semua field";

                            return View("Register");
                        }
                    }
                }
                catch (Exception ex)
                {
                    await _contextTran.RollbackAsync();
                    
                    ViewBag.ResultCode = 0;
                    ViewBag.ResultMessage = ex.ToString();

                    if (model.account.user.Pekerjaan.ToLower() == "guest")
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        return View("Register");
                    }
                }
            }
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

        [NonAction]
        public string GenerateRandomString(int iLength)
        {
            string sResult = "";
            try
            {
                Random rdm = new Random();
                char[] allowChrs = "0123456789".ToCharArray();

                for (int i = 0; i <= iLength - 1; i++)
                    sResult += allowChrs[rdm.Next(0, allowChrs.Length)];

                return sResult;
            }
            catch(Exception ex)
            {
                return sResult;
            }
        }
    }
}
