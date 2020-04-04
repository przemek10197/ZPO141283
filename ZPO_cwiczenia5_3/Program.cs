using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ZPO_cwiczenia5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cwiczenia 3");
            Console.WriteLine("Singleton bez watkow");
            Singleton_bez_watkow s1 = Singleton_bez_watkow.GetInstance();
            Singleton_bez_watkow s2 = Singleton_bez_watkow.GetInstance();

            if (Object.ReferenceEquals(s2, s1))
            {
                Console.WriteLine("Singleton powiódł się.");
            }
            else
            {
                Console.WriteLine("Singleton nie powiódł się.");
            }

            Console.WriteLine("Singleton z watkami");
            Console.WriteLine(
                    "Wynik:"
                );

            Thread process1 = new Thread(() =>
            {
                TestSingleton("Singleton 1");
            });
            Thread process2 = new Thread(() =>
            {
                TestSingleton("Singleton 2");
            });

            process1.Start();
            process2.Start();

            process1.Join();
            process2.Join();

            Console.ReadKey();
        }
        public static void TestSingleton(string value)
        {
            Singleton_z_watkami singleton1 = Singleton_z_watkami.GetInstance(value);
            Console.WriteLine(singleton1.Value);
        }
    }
}
