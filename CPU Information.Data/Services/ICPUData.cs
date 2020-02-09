using System;
using System.Collections.Generic;
using CPU_Information.Data.Models;

namespace CPU_Information.Data.Services {
    public interface ICPUData {
        IEnumerable<CPU> GetAll();
        CPU Get(Int32 id);
        void Add(CPU cpu);
        void Update(CPU cpu);
    }
}
