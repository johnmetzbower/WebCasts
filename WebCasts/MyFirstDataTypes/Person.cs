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


        public Person(string firstName, string lastName = "")//makes last name optional
        {
            FirstName = firstName;
            LastName = lastName;
         
        }
        public string SayHello(string name)
        {
            return "Hello there, " + name;
        }

        public string SayHello(Person person)
        {
            return SayHello(person.FirstName + " " + person.LastName);
        }
    }
}
