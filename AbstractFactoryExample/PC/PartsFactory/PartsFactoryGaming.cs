using AbstractFactoryExample.PC.PartsFactory.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample.PC.PartsFactory
{
    internal class PartsFactoryGaming : PartsFactoryBase
    {
        public override PCPart CreateCooler() { return new Cooler_5000RPM(); }

        public override PCPart CreateCPU() { return new CPU_MainCore11800x(); }

        public override PCPart CreateGPU() { return new GPU_Z3010(); }

        public override PCPart CreateMotherboard() { return new Motherboard_Z300(); }

        public override PCPart CreateRAM() { return new RAM_3200MHZ(); }
    }
}
