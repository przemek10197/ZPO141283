using System;
using System.Collections.Generic;
using System.Text;

namespace ZPO_cwiczenia3
{
    class Telefon
    {
        public double saldo;
        public double saldoKoncowe;

        public Telefon(double saldo)
        {
            this.saldo = saldo;
            saldoKoncowe = saldo;
        }

        public void Doladowanie(double kwota)
        {
            saldoKoncowe += kwota;
            Console.WriteLine("Saldo po doladowaniu: " + saldoKoncowe);
        }

        public void wyslanieSmsa(int ileSmsow)
        {
            saldoKoncowe -= ileSmsow * 0.2;
            Console.WriteLine("Saldo po SMS: " + saldoKoncowe);
        }

        public void rozmowa(int ileMinut)
        {
            saldoKoncowe -= ileMinut * 0.3;
            Console.WriteLine("Saldo po rozmowie: " + saldoKoncowe);
        }

        public void polaczenieZInternetem(int ileGb)
        {
            saldoKoncowe -= ileGb * 1;
            Console.WriteLine("Saldo po polaczeniu z internetem: " + saldoKoncowe);
        }

        public void uslugiPremium()
        {
            saldoKoncowe -= 30;
            Console.WriteLine("Saldo po uslugach premium: " + saldoKoncowe);
        }
    }
}
