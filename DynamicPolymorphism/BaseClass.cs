using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPolymorphism
{
    class BaseClass
    {
        public virtual void PrintText(string str)
        {
            Console.WriteLine("Print from BaseClass: " + str);
        }
    }
}
