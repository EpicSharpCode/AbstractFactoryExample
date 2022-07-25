using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample.PC.PartsFactory.Parts
{
    internal class GPU_L1200 : PCPart
    {
        public GPU_L1200()
        {
            name = "GPU L1200";
            partType = PartType.GPU;
        }
    }
}
