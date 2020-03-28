using System;
using System.Collections.Generic;

namespace ZPO_cwiczenia4
{
    class Program
    {
        static void Main(string[] args)
        {

            // CWICZENIE 1
            //Osoba student1 = new Student("jan", "kowalski", 2, 1, 122221);
            //student1.WypiszInfo();

            // CWICZENIE 2
            Console.WriteLine("Cwiczenie 2");
            Osoba student2 = new Student("Jan", "Kowalski", 2, 1, 122221);
            Console.WriteLine(student2);

            // CWICZENIE 3
            Console.WriteLine("Cwiczenie 3");
            Figura kwadrat1 = new Kwadrat(4);
            Console.WriteLine(kwadrat1.ObliczPole());
            Figura trojkat1 = new Trojkat(1, 3, 3);
            Console.WriteLine(trojkat1.ObliczPole());
            List<Figura> figury = new List<Figura>();
            figury.Add(new Trojkat(3, 7, 9));
            figury.Add(new Kwadrat(3));
            foreach (var figura in figury)
            {
                Console.WriteLine(figura.ObliczPole());
            }

            // CWICZENIE 4

            // KOMUNIKAT BLEDU - 'Student4': cannot derive from sealed type 'Osoba4' - nie mozna dziedziczyc po zapieczetowanej klasie

            // CWICZENIE 5
            Console.WriteLine("Cwiczenie 5");
            // KOMUNIKAT BLEDU - 'Ccc.Metoda()': cannot override inherited member 'Bbb.Metoda()' because it is sealed
            Ccc obiekt1 = new Ccc();
            obiekt1.Metoda();

            //CWICZENIE 6
            Console.WriteLine("Cwiczenie 6");
            Wspolrzedne wspolrzedne1 = new Wspolrzedne(1, 2);
            wspolrzedne1.Pokaz();

            Console.ReadKey();
        }
    }
}
