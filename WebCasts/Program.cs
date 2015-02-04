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
    }
    class Program
    {
        public static void Main()
        {
            Box boxOne = new Box();
            boxOne.length = 10;
            boxOne.height = 10;
            boxOne.width = 10;

            Console.WriteLine("volume of boxOne is {0}", boxOne.volume());

            Console.ReadKey();
        }
    }
}
