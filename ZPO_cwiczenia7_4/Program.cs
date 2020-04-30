using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO_cwiczenia7_4.Class;
using ZPO_cwiczenia7_4.Client;
using ZPO_cwiczenia7_4.Factory;

namespace ZPO_cwiczenia7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var smartfonClient = new SmartfonClient(new SamsungSmarfonFactory());
            Smartfon s1 = smartfonClient.Smartfon;
            Console.WriteLine(s1.GetMake());

            Console.ReadKey();
            
        }
    }
}
