using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstProject.MyFirstDataTypes;

namespace MyFirstProject.MyFirstDataTypes
{
    class Program
    {

        static void Main(string[] args)
        {
            Shape shape = new Square(12);
            Square square = new Square(10);

            Console.WriteLine(shape.Area);
        }
    }
}