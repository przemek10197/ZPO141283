using System;
using System.Collections.Generic;
using System.Text;

namespace ZPO_cwiczenia4
{
    class Student : Osoba
    {
        private int rokStudiow;
        private int numerGrupy;
        private int numerAlbumu;

        public Student() { }

        public Student(string imie, string nazwisko, int rokStudiow, int numerGrupy, int numerAlbumu) : base(imie, nazwisko)
        {
            this.rokStudiow = rokStudiow;
            this.numerGrupy = numerGrupy;
            this.numerAlbumu = numerAlbumu;
        }

        public override string ToString()
        {
            return base.ToString() + ". Rok studiów: " + rokStudiow + ", grupa: " + numerGrupy + ", numer albumu: " + numerAlbumu;
        }
    }
}
