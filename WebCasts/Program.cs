using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCasts
{
    interface IMeter
    {
       void print();
    }

    class Meter : IMeter
    {
        public void print()
        {
            Console.WriteLine("What I want to print");
        }
    }

    class Program
    {
        public static void Main()
        {
            Meter met = new Meter();
            met.print();



            Console.ReadKey();
        }
    }
}
