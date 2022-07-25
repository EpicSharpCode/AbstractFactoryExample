using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample.PC.PartsFactory.Parts
{
    internal abstract class PCPart : IPCPart
    {
        public string name;
        public PartType partType;

        public PCPart() { }

        public string GetName() => name;
        public void InstallPart() => Console.WriteLine($"{name} is installed");

        public PartType GetPartType() => partType;

        public enum PartType
        {
            Motherboard,
            RAM,
            CPU,
            Cooler,
            GPU
        }
    }
}
