using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_dorm.Controllers
{
    public class UniversityController : Controller
    {
        // GET: University
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult HeaderUniversity()
        {
            return PartialView();
        }
        public PartialViewResult ContentUniversity()
        {
            return PartialView();
        }
        public PartialViewResult UniversityDetails()
        {
            return PartialView();
        }
    }
}