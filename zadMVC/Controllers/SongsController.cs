using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using zadMVC.Models;

namespace zadMVC.Controllers
{
    public class SongsController : Controller
    {
        // GET: Songs
        public ActionResult Index()
        {
            var song = new Song("Chciałem być", "Krzysztof Krawczyk", "Ballada", 1);
            return View(song);
            //return Content("Hello world");
        }

        public ActionResult Square(int number)
        {
            var message = Math.Pow(number, 2).ToString();
            return Content(message);
        }
    }
}