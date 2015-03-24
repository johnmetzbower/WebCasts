using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.MyFirstDataTypes
{
    public class Person
    {
        public string FirstName { get; protected set;}
        public string LastName { get; protected set;}


        public Person(string firstName, string lastName)//makes last name optional
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentException("name cannot be null, empty, or whitespace");
            }
            if (string.IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentException("lastName cannot be null or whitespace");
            }

            FirstName = firstName;
            LastName = lastName;
         
        }
        public virtual string SayHello(string name)
        {
            //null
            //empty
            //whitespace
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("name cannot be null, empty, or whitespace");
            }
            return "Hello there, " + name;
        }

        public string SayHello(Person person)
        {
            if(person == null)
            {
                throw new ArgumentNullException("person cannot be null");
            }
            return SayHello(person.FirstName + " " + person.LastName);
        }

        /*public string SayHello(params string[] names)
        {
            StringBuilder builder = new StringBuilder();
            string temp = string.Empty;

            foreach (string name in names)
            {
                // name, name, name, 
                builder.Append(name + ", ");
            }

            temp = builder.ToString();
            temp = temp.Remove(temp.LastIndexOf(","));

            return SayHello(temp);

        }*/

        public string SayHello(params string[] names)
        {

            return SayHello(string.Join(", ", names));

        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

  

    }
}
