using Ch06Console02.Sc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06Console02
{
    internal class Program
    {
        static void Main_02(string[] args)
        {
            //Car myCar = new Car();

            Sedan mySedan = new Sedan();
            mySedan.SpeedUp(100);
            mySedan.Info("mySedan");


            Trunck trunck = new Trunck();
            trunck.Info("트럭");
        }

        static void Main(string[] args)
        {
            //유니트 내유니트 = new 유니트();

            Marine marine1 = new Marine(100);
            Tank tank1 = new Tank(300);
            AirCraft airCarft1 = new AirCraft(200);

            marine1.Move();
            tank1.Move();
            airCarft1.Move();

            tank1.Fire();
            airCarft1.Fire();

            ICannon[] cannonUnits = { tank1, airCarft1 };

            foreach(var cannon in cannonUnits)
            {
                cannon.Fire();
            }

        }


    }
}
