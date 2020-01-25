using CPU_Information.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CPU_Information.Web.Controllers {
    public class HomeController : Controller {
        private ICPUData database;

        public HomeController() {
            database = new InMemoryCPUData();
        }

        public ActionResult Index() {
            IEnumerable<Data.Models.CPU> model = database.GetAll();
            return View(model);
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}