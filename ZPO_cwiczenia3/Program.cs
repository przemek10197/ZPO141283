using System;
using System.Collections.Generic;

namespace ZPO_cwiczenia3
{
    class Program
    {
        static string OpiszTyp()
        {
            return "Metoda bez argumentów";
        }
        static string OpiszTyp(int x)
        {
            return "Liczba całkowita";
        }
        static string OpiszTyp(string x)
        {
            return "Łańcuch znaków";
        }
        static string OpiszTyp(int x, int y)
        {
            return "Dwie liczby calkowite";
        }

        static void Main(string[] args)
        {
            // CWICZENIE 1 //
            Console.WriteLine("Cwiczenie 1");
            Car car1 = new Car();
            car1.UstawPojemnoscSilnika(1.6);
            Console.WriteLine("Car1 - pojemnosc silnika: ", car1.PobierzPojemnoscSilnika());

            Car car3 = new Car();
            car3.Create(2.0, "Audi");


            // CWICZENIE 2 //
            Console.WriteLine("Cwiczenie 2");
            Matematyka.ObliczPole(2);
            Matematyka.ObliczObwod(4);

            // CWICZENIE 3 //
            Console.WriteLine("Cwiczenie 3");
            Console.WriteLine(OpiszTyp(2));
            Console.WriteLine(OpiszTyp("Łańcuch znaków"));
            Console.WriteLine(OpiszTyp(2, 4));
            Console.WriteLine(OpiszTyp());

            // CWICZENIE 4 //
            Console.WriteLine("Cwiczenie 4");
            Konto kontoAdama = new Konto(2000);
            Konto kontoAni = new Konto(5000);
            Konto kontoMichala = new Konto(500);

            Console.WriteLine("Konto Adama: " + kontoAdama.saldo);
            Console.WriteLine("Konto Ani: " + kontoAni.saldo);
            Console.WriteLine("Konto Michala: " + kontoMichala.saldo);

            kontoAdama.przelewDoKontaOszczednosciowego(200);
            Console.WriteLine("Konto Adama po przleewie wewnetrznym: " + kontoAdama.saldo);

            kontoAni.przelewDoKontaOszczednosciowego(500);
            kontoAni.przelewZKontaOszczednosciowego(100);
            Console.WriteLine("Konto Ani po przelewach wewnetrznych: " + kontoAni.saldoOszczednosciowe);

            kontoMichala.wplata(300);
            Console.WriteLine("Konto Michala po wplacie: " + kontoMichala.saldo);

            kontoAdama.wyplata(200);
            Console.WriteLine("Konto Adama po wyplacie: " + kontoAdama.saldo);

            kontoAni.przelewZewnetrzny(kontoMichala, 500);
            Console.WriteLine("Konto Ani po przelewie do Michala: " + kontoAni.saldo);
            Console.WriteLine("Konto Michala po otrzymaniu przleewu od Ani: " + kontoMichala.saldo);


            // CWICZENIE 5 //
            Console.WriteLine("Cwiczenie 5");
            Console.WriteLine("Ajfon");
            Telefon ajFon = new Telefon(0);
            ajFon.Doladowanie(50);
            ajFon.polaczenieZInternetem(5);
            ajFon.uslugiPremium();
            Console.WriteLine("Smartfon");
            Telefon smartfon = new Telefon(0);
            smartfon.Doladowanie(30);
            smartfon.wyslanieSmsa(4);
            smartfon.rozmowa(10);

            // CWICZENIE 6 //
            Console.WriteLine("Cwiczenie 6");
            Student Pawel = new Student(2, 3, 3, "Pawel", "Andrzej", 1999, "Olsztyn");
            Pawel.ObliczWiek();

            Osoba student2 = new Student(1, 1, 1, "Jan", "Kowalski", 1960, "Warszawa");
            student2.WyswietlInfo();

            Student student3 = new Student();
            Osoba osoba3 = student3;
            Student student4 = (Student)osoba3;
            student3.WypiszInfo();
            osoba3.WyswietlInfo();
            student4.WypiszInfo();

            // CWICZENIE 7 //
            Console.WriteLine("Cwiczenie 7");

            // CWICZENIE 15 //
            Console.WriteLine("Cwiczenie 15");
            Punkt punct1 = new Punkt(2, 2, "Punkt 1");
            punct1.Wyswietl();
            Punkt punct2 = new Punkt(2, 4, "Punkt 2");
            punct2.PobierzDaneZKlawiatury();
            Punkt punct3 = new Punkt(4, 2, "Punkt 3");
            Punkt punct4 = new Punkt(4, 4, "Punkt 4");
            Kwadrat kwadrat1 = new Kwadrat(punct1, punct2, punct3, punct4, "Romb");
            kwadrat1.Wyswietl();

            List<Punkt> punkty = new List<Punkt>();
            punkty.Add(punct1);
            punkty.Add(punct3);
            punkty.Add(punct4);
            punkty.Add(punct2);
            punkty.Sort();
            foreach (var punkt in punkty)
            {
                Console.WriteLine(punkt.name);
            }
            kwadrat1.LiczObwod();

            Console.ReadKey();
        }
    }
}
