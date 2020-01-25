using CPU_Information.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_Information.Data.Services {
    public class InMemoryCPUData : ICPUData {
        private List<CPU> cpus;

        public InMemoryCPUData() {
            cpus = new List<CPU>() {
                // CPU #1 : i5-8250U
                new CPU{
                    Id=1,
                    Model="Core i5-8250U",
                    FrequencyBase=1.6,
                    FrequencyTurbo=3.4,
                    CacheL1=256,
                    CacheL2=1024,
                    CacheL3=6144,
                    CoresPhysical=4,
                    CoresLogical=8,
                    Architecture="Arch",
                    GenerationCodename="Kaby Lake-R",
                    GenerationNumber=8000,
                    Manufacturer=new Manufacturer{
                        Id=1,Name="Intel"
                    },
                    HasIntegratedGraphics=true,
                    Class=Class.MobileLowPowered
                },
                //CPU #2 : i5-8265U
                new CPU{
                    Id=2,
                    Model="Core i5-8265U",
                    FrequencyBase=1.8,
                    FrequencyTurbo=4.0,
                    CacheL1=512,
                    CacheL2=1024,
                    CacheL3=6144,
                    CoresPhysical=4,
                    CoresLogical=8,
                    Architecture="Arch",
                    GenerationCodename="Whiskey Lake",
                    GenerationNumber=8000,
                    Manufacturer=new Manufacturer{
                        Id=1,Name="Intel"
                    },
                    HasIntegratedGraphics=true,
                    Class=Class.MobileLowPowered
                },
                // CPU #3 : i7-9750H
                new CPU{
                    Id=1,
                    Model="Core i7-9750H",
                    FrequencyBase=2.4,
                    FrequencyTurbo=4.8,
                    CacheL1=512,
                    CacheL2=2048,
                    CacheL3=8192,
                    CoresPhysical=6,
                    CoresLogical=12,
                    Architecture="Arch",
                    GenerationCodename="Coffee Lake-R",
                    GenerationNumber=9000,
                    Manufacturer=new Manufacturer{
                        Id=1,Name="Intel"
                    },
                    HasIntegratedGraphics=true,
                    Class=Class.MobileHighPerformance
                }
            };
        }

        public IEnumerable<CPU> GetAll() {
            return cpus.OrderBy(x => x.GenerationNumber);
        }
    }
}
