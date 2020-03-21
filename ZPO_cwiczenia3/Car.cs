using System;
using System.Collections.Generic;
using System.Text;

namespace ZPO_cwiczenia3
{
    class Car
    {
        private double pojemnoscSilnika;
        private string marka;
        public static int iloscKol;
        public const int iloscDrzwi = 4;

        public Car()
        {

        }
        private Car(double pojemnoscSilnika, string marka)
        {
            this.pojemnoscSilnika = pojemnoscSilnika;
            this.marka = marka;
        }

        ~Car()
        {
            Console.WriteLine("Zwalniam pamięć");
            Console.ReadKey();
        }


        public void UstawPojemnoscSilnika(double pojemnoscSilnika)
        {
            this.pojemnoscSilnika = pojemnoscSilnika;
        }

        public double PobierzPojemnoscSilnika()
        {
            return pojemnoscSilnika;
        }

        public void Create(double pojemnoscSilnika, string marka)
        {
            this.pojemnoscSilnika = pojemnoscSilnika;
            this.marka = marka;
        }
    }
}
