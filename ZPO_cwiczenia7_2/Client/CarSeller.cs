using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO_cwiczenia7_2.Class;
using ZPO_cwiczenia7_2.Interface;

namespace ZPO_cwiczenia7_2.Client
{
    public class CarSeller
    {
        public CarSeller(IVehicleFactory vehicleFactory)
        {
            this.Car = vehicleFactory.CreateCar();
            this.Truck = vehicleFactory.CreateTruck();

        }
        public Car Car { get; }
        public Truck Truck { get; }
    }
}
