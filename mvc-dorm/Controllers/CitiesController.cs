using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_dorm.Controllers
{
    public class CitiesController : Controller
    {
        // GET: Cities
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult HeaderCities()
        {
            return PartialView();
        }

        public PartialViewResult ContentCities()
        {
            return PartialView();
        }
        public PartialViewResult CitiesDetails()
        {
            return PartialView();
        }
    }
}