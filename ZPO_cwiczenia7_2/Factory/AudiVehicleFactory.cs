using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO_cwiczenia7_2.Class;
using ZPO_cwiczenia7_2.Interface;

namespace ZPO_cwiczenia7_2.Factory
{
    public class AudiVehicleFactory : IVehicleFactory
    {
        public Car CreateCar()
        {
            return new CarAudi();
        }

        public Truck CreateTruck()
        {
            return new TruckAudi();
        }
    }
}
