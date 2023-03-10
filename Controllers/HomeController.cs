using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Win32.SafeHandles;

namespace ShopifyTest.Controllers
{
    public class HomeController : Controller
    {
        public static string Secret = ConfigurationManager.AppSettings["Secret"];
        [HttpGet]
        public ActionResult Index()
        {
            var secret = Secret;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}