using AbstractFactoryExample.PC.PartsFactory;
using AbstractFactoryExample.PC.PartsFactory.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample.PC
{
    internal class PC_Tower
    {
        PartsFactoryBase partsFactoryBase;

        PCPart motherboard;
        PCPart ram;
        PCPart cpu;
        PCPart gpu;
        PCPart cooler;
        public PC_Tower(PartsFactoryBase _partsFactoryBase)
        {
            partsFactoryBase = _partsFactoryBase;

            motherboard = partsFactoryBase.CreateMotherboard();
            cpu = partsFactoryBase.CreateCPU();
            ram = partsFactoryBase.CreateRAM();
            gpu = partsFactoryBase.CreateGPU();
            cooler = partsFactoryBase.CreateCooler();

            motherboard.InstallPart();
            cpu.InstallPart();
            ram.InstallPart();
            gpu.InstallPart();
            cooler.InstallPart();
        }
    }
}
