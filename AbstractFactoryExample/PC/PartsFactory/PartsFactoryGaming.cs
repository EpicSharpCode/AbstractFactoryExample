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
        public override IPCPart CreateCooler() { return new Cooler_5000RPM(); }

        public override IPCPart CreateCPU() { return new CPU_MainCore11800x(); }

        public override IPCPart CreateGPU() { return new GPU_Z3010(); }

        public override IPCPart CreateMotherboard() { return new Motherboard_Z300(); }

        public override IPCPart CreateRAM() { return new RAM_3200MHZ(); }
    }
}
