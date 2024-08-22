using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06Console
{
    internal class Sedan : Car
    {

        public void setColor(string color)
        {
            //this:자기 자신
            //base:현재 클래스의 부모
            base.setColor(color + "[색]");

        }

    }
}
