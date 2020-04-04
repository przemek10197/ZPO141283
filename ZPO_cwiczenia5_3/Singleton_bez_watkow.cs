using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO_cwiczenia5_3
{
    class Singleton_bez_watkow
    {
        private Singleton_bez_watkow() { }

        private static Singleton_bez_watkow _instance;

        public static Singleton_bez_watkow GetInstance()
        {
            return (_instance == null) ? new Singleton_bez_watkow() : null;
        }

        public static void logic() { }
    }
}
