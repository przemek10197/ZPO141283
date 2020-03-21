using System;
using System.Collections.Generic;
using System.Text;

namespace ZPO_cwiczenia3
{
    class Kwadrat : IKwadrat
    {
        public Punkt punkt_1;
        public Punkt punkt_2;
        public Punkt punkt_3;
        public Punkt punkt_4;
        public int a;
        public string name;

        public Kwadrat(Punkt punkt_1, Punkt punkt_2, Punkt punkt_3, Punkt punkt_4, string name)
        {
            this.punkt_1 = punkt_1;
            this.punkt_2 = punkt_2;
            this.punkt_3 = punkt_3;
            this.punkt_4 = punkt_4;
            this.name = name;
        }

        public double LiczObwod()
        {
            double a = punkt_1.Y - punkt_2.Y;
            return 4 * a;
        }

        public void PobierzDaneZKlawiatury()
        {
            Console.WriteLine("Podaj a: ");
            a = Convert.ToInt32(Console.ReadLine());
        }
        public void Wyswietl()
        {
            Console.WriteLine("Kwadrat " + name + ": Wspolrzedne: (" + punkt_1.X + ", " + punkt_1.Y + "), (" +
                punkt_2.X + ", " + punkt_2.Y + "), (" + punkt_3.X + ", " + punkt_3.Y + "), (" + punkt_4.X + ", " + punkt_4.Y + ")");
        }
    }
}
