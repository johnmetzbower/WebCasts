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

            Square square = new Square(10, Color.Black);
            Circle circle = new Circle(10, Color.White);

            Console.WriteLine("Area of the Square is...");
            Console.WriteLine(square.Area);  //why is it not compiling?
        }
    }
}