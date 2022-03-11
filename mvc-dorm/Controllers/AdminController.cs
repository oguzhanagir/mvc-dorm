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
    public class AdminController : Controller
    {
        DormManager dm = new DormManager();
        UniversityManager um = new UniversityManager();
        CitiesManager cm = new CitiesManager();
        AboutManager am = new AboutManager();
        DistrictManager dism = new DistrictManager();

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult AdminCity()
        {
            var cityList = cm.GetAll();
            return PartialView(cityList);
        }
        public PartialViewResult AdminUniversity()
        {
            var universityList = um.GetAll();
            return PartialView(universityList);
        }

        public PartialViewResult AdminDorm()
        {
            var dormList = dm.GetAll();
            return PartialView(dormList);
        }

        public PartialViewResult AdminAbout()
        {
            var aboutList = am.GetAll();
            return PartialView(aboutList);
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

        // Dorm Add

        [HttpGet]
        public ActionResult DormNew()
        {
            Context c = new Context();

            List<SelectListItem> values = (from x in c.Cities.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CityName,
                                               Value = x.CityID.ToString()
                                           }).ToList();
            ViewBag.values = values;


            List<SelectListItem> values2 = (from x in c.Authors.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.AuthorName,
                                                Value = x.AuthorID.ToString()
                                            }).ToList();
            ViewBag.values2 = values2;

            return View();
        }

        [HttpPost]
        public ActionResult DormNew(Dorm p)
        {
            dm.DormAddBl(p);
            return RedirectToAction("AdminDorm");
        }

        //Dorm Delete
        public ActionResult DeleteDorm(int id)
        {
            dm.DeleteDormBL(id);
            return RedirectToAction("AdminDorm");

        }

        //Dorm Update

        [HttpGet]
        public ActionResult UpdateDorm(int id)
        {
            Context c = new Context();

            List<SelectListItem> values = (from x in c.Cities.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CityName,
                                               Value = x.CityID.ToString()
                                           }).ToList();
            ViewBag.values = values;


            List<SelectListItem> values2 = (from x in c.Authors.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.AuthorName,
                                                Value = x.AuthorID.ToString()
                                            }).ToList();
            ViewBag.values2 = values2;
            Dorm dorm = dm.FindDorm(id);
            return View(dorm);
        }

        [HttpPost]
        public ActionResult UpdateDorm(Dorm p)
        {
            dm.UpdateDorm(p);
            return RedirectToAction("AdminProductList");

        }

        //City Add

        [HttpGet]
        public ActionResult CityNew()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult CityNew(City p)
        {
            cm.CityAddBl(p);
            return RedirectToAction("AdminCity");
        }

       


        //City Delete
        public ActionResult DeleteCity(int id)
        {
            cm.DeleteCityBL(id);
            return RedirectToAction("AdminCity");

        }


        //İlçe Ekleme

        [HttpGet]
        public ActionResult DistrictNew()
        {
            Context c = new Context();

            List<SelectListItem> values = (from x in c.Cities.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CityName,
                                               Value = x.CityID.ToString()
                                           }).ToList();
            ViewBag.values = values;

            return PartialView();
        }

        [HttpPost]
        public ActionResult DistrictNew(District p)
        {
            dism.DistrictAddBl(p);
            return RedirectToAction("AdminCity");
        }

        [HttpGet]
        public ActionResult UniversityNew()
        {
            Context c = new Context();

            List<SelectListItem> values = (from x in c.Cities.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CityName,
                                               Value = x.CityID.ToString()
                                           }).ToList();
            ViewBag.values = values;
            return PartialView();
        }

        [HttpPost]
        public ActionResult UniversityNew(University p)
        {
            um.UniversityAddBl(p);
            return View("AdminUniversity");
        }

        //Delete University
        public ActionResult DeleteUniversity(int id)
        {
            um.DeleteUniversityBL(id);
            return RedirectToAction("AdminUniversity");

        }

        public PartialViewResult SponsorNew()
        {
            return PartialView();
        }
        public PartialViewResult SocialMediaNew()
        {
            return PartialView();
        }
        public PartialViewResult NewsNew()
        {
            return PartialView();
        }


        //About Update


        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            About about = am.FindAbout(id);
            return View(about);
        }

        [HttpPost]
        public ActionResult UpdateAbout(About p)
        {
            am.UpdateAbout(p);
            return RedirectToAction("AdminAbout");

        }

    }
}