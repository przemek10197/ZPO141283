using System;
using System.Collections.Generic;
using System.Text;

namespace ZPO_cwiczenia3
{
    class Pacjent : Osoba_7
    {
        private int wiek;

        public Pacjent(string imie, string nazwisko, int wiek): base(imie, nazwisko)
        {
            this.wiek = wiek;
        }
    }
}
