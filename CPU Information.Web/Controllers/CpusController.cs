using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CPU_Information.Data.Models;
using CPU_Information.Data.Services;

namespace CPU_Information.Web.Controllers {
	public class CpusController : Controller {
		private readonly ICPUData db;
		public CpusController(ICPUData db) {
			this.db = db;
		}

		[HttpGet]
		public ActionResult Index() {
			IEnumerable<CPU> model = db.GetAll();
			return View(model);
		}

		[HttpGet]
		public ActionResult Details(Int32 id) {
			CPU model = db.Get(id);

			if (model == null) {
				return View("NotFound");
			}

			return View(model);
		}

		[HttpGet]
		public ActionResult Create() {
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(CPU cpu) {
			if (ModelState.IsValid) {
				db.Add(cpu);
				return RedirectToAction("Details", new { id = cpu.Id });
			}
			return View();
		}

		[HttpGet]
		public ActionResult Edit(Int32 id) {
			CPU model = db.Get(id);
			if (model == null) {
				return HttpNotFound();
			}
			return View(model);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(CPU cpu) {
			if (ModelState.IsValid) {
				db.Update(cpu);
				return RedirectToAction("Details", new { id = cpu.Id });
			}
			return View(cpu);
		}
	}
}