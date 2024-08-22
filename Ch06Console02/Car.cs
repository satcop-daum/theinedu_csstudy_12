using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06Console02
{
    internal abstract class Car
    {
        private int speed;

        public void SpeedUp(int speed)
        {
            this.speed += speed;
        }

        public int GetSpeed()
        {

            return this.speed;
        }

        abstract public void Info(string name);


    }
}
