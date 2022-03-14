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
        NewsManager nm = new NewsManager();
        SponsorManager sm = new SponsorManager();
        SocialMediaManager som = new SocialMediaManager();
        FacultyManager fm = new FacultyManager();
        CommentManager com = new CommentManager();
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
            var newsList = nm.GetAll();
            return PartialView(newsList);
        }

        public ActionResult DeleteNews(int id)
        {
            nm.DeleteNewsBL(id);
            return RedirectToAction("AdminNews");

        }
        public PartialViewResult AdminSponsor()
        {
            var sponsorList = sm.GetAll();
            return PartialView(sponsorList);
        }
        public ActionResult DeleteSponsor(int id)
        {
            sm.DeleteSponsorBL(id);
            return RedirectToAction("AdminSponsor");

        }

        public ActionResult DeleteFaculty(int id)
        {
            fm.DeleteFacultyBL(id);
            return RedirectToAction("AdminFaculty");

        }

        public PartialViewResult AdminComment()
        {
            var commentList = com.GetAll();
            return PartialView(commentList);
        }

        public ActionResult DeleteComment(int id)
        {
            com.DeleteCommentBL(id);
            return RedirectToAction("AdminComment");

        }

        public PartialViewResult AdminSocialMedia()
        {
            var socialList = som.GetAll();
            return PartialView(socialList);
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
            return RedirectToAction("AdminDorm");

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
            return RedirectToAction("DistrictList");
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
            return View();
        }

        [HttpPost]
        public ActionResult UniversityNew(University p)
        {
            um.UniversityAddBl(p);
            return RedirectToAction("AdminUniversity");
        }

        //Delete University
        public ActionResult DeleteUniversity(int id)
        {
            um.DeleteUniversityBL(id);
            return RedirectToAction("AdminUniversity");

        }

        [HttpGet]
        public ActionResult SponsorNew()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SponsorNew(Sponsor p)
        {
            sm.SponsorAddBl(p);
            return RedirectToAction("AdminSponsor");
        }

        [HttpGet]
        public ActionResult SocialMediaNew()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SocialMediaNew(SocialMedia p)
        {
            som.SocialMediaAddBl(p);
            return RedirectToAction("AdminSocialMedia");
        }

        public ActionResult DeleteSocialMedia(int id)
        {
            som.DeleteSocialMediaBL(id);
            return RedirectToAction("AdminSocialMedia");

        }

        [HttpGet]
        public ActionResult NewsNew()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewsNew(News p)
        {
            nm.NewsAddBl(p);
            return RedirectToAction("AdminNews"); 
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
            am.UpdateAboutBM(p);
            return RedirectToAction("AdminAbout");

        }

        public PartialViewResult DistrictList()
        {
            var distList = dism.GetAll();


            
            return PartialView(distList);
        }

        public ActionResult AdminFaculty()
        {
            var facultyList = fm.GetAll();
            return View(facultyList);
        }

        [HttpGet]
        public ActionResult FacultyNew()
        {
            Context c = new Context();

            List<SelectListItem> values = (from x in c.Universities.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.UniversityName,
                                               Value = x.UniversityID.ToString()
                                           }).ToList();
            ViewBag.values = values;
            return View();
        }

        [HttpPost]
        public ActionResult FacultyNew(Faculty p)
        {
            fm.FacultyAddBl(p);
            return RedirectToAction("AdminFaculty");
        }


        public ActionResult DeleteDistrict(int id)
        {
            dism.DeleteDistrictBL(id);
            return RedirectToAction("DistrictList");

        }
    }
}