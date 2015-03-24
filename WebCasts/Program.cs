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
            /*object foo = (object)10;
            int bar = (int)foo;*/

            Employee john = new Employee("John", "Metzbower", "Owner");
            Person customer = new Person("Jeremy", "Piven");

            Console.WriteLine(john.SayHello(customer));
        }
    }
}