using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO_cwiczenia7_1.Factory;

namespace ZPO_cwiczenia7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ClothesFactory factory = new FactoryElegant();
            var _shirt = factory.CreateShirt();
            var _trouser = factory.CreateTrouser();

            Console.WriteLine("You have bought " + _shirt.getShirt() + " and " + _trouser.getTrouser() + ".");

            ClothesFactory factory2 = new FactoryCasual();
            var _shirt2 = factory2.CreateShirt();
            var _trouser2 = factory2.CreateTrouser();

            Console.WriteLine("You have bought " + _shirt2.getShirt() + " and " + _trouser2.getTrouser() + ".");

            Console.ReadKey();
        }
    }
}
