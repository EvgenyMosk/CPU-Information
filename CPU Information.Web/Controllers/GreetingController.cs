using CPU_Information.Web.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CPU_Information.Web.Controllers {
    public class GreetingController : Controller {
        // GET: Greeting
        public ActionResult Index() {
            GreetingViewModel model = new GreetingViewModel {
                Message = ConfigurationManager.AppSettings["greetingMessage"]
            };
            return View(model);
        }
    }
}