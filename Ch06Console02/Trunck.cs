using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06Console02
{
    internal class Trunck : Car
    {
        public override void Info(string name)
        {
            Console.WriteLine();
            Console.WriteLine("===========");
            Console.WriteLine("차량구분:{0}", name);
            Console.WriteLine("속도:{0}", base.GetSpeed());
            Console.WriteLine("===========");
        }

    }
}
