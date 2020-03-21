using System;
using System.Collections.Generic;
using System.Text;

namespace ZPO_cwiczenia3
{
    class Matematyka
    {
        public static double pi = 3.14;

        public Matematyka()
        {

        }

        public static double ObliczPole(double promien)
        {
            return promien * promien * pi;
        }

        public static double ObliczObwod(double promien)
        {
            return 2 * promien * pi;
        }
    }
}
