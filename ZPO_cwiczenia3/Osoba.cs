using System;
using System.Collections.Generic;
using System.Text;

namespace ZPO_cwiczenia3
{
    class Osoba
    {
        protected string imie;
        protected string nazwisko;
        protected int rokUrodzenia;
        protected string miejsceZamieszkania;

        public Osoba() {}

        public Osoba(string imie, string nazwisko, int rokUrodzenia, string miejsceZamieszkania)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rokUrodzenia = rokUrodzenia;
            this.miejsceZamieszkania = miejsceZamieszkania;
        }

        public void WyswietlInfo()
        {
            Console.WriteLine(imie + " " + nazwisko + ". Urodzony/a w " + rokUrodzenia);
        }

        public void ObliczWiek()
        {
            var wiek = DateTime.Now.Year - rokUrodzenia;
            Console.WriteLine("Wiek: " + wiek);
        }
    }
}
