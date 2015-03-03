using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCasts
{
    public abstract class Meter
    {
        public abstract void printMeter1();
        public void printMeter2()
        {
            Console.WriteLine("We are in printMeter2");
        }
    }

    class ExampleOne : Meter
    {
        public override void printMeter1()
        {
            Console.WriteLine("We are in printMeter1");
        }
        public static void Main()
        {

            ExampleOne ex1 = new ExampleOne();
            ex1.printMeter1();
            ex1.printMeter2();


            Console.ReadKey();
        }

    }
}