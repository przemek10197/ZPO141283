using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO_cwiczenia6_2
{
    class Product
    {
        private LinkedList<string> ingredients;
        public Product()
        {
            ingredients = new LinkedList<string>();
        }
        public void Add(string ingredient)
        {
            ingredients.AddLast(ingredient);
        }
        public void Show()
        {
            Console.WriteLine("Burger completed as below: ");
            foreach(string ingredient in ingredients)
            {
                Console.WriteLine(ingredient);
            }
        }
    }
}
