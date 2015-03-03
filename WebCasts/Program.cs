using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCasts
{
    interface IMeter1
    {
        void print();
    }
    interface IMeter2
    {
        void print();
    }

    class Program : IMeter1, IMeter2 
    {
        void IMeter1.print()
        {
            Console.WriteLine("Print Meter 1");
        }
        void IMeter2.print()
        {
            Console.WriteLine("Print Meter 2");
        }


        public static void Main()
        {
            Program ex = new Program();
            ((IMeter1)ex).print();
            ((IMeter2)ex).print();

            Console.ReadKey();
        }
    }
}
