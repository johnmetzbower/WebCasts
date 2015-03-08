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
            Person person = new Person("John ", "Metzbower");
            Console.WriteLine(person.SayHello("John Metzbower"));

        }
    }
}