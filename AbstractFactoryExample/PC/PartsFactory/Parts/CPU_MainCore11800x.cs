using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample.PC.PartsFactory.Parts
{
    internal class CPU_MainCore11800x : PCPart
    {
        public CPU_MainCore11800x()
        {
            name = "CPU MainCore 11800x";
            partType = PartType.CPU;
        }
    }
}
