using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCasts
{
    class FC
    {
        public void Display()
        {
            System.Console.WriteLine("FC::Display");
        }
    }
    class SC : FC
    {
        public new void Display()
        {
            //base.Display();
            System.Console.WriteLine("SC::Display");
        }
    }
    class ExampleOne
    {
        public static void Main()
        {
            SC obj = new SC();
            //FC obj = new SC();
            //((FC)obj).Display();
            obj.Display();

            Console.ReadKey();
        }
    }
}
