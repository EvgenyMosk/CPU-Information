using System;
using System.ComponentModel.DataAnnotations;

namespace CPU_Information.Data.Models {
    public class CPU {
        public Int32 Id { get; set; }
        [Required]
        public String Model { get; set; }
        [Display(Name = "Base Frequency")]
        public Double? FrequencyBase { get; set; }
        [Display(Name = "Turbo Frequency")]
        public Double? FrequencyTurbo { get; set; }
        [Display(Name = "L1 Cache")]
        public Int32? CacheL1 { get; set; }
        [Display(Name = "L2 Cache")]
        public Int32? CacheL2 { get; set; }
        [Display(Name = "L3 Cache")]
        public Int32? CacheL3 { get; set; }
        [Display(Name = "# of Physical Cores")]
        public Int32? CoresPhysical { get; set; }
        [Display(Name = "# of Logical Cores")]
        public Int32? CoresLogical { get; set; }
        public String Architecture { get; set; }
        [Display(Name = "Generation")]
        public String GenerationCodename { get; set; }
        [Display(Name = "Gen. number")]
        public Int32? GenerationNumber { get; set; }
        public Manufacturer Manufacturer { get; set; }
        [Display(Name = "Integrated graphics")]
        public Boolean HasIntegratedGraphics { get; set; } = false;
        [Display(Name = "CPU Class")]
        public Class Class { get; set; }
    }
}