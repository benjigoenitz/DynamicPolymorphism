using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPolymorphism
{
    class DynamicDemo : BaseClass
    {
        public override void PrintText(string str)
        {
            base.PrintText(str);

            Console.WriteLine("Print from DynamicDemo derived class: " + str);
        }
    }
}
