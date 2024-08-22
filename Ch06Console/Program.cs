using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06Console
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car myCar1 = new Car("빨강");
            //myCar1.setColor("빨강");
            myCar1.Info();
            
            myCar1.SpeedUp(20);
            myCar1.Info("myCar1");

            myCar1.SpeedUp(100);
            myCar1.Info("myCar1");

            myCar1.SpeedUp(100);
            myCar1.Info("myCar1");
            //myCar1.setColor("분홍");


            //myCar1.setColor("파랑");
            myCar1.Info();

            Car yourCar2 = new Car();
            yourCar2.Info();


            Sedan mySedan = new Sedan();
            mySedan.SpeedUp(120);
            mySedan.setColor("노랑");
            mySedan.Info("mySedan");



        }
    }
}
