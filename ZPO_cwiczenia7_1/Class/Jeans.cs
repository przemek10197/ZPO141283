﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO_cwiczenia7_1.Interface;

namespace ZPO_cwiczenia7_1.Class
{
    class Jeans : ITrouser
    {
        public string getTrouser()
        {
            return "Jeans";
        }
    }
}
