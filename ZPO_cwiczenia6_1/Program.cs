using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO_cwiczenia6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            IBuilder b1 = new Car("Ford");
            IBuilder b2 = new MotorCycle("Honda");
            IBuilder b3 = new Car("Kia");
            IBuilder b4 = new MotorCycle("Yamaha");

            director.Construct(b1);
            Product p1 = b1.GetVehicle();
            p1.Show();


            director.Construct(b2);
            Product p2 = b2.GetVehicle();
            p2.Show();

            Director director2 = new Director();
            director2.Construct(b4);
            Product p3 = b3.GetVehicle();
            p3.Show();
            Product p4 = b4.GetVehicle();
            p4.Show();

            List<Director> directors = new List<Director>();
            directors.Add(director);
            directors.Add(director2);

            foreach (Director dir in directors)
            {
                dir.Construct(b3);
                Product p5 = b3.GetVehicle();
            }

            Console.ReadLine();
        }
    }
}
