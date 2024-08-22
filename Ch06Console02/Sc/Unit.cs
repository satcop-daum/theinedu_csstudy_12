using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06Console02.Sc
{
    internal abstract class Unit
    {
        int energy;

        public Unit(int energy)
        {
            this.energy = energy;
        }

        public abstract void Move();

    }
}
