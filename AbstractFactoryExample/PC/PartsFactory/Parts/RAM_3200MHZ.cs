using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample.PC.PartsFactory.Parts
{
    internal class RAM_3200MHZ : PCPart
    {
        public RAM_3200MHZ()
        {
            name = "RAM 3200 MHZ";
            partType = PartType.RAM;
        }
    }
}
