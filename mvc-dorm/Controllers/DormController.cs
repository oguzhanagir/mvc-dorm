using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_dorm.Controllers
{
    public class DormController : Controller
    {
      
        // GET: Dorm
        DormManager _dm = new DormManager();

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult HeaderDorm()
        {
            return PartialView();
        }

        public PartialViewResult PopularDorm()
        {
            var dormlist = _dm.GetAll();
            return PartialView(dormlist);
        }
        public PartialViewResult DormDetails()
        {
            return PartialView();
        }
        public PartialViewResult DormDetailsHeader()
        {
            return PartialView();
        }

        public PartialViewResult DormDetailsContent()
        {
            return PartialView();
        }

        public PartialViewResult DormDetailsComment()
        {
            return PartialView();
        }
        public ActionResult DormByUniversity()
        {
            return View();
        }
    }
}