using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample.PC.PartsFactory.Parts
{
    internal class Motherboard_Z300 : PCPart
    {
        public Motherboard_Z300()
        {
            name = "Motherboard Z300";
            partType = PartType.Motherboard;
        }
    }
}
