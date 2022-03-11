using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_dorm.Controllers
{
   
    public class HomeController : Controller
    {
        AboutManager am = new AboutManager();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Header()
        {
            var headerAboutList = am.GetAll();
            return PartialView(headerAboutList);
        }

        public PartialViewResult HomeAbout()
        {
            var aboutList = am.GetAll();
            return PartialView(aboutList);
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