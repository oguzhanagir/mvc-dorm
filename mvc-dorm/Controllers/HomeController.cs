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
        DormManager dm = new DormManager();
        SponsorManager sm = new SponsorManager();
        NewsManager nm = new NewsManager();
        SocialMediaManager socm = new SocialMediaManager();
        public ActionResult Index()
        {
            var dormList = dm.GetAll();
            return View(dormList);
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
            var dormList = dm.GetAll();
            return PartialView(dormList);
        }

        public PartialViewResult SponsorHome()
        {
            var sponsorList = sm.GetAll();
            return PartialView(sponsorList);
        }
        
        public PartialViewResult Cities()
        {
            return PartialView();
        }
        public PartialViewResult News()
        {
            var newsList = nm.GetAll();
            return PartialView(newsList);
        }

        public ActionResult Footer()
        {
            var socialList = socm.GetAll();
            return PartialView(socialList);
        }

        public ActionResult Slider()
        {
            var dormList = dm.GetAll();
            return PartialView(dormList);
        }



    }
}