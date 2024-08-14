using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch04Console
{
    internal class Ch04Class2
    {
        public void Display(int value)
        {
            value++;
            Console.WriteLine("value: " + value);
            value++;
        }

        public void DisplayRef(ref int value)
        {
            value++;
            Console.WriteLine("value: " + value);
            value++;
        }


    }
}
