using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jieye.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            
                return View();
        }
        public ActionResult Shouye() {
            return View();
        }
       public ActionResult Changting()
        {
            return View();
        }

        public ActionResult Yuding() {
            return View();
        }



    }
}