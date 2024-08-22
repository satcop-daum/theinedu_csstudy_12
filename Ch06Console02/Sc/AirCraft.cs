using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06Console02.Sc
{
    internal class AirCraft : Unit, ICannon
    {
        public AirCraft(int energy) : base(energy)
        {
        }

        public override void Move()
        {
            Console.WriteLine("비행기유닛이 이동합니다.");
        }

        public void Fire()
        {
            Console.WriteLine("비행기유닛에서 대포를 쏘다!!");
        }

    }
}
