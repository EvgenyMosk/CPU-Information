using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_Information.Data.Models {
    public class CPU {
        public Int32 Id { get; set; }
        public String Model { get; set; }
        public Double? FrequencyBase { get; set; }
        public Double? FrequencyTurbo { get; set; }
        public Int32? CacheL1 { get; set; }
        public Int32? CacheL2 { get; set; }
        public Int32? CacheL3 { get; set; }
        public Int32? CoresPhysical { get; set; }
        public Int32? CoresLogical { get; set; }
        public String Architecture { get; set; }
        public String GenerationCodename { get; set; }
        public Int32? GenerationNumber { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public Boolean HasIntegratedGraphics { get; set; } = false;
        public Class Class { get; set; }
    }
}