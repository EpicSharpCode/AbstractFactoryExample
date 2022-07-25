using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample.PC.PartsFactory.Parts
{
    internal class Motherboard_L100 : PCPart
    {
        public Motherboard_L100()
        {
            name = "Motherboard L100";
            partType = PartType.Motherboard;
        }
    }
}
