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
        CommentManager cm = new CommentManager();
        CitiesManager cim = new CitiesManager();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HeaderDorm()
        {
            var cityList = cim.GetAll();
            return PartialView(cityList);
        }

        public PartialViewResult PopularDorms()
        {
            var dormList = _dm.GetAll();
            return PartialView(dormList);
        }
        
        public PartialViewResult DormDetails()
        {
            
            return PartialView();
        }
        public ActionResult DormDetailsHeader(int id)
        {
            var dormDetailsList = _dm.DormByID(id);
            return PartialView(dormDetailsList);
        }

        public ActionResult DormDetailsContent(int id)
        {
            var dormDetailsList = _dm.DormByID(id);
            return PartialView(dormDetailsList);
        }

        [HttpGet]
        public ActionResult DormDetailsComment(int id)
        {
            ViewBag.id = id;
            return PartialView();
        }
        [HttpPost]
        public ActionResult DormDetailsComment(Comment c)
        {
            cm.CommentAdd(c);
            return PartialView();
        }

        public PartialViewResult DormComments(int id)
        {
            var commentList = cm.CommentByDorm(id);
            return PartialView(commentList);
        }

      
        public ActionResult DormByUniversity()
        {
            return View();
        }
    }
}