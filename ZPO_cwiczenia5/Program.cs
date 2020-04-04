using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO_cwiczenia5
{
    class Program
    {
        static void Main(string[] args)
        {
            // CWICZENIE 1
            Console.WriteLine("Cwiczenie 1");
            Telefon t1 = new Telefon("Samsung", 212);
            Telefon t2 = t1.TelefonKopia();
            bool test1 = Object.ReferenceEquals(t2, t1);
            Console.WriteLine(test1);
            bool test2 = Object.ReferenceEquals(t2.PobierzMarke(), t1.PobierzMarke());
            Console.WriteLine(test2);
            bool test3 = Object.ReferenceEquals(t2.PobierzModel(), t1.PobierzModel());
            Console.WriteLine(test3);
            bool test4 = Object.ReferenceEquals(t2.PobierzModel(), t1.PobierzModel());
            Console.WriteLine(test4);

            Console.ReadKey();
        }
    }
}
