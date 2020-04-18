using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO_cwiczenia6_2
{
    interface IBuilder
    {
        void StartUpOperations();
        void BuildBody();
        void AddCheese();
        void AddPepperoni();
        void AddLettuce();
        void AddTomato();
        Product GetBurger();
    }
}
