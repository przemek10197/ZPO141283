using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO_cwiczenia5_3
{
    class Singleton_z_watkami
    {
        private Singleton_z_watkami() { }

        private static Singleton_z_watkami _instance;


        private static readonly object _lock = new object();

        public static Singleton_z_watkami GetInstance(string value)
        {

            if (_instance == null)
            {

                lock (_lock)
                {

                    if (_instance == null)
                    {
                        _instance = new Singleton_z_watkami();
                        _instance.Value = value;
                    }
                }
            }
            return _instance;
        }


        public string Value { get; set; }
    }
}
