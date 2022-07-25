using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample.PC.PartsFactory.Parts
{
    internal class GPU_Z3010 : PCPart
    {
        public GPU_Z3010()
        {
            name = "GPU Z3010";
            partType = PartType.GPU;
        }
    }
}
