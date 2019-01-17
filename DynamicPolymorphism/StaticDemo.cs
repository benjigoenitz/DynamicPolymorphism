using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPolymorphism
{
    class StaticDemo
    {
        public void PrintText(string str)
        {
            Console.WriteLine(str);
        }

        public void PrintText(string str1, string str2)
        {
            Console.WriteLine(str1 + " " + str2);
        }
    }
}
