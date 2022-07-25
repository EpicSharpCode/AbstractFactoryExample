using AbstractFactoryExample.PC;
using AbstractFactoryExample.PC.PartsFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gaming Tower");
            PC_Tower gamingTower = new PC_Tower(new PartsFactoryGaming());
            Console.WriteLine();
            Console.WriteLine("Office Tower");
            PC_Tower officeTower = new PC_Tower(new PartsFactoryOffice());
            Console.ReadKey();
        }
    }
}
