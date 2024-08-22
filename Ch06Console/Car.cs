using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06Console
{
    internal class Car
    {
        private string modelName;
        private string color;
        private int speed;
        private static int MAX_SPEED = 200;


        //생성자:클래스 생성될때 실행되는 부분
        public Car()
        {
            this.color = "흰색";
        }
        /*
        public Car(string modelName)
        {
            this.modelName = modelName;
        }
        */

        public Car(string color)
        {
            this.color = color;
        }

        public Car(int speed)
        {
            this.speed = speed;
        }

        public Car(string color, int speed)
        {
            this.color = color;
            this.speed = speed;
        }

        public Car(int speed, string color)
        {
            this.color = color;
            this.speed = speed;
        }

        public Car(int speed, string modelName, string color)
        {
            this.speed = speed;
            this.modelName = modelName;
            this.color = color;
        }

        public Car(string modelName, string color, int speed)
        {
            this.speed = speed;
            this.modelName = modelName;
            this.color = color;
        }
        /*
        public Car(string color, string modelName, int speed)
        {
            this.speed = speed;
            this.modelName = modelName;
            this.color = color;
        }
        */

        //public, internal, protected
        protected void setColor(string color)
        {
            this.color = color;
        }

        public void SpeedUp(int speed)
        {
            this.speed += speed;
            if (this.speed > MAX_SPEED)
            {
                this.speed = MAX_SPEED;
            }
        }

        public void Info()
        {
            Console.WriteLine("================");
            Console.WriteLine("최대속도:{0}", MAX_SPEED);
            Console.WriteLine("색상:{0}", color);
            Console.WriteLine("스피드:{0}", speed);
            Console.WriteLine("================");
        }
        public void Info(string name)
        {
            Console.WriteLine("================");
            Console.WriteLine("<{0}>", name);
            Console.WriteLine("최대속도:{0}", MAX_SPEED);
            Console.WriteLine("색상:{0}", color);
            Console.WriteLine("스피드:{0}", speed);
            Console.WriteLine("================");
        }

    }
}
