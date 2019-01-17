using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            /*StaticDemo sd = new StaticDemo();

            sd.PrintText("Benji");
            sd.PrintText("Hola", "Benji");*/

            BaseClass b = new DynamicDemo();

            b.PrintText("Benji");
            
            Console.ReadLine();
        }
    }
}
