using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OPAC.Controllers
{
    public class HelpDeskController : Controller
    {
        // GET: HelpDesk
        public ActionResult Index()
        {
            return View();
        }

        // GET: HelpDesk/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HelpDesk/Create
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult User()
        {
            ViewBag.UITitle = "User";
            ViewBag.UI = "ContactUs";
            return View();
        }

        public ActionResult Admin()
        {
            ViewBag.UITitle = "Admin";
            ViewBag.UI = "ContactUs";
            return View();
        }

        // POST: HelpDesk/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HelpDesk/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HelpDesk/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HelpDesk/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HelpDesk/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}