using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample.PC.PartsFactory.Parts
{
    internal interface IPCPart
    {
        string GetName();
        PCPart.PartType GetPartType();
        void InstallPart();
    }
}
