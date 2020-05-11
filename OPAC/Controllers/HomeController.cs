using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OPAC.Models;

namespace OPAC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.UITitle = "Index";
            ViewBag.UI = "Featured";
            return View();
        }

        public IActionResult Detail()
        {
            ViewBag.UITitle = "Detail";
            ViewBag.UI = "Featured";
            return View();
        }

        public IActionResult MyBook()
        {
            ViewBag.UITitle = "Detail";
            ViewBag.UI = "MyBook";
            return View();
        }

        public IActionResult MyList()
        {
            ViewBag.UITitle = "Detail";
            ViewBag.UI = "Wishlist";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult NewArrival()
        {
            ViewBag.LoadingNewArrival = true;

            try
            {
                ViewBag.NewArrival = true;
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

        public IActionResult TopRating()
        {
            ViewBag.LoadingTopRating = true;

            try
            {
                ViewBag.TopRating = true;
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

        public IActionResult TopView()
        {
            ViewBag.LoadingTopView = true;

            try
            {
                ViewBag.TopView = true;
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
