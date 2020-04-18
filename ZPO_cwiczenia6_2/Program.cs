using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO_cwiczenia6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            IBuilder mediumBurger = new Burger(2);
            IBuilder smallBurger = new Burger(1);

            director.Construct(mediumBurger);
            Product p1 = mediumBurger.GetBurger();
            p1.Show();

            director.Construct(smallBurger);
            Product p2 = smallBurger.GetBurger();
            p2.Show();

            Console.ReadKey();
        }
    }
}
