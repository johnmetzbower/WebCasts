using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCasts
{
    public delegate int addNumbersDelegate(int number1, int number2);
    class ExampleOne
    {
        public static int addNumbers(int number1, int number2)
        {

            return number1 + number2;
        }


        public static void Main()
        {
            addNumbersDelegate del = new addNumbersDelegate(addNumbers);
            int result = del(10, 10);
            Console.WriteLine(result);

            Console.ReadKey();
        }

    }
}