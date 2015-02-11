using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCasts
{
    class Box
    {
        public double height, length, width;

        public double volume()
        {
            return (this.height * this.length * this.width);
        }
        public Box(double h, double l, double w)
        {
            this.height = h;
            this.length = l;
            this.width = w;
            Console.WriteLine("the constuctor is instantiated");
        }
        ~Box()
        {
            Console.WriteLine("The destructor is called");
        }
    }
    class Program
    {
        public static void Main()
        {
            Box boxOne = new Box(10, 10, 10);
            /*boxOne.length = 10;
            boxOne.height = 10;
            boxOne.width = 10;*/

            Console.WriteLine("volume of boxOne is {0}", boxOne.volume());

            //Console.ReadKey();
        }
    }
}
