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

namespace OPAC.Controllers
{
    public class LoginController : Controller
    {
        private readonly BookContext _context;

        public LoginController(BookContext context)
        {
            _context = context;
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

            try
            {
                if (HttpContext.Session.GetString("NIP") == null || HttpContext.Session.GetString("NIP") == "") {
                    if (ModelState.IsValid)
                    {
                        var signInResult = await (
                            from users in _context.User
                            where users.NIP == login.NIP && users.Password == getSHA1Hash(login.Password)
                            select users
                        ).FirstOrDefaultAsync();

                        if (signInResult != null) {

                            HttpContext.Session.SetString("NIP", login.NIP);

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

                        GeneralController gc = new GeneralController();
                        gc.SendEmailResetPassword(model.Email, tempPassword);

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
