using System;
using System.Collections.Generic;
using System.Text;

namespace ZPO_cwiczenia3
{
    class Konto
    {
        public int saldo;
        public int saldoOszczednosciowe;
        
        public Konto(int saldo)
        {
            this.saldo = saldo;
            saldoOszczednosciowe = 0;
        }

        public void wyplata(int kwota)
        {
            saldo -= kwota;
        }

        public void wplata(int kwota)
        {
            saldo += kwota;
        }

        public void przelewDoKontaOszczednosciowego(int kwota)
        {
            saldo -= kwota;
            saldoOszczednosciowe += kwota;
        }

        public void przelewZKontaOszczednosciowego(int kwota)
        {
            saldo += kwota;
            saldoOszczednosciowe -= kwota;
        }

        public void przelewZewnetrzny(Konto konto, int kwota)
        {
            saldo -= kwota;
            konto.saldo += kwota;
        }
    }
}
