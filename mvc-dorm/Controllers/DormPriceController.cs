using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_dorm.Controllers
{
    public class DormPriceController : Controller
    {
        // GET: DormPrice
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult FormPrice()
        {
            return PartialView();
        }

        public PartialViewResult PriceContent()
        {
            return PartialView();
        }
    }
}