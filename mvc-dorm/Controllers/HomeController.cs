using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_dorm.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Header()
        {
            return PartialView();
        }

        public PartialViewResult HomeAbout()
        {
            return PartialView();
        }

        public PartialViewResult PopularDorm()
        {
            return PartialView();
        }

        public PartialViewResult SponsorHome()
        {
            return PartialView();
        }
        
        public PartialViewResult Cities()
        {
            return PartialView();
        }
        public PartialViewResult News()
        {
            return PartialView();
        }

        public PartialViewResult Footer()
        {
            return PartialView();
        }



    }
}