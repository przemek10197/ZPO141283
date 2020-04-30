using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO_cwiczenia7_4.Class
{
    public abstract class Smartfon
    {
        protected string systemOperacyjny;
        protected double rozdzielczoscAparatu;
        protected double przekatnaEkranu;
        protected bool nfc;
        protected int pojemnoscAkumulatora;

        public Smartfon()
        {
        }

        public abstract string GetMake();
    }
}
