using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO_cwiczenia7_2.Class;
using ZPO_cwiczenia7_2.Client;
using ZPO_cwiczenia7_2.Factory;

namespace ZPO_cwiczenia7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var carSeller = new CarSeller(new AudiVehicleFactory());
            Car car = carSeller.Car;
            Console.WriteLine(car.GetMake());

            Console.ReadKey();
        }
    }
}
