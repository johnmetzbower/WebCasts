using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCasts
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("sume of two ints is {0}", sum(45, 65));
            Console.WriteLine("sume of two doubles is {0}", sum(45.5, 64.5));
            Console.WriteLine("sume of two strings is {0}", sum("Hello ", "World"));
            Console.ReadKey();

        }
        public static int sum(int x, int y)
        {
            int add = x + y;
            return add;
        }
        public static double sum(double x, double y)
        {
            double add = x + y;
            return add;
        }
        public static string sum(string x, string y)
        {
            string add = x + y;
            return add;
        }
    }
}
