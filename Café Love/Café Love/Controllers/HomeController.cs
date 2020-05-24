using Microsoft.Owin.Security.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Café_Love.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Principal");
            }
            else
            {

                return View();
            }
            return null;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Descripción de página";

            return View();
        }


        public ActionResult Menu()
        {

            return View();
        }

        public ActionResult Conocenos()
        {
            return View();
        }
    }

}
