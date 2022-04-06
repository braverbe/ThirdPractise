using ThirdPractise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace ThirdPractise.Controllers
{
    public class HomeController : Controller
    {
        SellsContext db = new SellsContext();
        public ActionResult Index()
        {
            var zakazs = db.Zakazs.Include(p => p.Zakazchik);
            return View(zakazs.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}