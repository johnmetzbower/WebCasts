using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.MyFirstDataTypes
{
    public class Person
    {
        public string FirstName { get; private set;}
        public string LastName { get; private set;}
        public string MiddleName { get; private set; }


        public Person(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
        }
        public string SayHello(string name)
        {
            return "Hello " + name;
        }
    }
}
