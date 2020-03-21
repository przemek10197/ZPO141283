using System;
using System.Collections.Generic;
using System.Text;

namespace ZPO_cwiczenia3
{
    class Student : Osoba
    {
        private int rok;
        private int numerGrupy;
        private int numerAlbumu;

        public Student() {}

        public Student(int rok, int numerGrupy, int numerAlbumu, string imie, string nazwisko, int rokUrodzenia, string miejsceZamieszkania) 
            : base(imie, nazwisko, rokUrodzenia, miejsceZamieszkania)
        {
            this.rok = rok;
            this.numerGrupy = numerGrupy;
            this.numerAlbumu = numerAlbumu;
        }
        public void WypiszInfo()
        {
            Console.WriteLine(imie + " " + nazwisko + ". Urodzony: " + rokUrodzenia + ". Rok: " + rok + ", grupa " + numerGrupy + ", numer albumu " + numerAlbumu);
        }
    }
}
