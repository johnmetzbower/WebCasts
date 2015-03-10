using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstProject.MyFirstDataTypes;

namespace MyFirstProject
{
    class Program
    {

        static void Main(string[] args)
        {
            Person john = new Person("John", "David", "Metzbower"), aline = new Person("Aline", "Metzbower", "Gonzalez");

            string greeting = john.SayHello(aline);

            Console.WriteLine(greeting);

            

        }
    }
}