using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample.PC.PartsFactory.Parts
{
    internal class CPU_MainCore7900i : PCPart
    {
        public CPU_MainCore7900i()
        {
            name = "CPU MainCore 7900i";
            partType = PartType.CPU;
        }
    }
}
