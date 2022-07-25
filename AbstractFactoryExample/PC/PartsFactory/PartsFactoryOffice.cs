using AbstractFactoryExample.PC.PartsFactory.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample.PC.PartsFactory
{
    internal class PartsFactoryOffice : PartsFactoryBase
    {
        public override PCPart CreateCooler() { return new Cooler_2200RPM(); }

        public override PCPart CreateCPU() { return new CPU_MainCore7900i(); }

        public override PCPart CreateGPU() { return new GPU_L1200(); }

        public override PCPart CreateMotherboard() { return new Motherboard_L100(); }

        public override PCPart CreateRAM() { return new RAM_2100MHZ(); }
    }
}
