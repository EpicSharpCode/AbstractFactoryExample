using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample.PC.PartsFactory.Parts
{
    internal class Cooler_5000RPM : PCPart
    {
        public Cooler_5000RPM()
        {
            name = "Cooler 5000RPM";
            partType = PartType.Cooler;
        }
    }
}
