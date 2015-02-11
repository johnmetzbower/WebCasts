using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCasts
{
    class Polygon
    {
        public int width, height;
        public void setValues(int a, int b)
        {
            this.width = a;
            this.height = b;
        }
    }
    class Rectangle : Polygon
    {
        public int area()
        {
            return width * height;
        }
    }
    class Triangle : Polygon
    {
        public int area()
        {
            return width * height / 2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            Triangle tri = new Triangle();
            rect.setValues(10, 20);
            tri.setValues(10, 20);

            Console.WriteLine("the area of the rectangle is {0} and the area of the triangle is {1}", rect.area(), tri.area());

            Console.ReadKey();
        }
    }
}
