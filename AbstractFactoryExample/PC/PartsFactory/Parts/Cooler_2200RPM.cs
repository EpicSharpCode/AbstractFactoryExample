using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample.PC.PartsFactory.Parts
{
    internal class Cooler_2200RPM : PCPart
    {
        public Cooler_2200RPM()
        {
            name = "Cooler 2200RPM";
            partType = PartType.Cooler;
        }
    }
}
