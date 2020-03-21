using System;
using System.Collections.Generic;
using System.Text;

namespace ZPO_cwiczenia3
{
    class Punkt : IPunkt, IComparable<Punkt>
    {
        public int X;
        public int Y;
        public string name;

        public Punkt(int X, int Y, string name)
        {
            this.X = X;
            this.Y = Y;
            this.name = name;
        }

        public double LiczObwod()
        {
            return 0;
        }

        public void PobierzDaneZKlawiatury()
        {
            Console.WriteLine("Podaj X: ");
            X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj Y: ");
            Y = Convert.ToInt32(Console.ReadLine());
        }
        public void Wyswietl()
        {
            Console.WriteLine("Punkt " + name + ": X: " + X + ", Y: " + Y);
        }

        public int CompareTo(Punkt other)
        {
            return this.name.CompareTo(other.name);
        }
    }
}
