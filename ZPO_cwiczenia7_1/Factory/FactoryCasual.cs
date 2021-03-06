﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO_cwiczenia7_1.Class;
using ZPO_cwiczenia7_1.Interface;

namespace ZPO_cwiczenia7_1.Factory
{
    public class FactoryCasual : ClothesFactory
    {
        public override IShirt CreateShirt()
        {
            return new PoloShirt();
        }

        public override ITrouser CreateTrouser()
        {
            return new Jeans();
        }
    }
}
