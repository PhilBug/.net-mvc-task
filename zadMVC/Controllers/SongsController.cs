using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace zadMVC.Controllers
{
    public class SongsController : Controller
    {
        // GET: Songs
        public ActionResult Index()
        {
            return View();
            //return Content("Hello world");
        }

        public ActionResult Square(int number)
        {
            var message = Math.Pow(number, 2).ToString();
            return Content(message);
        }
    }
}