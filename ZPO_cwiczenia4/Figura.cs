using System;
using System.Collections.Generic;
using System.Text;

namespace ZPO_cwiczenia4
{
    abstract class Figura
    {
        protected double a;
        protected double b;
        protected double c;

        public Figura(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public abstract double ObliczPole();
    }
}
