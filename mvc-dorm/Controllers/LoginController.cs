using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_dorm.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult AdminLogin()
        {
            return PartialView();
        }
        public PartialViewResult AuthorLogin()
        {
            return PartialView();
        }
    }
}