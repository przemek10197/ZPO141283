using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO_cwiczenia7_4.Class;
using ZPO_cwiczenia7_4.Interface;

namespace ZPO_cwiczenia7_4.Factory
{
    public class SamsungSmarfonFactory : ISmartfonFactory
    {
        public Smartfon CreateSmartfon()
        {
            return new SamsungSmartfon();
        }
    }
}
