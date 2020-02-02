using CPU_Information.Data.Models;
using CPU_Information.Data.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CPU_Information.Web.Api {
    public class CpusController : ApiController {
        private readonly ICPUData db;

        public CpusController(ICPUData db) {
            this.db = db;
        }

        public IEnumerable Get() {
            IEnumerable<CPU> model = db.GetAll();
            return model;
        }
    }
}