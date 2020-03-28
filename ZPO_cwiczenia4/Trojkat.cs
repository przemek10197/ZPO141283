using System;
using System.Collections.Generic;
using System.Text;

namespace ZPO_cwiczenia4
{
    class Trojkat : Figura
    {
        public override double ObliczPole()
        {
            double p = (a + b + c) / 2; // p - polowa obwodu trojkata
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public Trojkat(int a, int b, int c)
            : base(a, b, c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
    }
}
