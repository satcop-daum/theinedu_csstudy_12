using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06Console02.Sc
{
    internal class Tank : Unit, ICannon
    {
        public Tank(int energy) : base(energy)
        {
        }

        public void Fire()
        {
            Console.WriteLine("대포를 쏘다!!!");
        }

        public override void Move()
        {
            Console.WriteLine("탱크가 이동합니다.");
        }

    



    }
}
