using AbstractFactoryExample.PC.PartsFactory.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample.PC.PartsFactory
{
    internal abstract class PartsFactoryBase
    {
        public abstract PCPart CreateCooler();

        public abstract PCPart CreateCPU();

        public abstract PCPart CreateGPU();

        public abstract PCPart CreateMotherboard();

        public abstract PCPart CreateRAM();
    }
}
