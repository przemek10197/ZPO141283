using System;
using System.Collections.Generic;
using System.Text;

namespace ZPO_cwiczenia4
{
    class Osoba
    {
        protected string imie;
        protected string nazwisko;

        public Osoba() { }

        public Osoba(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        public override string ToString()
        {
            return imie + " " + nazwisko;
        }
    }
}
