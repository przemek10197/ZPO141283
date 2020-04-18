using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO_cwiczenia6_3
{
    class Program
    {
        public static void concatString(String s1)
        {
            String st = "concat";

            s1 = String.Concat(s1, st);
        }
        public static void concatStringBuilder(StringBuilder s2)
        {
            s2.Append("concat");
        }
        static void Main(string[] args)
        {
            String s1 = "String";
            concatString(s1);
            Console.WriteLine("String Class: " + s1);
            StringBuilder s2 = new StringBuilder("String");
            concatStringBuilder(s2);
            Console.WriteLine("UStringBuilder Class: " + s2);

            Console.ReadKey();
        }
    }
}
