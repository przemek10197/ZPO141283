using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO_cwiczenia7_1.Interface;

namespace ZPO_cwiczenia7_1.Factory
{
    public abstract class ClothesFactory
    {
        public abstract IShirt CreateShirt();
        public abstract ITrouser CreateTrouser();
    }
}
