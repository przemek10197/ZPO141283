using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO_cwiczenia6_2
{
    class Burger : IBuilder
    {
        private int mSize;
        private bool mCheese;
        private bool mPepperoni;
        private bool mLettuce;
        private bool mTomato;

        private Product product;

        public Burger(int size)
        {
            product = new Product();
            this.mSize = size;
        }

        public void AddCheese()
        {
            product.Add("Cheese has been added");
        }

        public void AddLettuce()
        {
            product.Add("Lettuce has been added");
        }

        public void AddPepperoni()
        {
            product.Add("Pepperoni has been added");
        }

        public void AddTomato()
        {
            product.Add("Tomato has been added");
        }

        public void BuildBody()
        {
            product.Add("This is a body of a burger");
        }

        public void StartUpOperations()
        {
            product.Add(string.Format("Burger size: {0}", this.mSize));
        }
        public Product GetBurger()
        {
            return product;
        }
    }
}
