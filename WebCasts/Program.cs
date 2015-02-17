using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCasts
{
    public class Drawing
    {
        public virtual void Draw()
        {
            Console.WriteLine("This is just a generic drawing object.");
        }
    }

    public class Line : Drawing
    {
        public override void Draw()
        {
            Console.WriteLine("This is a line.");
        }
    }

    public class Circle : Drawing
    {
        public override void Draw()
        {
            Console.WriteLine("This is a circle.");
        }
    }

    public class Square : Drawing
    {
        public override void Draw()
        {
            Console.WriteLine("This is a square.");
        }
    }

    class ExampleOne
    {
        public static void Main()
        {
            Drawing[] drawingObject = new Drawing[4];
            drawingObject[0] = new Line();
            drawingObject[1] = new Circle();
            drawingObject[2] = new Square();
            drawingObject[3] = new Drawing();

            foreach(Drawing draw in drawingObject)
            {
                draw.Draw();
            }

            Console.ReadKey();
        }
    }
}
