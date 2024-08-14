using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch04Console
{

    internal class Ch04Class
    {
        //메소드
        //속성

        static int b = 417;

        int a = 100;

        public void Show(bool flag)
        {
            //지역변수
            int a = 10;
            Console.WriteLine("a: " + a++);
            Console.WriteLine("a: " + a++);
            Console.WriteLine("b: " + b++);
        }

        public void Show2()
        {
            {
                int a = 40;
                Console.WriteLine("a: " + a++);
                Console.WriteLine("a: " + a++);
                Console.WriteLine("b: " + b++);
            }

            Console.WriteLine("a: " + a++);
            Console.WriteLine("a: " + a++);
            Console.WriteLine("b: " + b++);
        }

    }


}
