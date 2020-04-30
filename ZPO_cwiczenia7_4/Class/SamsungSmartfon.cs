using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO_cwiczenia7_4.Class
{
    class SamsungSmartfon : Smartfon
    {
        public SamsungSmartfon()
        {
            systemOperacyjny = "Android";
            rozdzielczoscAparatu = 3;
            przekatnaEkranu = 5.1;
            nfc = true;
            pojemnoscAkumulatora = 2;
        }

        public override string GetMake() => "Samsung Phone";
    }
}
