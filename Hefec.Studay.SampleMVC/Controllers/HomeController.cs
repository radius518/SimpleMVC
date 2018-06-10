using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hefec.Studay.SampleMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string msg = string.Format(@"这世界，我来了");
                ViewBag.Message = msg;
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