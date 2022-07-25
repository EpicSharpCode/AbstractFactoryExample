using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample.PC.PartsFactory.Parts
{
    internal class RAM_2100MHZ : PCPart
    {
        public RAM_2100MHZ()
        {
            name = "RAM 2100 MHZ";
            partType = PartType.RAM;
        }
    }
}
