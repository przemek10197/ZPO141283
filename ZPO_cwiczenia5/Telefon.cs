using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO_cwiczenia5
{
    class Telefon
    {
        private string marka;
        private int model;

        public Telefon(string marka, int model)
        {
            this.marka = marka;
            this.model = model;
        }

        public Telefon()
        {

        }

        public string PobierzMarke()
        {
            return marka;
        }

        public int PobierzModel()
        {
            return model;
        }

        public Telefon TelefonKopia()
        {
            Telefon temp = new Telefon();
            temp.model = this.model;
            temp.marka = String.Copy(this.marka);
            return temp;
        }
    }
}
