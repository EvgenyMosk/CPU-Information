using CPU_Information.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_Information.Data.Services {
    public interface ICPUData {
        IEnumerable<CPU> GetAll();
    }
}
