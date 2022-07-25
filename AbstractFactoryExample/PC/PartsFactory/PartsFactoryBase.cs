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
        public abstract IPCPart CreateCooler();

        public abstract IPCPart CreateCPU();

        public abstract IPCPart CreateGPU();

        public abstract IPCPart CreateMotherboard();

        public abstract IPCPart CreateRAM();
    }
}
