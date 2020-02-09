using System;
using System.Collections.Generic;
using System.Linq;
using CPU_Information.Data.Models;

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
                    //Manufacturer=new Manufacturer{
                    //    Id=1,Name="Intel"
                    //},
                    Manufacturer=Manufacturer.Intel,
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
                    //Manufacturer=new Manufacturer{
                    //    Id=1,Name="Intel"
                    //},
                    Manufacturer=Manufacturer.Intel,
                    HasIntegratedGraphics=true,
                    Class=Class.MobileLowPowered
                },
                // CPU #3 : i7-9750H
                new CPU{
                    Id=3,
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
                    //Manufacturer=new Manufacturer{
                    //    Id=1,Name="Intel"
                    //},
                    Manufacturer=Manufacturer.Intel,
                    HasIntegratedGraphics=true,
                    Class=Class.MobileHighPerformance
                }
            };
        }

        public void Add(CPU cpu) {
            cpus.Add(cpu);
            cpu.Id = cpus.Max(x => x.Id) + 1;
        }

        public void Update(CPU cpu) {
            CPU existing = Get(cpu.Id);

            if (existing != null) {
                existing.Model = cpu.Model;
                existing.FrequencyBase = cpu.FrequencyBase;
                existing.FrequencyTurbo = cpu.FrequencyTurbo;
                existing.CacheL1 = cpu.CacheL1;
                existing.CacheL2 = cpu.CacheL2;
                existing.CacheL3 = cpu.CacheL3;
                existing.CoresPhysical = cpu.CoresPhysical;
                existing.CoresLogical = cpu.CoresLogical;
                existing.Architecture = cpu.Architecture;
                existing.GenerationCodename = cpu.GenerationCodename;
                existing.GenerationNumber = cpu.GenerationNumber;
                existing.Manufacturer = cpu.Manufacturer;
                existing.HasIntegratedGraphics = cpu.HasIntegratedGraphics;
                existing.Class = cpu.Class;
            }
        }

        public CPU Get(Int32 id) {
            return cpus.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<CPU> GetAll() {
            return cpus.OrderBy(x => x.GenerationNumber);
        }

    }
}
