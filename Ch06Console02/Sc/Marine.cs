using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06Console02.Sc
{
    internal class Marine : Unit
    {
        public Marine(int energy) : base(energy)
        {
            
        }

        public override void Move()
        {
            Console.WriteLine("마린이 이동합니다.");

        }
    }
}
