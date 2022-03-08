using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_dorm.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult AdminCity()
        {
            return PartialView();
        }
        public PartialViewResult AdminUniversity()
        {
            return PartialView();
        }

        public PartialViewResult AdminDorm()
        {
            return PartialView();
        }

        public PartialViewResult AdminAbout()
        {
            return PartialView();
        }

        public PartialViewResult AdminNews()
        {
            return PartialView();
        }
        public PartialViewResult AdminSponsor()
        {
            return PartialView();
        }
        public PartialViewResult AdminComment()
        {
            return PartialView();
        }

        public PartialViewResult AdminSocialMedia()
        {
            return PartialView();
        }
    }
}