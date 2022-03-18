using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_dorm.Controllers
{
    [AllowAnonymous]
    public class AboutController : Controller
    {
        AboutManager am = new AboutManager();
        // GET: About
        public ActionResult Index()
        {
            var aboutList = am.GetAll();
            return View(aboutList);
        }
    }
}