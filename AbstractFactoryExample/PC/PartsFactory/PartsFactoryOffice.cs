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
        public override IPCPart CreateCooler() { return new Cooler_2200RPM(); }

        public override IPCPart CreateCPU() { return new CPU_MainCore7900i(); }

        public override IPCPart CreateGPU() { return new GPU_L1200(); }

        public override IPCPart CreateMotherboard() { return new Motherboard_L100(); }

        public override IPCPart CreateRAM() { return new RAM_2100MHZ(); }
    }
}
