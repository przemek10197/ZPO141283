using System;
using System.Collections.Generic;
using System.Text;

namespace ZPO_cwiczenia3
{
    class Kolo : IKolo
    {
        public Punkt srodek;
        public int promien;
        public string name;
        public const double pi = 3.14;

        public Kolo(Punkt srodek, int promien, string name)
        {
            this.srodek = srodek;
            this.promien = promien;
            this.name = name;
        }

        public double LiczObwod()
        {
            return 2 * pi * promien;
        }

        public void PobierzDaneZKlawiatury()
        {
            Console.WriteLine("Podaj X srodka: ");
            srodek.X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj Y: ");
            srodek.Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj promien: ");
            promien = Convert.ToInt32(Console.ReadLine());
        }

        public void Wyswietl()
        {
            Console.WriteLine("Kolo " + name + ": Srodek: (" + srodek.X + ", " + srodek.Y + "), promien: " + promien);
        }
    }
}
