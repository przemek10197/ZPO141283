using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO_cwiczenia7_2.Class;

namespace ZPO_cwiczenia7_2.Interface
{
    public interface IVehicleFactory
    {
        Car CreateCar();
        Truck CreateTruck();
    }
}
