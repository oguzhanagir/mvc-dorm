using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace mvc_dorm.Controllers
{
    [Authorize]
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult AdminLogin()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult AdminLogin(Admin p)
        {
            Context c = new Context();

            var userinfo = c.Admins.FirstOrDefault(x => x.UserName == p.UserName && x.Password == p.Password);
            if (userinfo != null)
            {
                FormsAuthentication.SetAuthCookie(userinfo.UserName, false);
                Session["UserName"] = userinfo.UserName.ToString();
                return RedirectToAction("AdminDorm", "Admin");
            }
            else
            {
                return RedirectToAction("AdminLogin", "Login");
            }
        }


    }
}