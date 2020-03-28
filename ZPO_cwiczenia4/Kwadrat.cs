using System;
using System.Collections.Generic;
using System.Text;

namespace ZPO_cwiczenia4
{
    class Kwadrat : Figura
    {
        public override double ObliczPole()
        {
            return a * a;
        }

        public Kwadrat(int a)
            : base(a, a, a)
        {
            this.a = a;
        }
    }
}
