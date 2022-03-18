using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_dorm.Controllers
{
    [AllowAnonymous]
    public class CitiesController : Controller
    {
        CitiesManager cm = new CitiesManager();
        // GET: Cities
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HeaderCities()
        {
            var cityList = cm.GetAll();
            return PartialView(cityList);
        }

        public PartialViewResult ContentCities(string p)
        {
            if (!string.IsNullOrEmpty(p))
            {
                var cityLista = cm.CityByName(p);
                return PartialView(cityLista);
            }
            var cityList = cm.GetAll();
            return PartialView(cityList);
        }
        public ActionResult CitiesDetails(int id)
        {
            var cityList = cm.CityByID(id);
            return PartialView(cityList);
        }
    }
}