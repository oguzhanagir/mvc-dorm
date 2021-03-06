using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_dorm.Controllers
{
    [AllowAnonymous]
    public class UniversityController : Controller
    {
        UniversityManager um = new UniversityManager();

        // GET: University
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult HeaderUniversity()
        {
            
            return PartialView();
        }
        public ActionResult ContentUniversity(string p)
        {
            if (!string.IsNullOrEmpty(p))
            {
                var universityLista = um.UniversityByName(p);
                return PartialView(universityLista);
            }
            var universityList = um.GetAll();
            return PartialView(universityList);
        }
        public ActionResult UniversityDetails(int id)
        {
            var universityList = um.UniversityByID(id);
            return PartialView(universityList);
        }
    }
}