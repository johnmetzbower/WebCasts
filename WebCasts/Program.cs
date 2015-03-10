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

            #region Old Class Related Code
            
           
            //Person john = new Person("John", "David", "Metzbower"), aline = new Person("Aline", "Metzbower", "Gonzalez");

            //string greeting = john.SayHello(aline);

            //Console.WriteLine(greeting);
            #endregion


            Person bob = new Person("Bob", "Bob"), bob2 = new Person("Bob", "Bob");
            
            //Logical AND &&
            //true && ture - true
            //true && false - false
            //fasle && true - false (short circuit)
            // false && false - false

            // logical OR ||
            // true || true - true
            // true || false - true (short circuit)
            // false || true - true
            // false || false - false

            // logical NOT !
            // !true - false
            // !false - true

            string str = "test";

            /*if (str == "test")
            {
                Console.WriteLine("this is true");    
            }
            else if (str == "Test")
            {
                Console.WriteLine("this is also true");
            }
            else
            {
                Console.WriteLine("this is false");
            }*/
            
            switch (str)
            {
                case "test":
                    Console.WriteLine(@"the value is ""test""");
                    break;
                case "Test":
                    Console.WriteLine(@"the value is ""Test""");
                    break;
                case "tEst":
                    Console.WriteLine(@"the value is ""tEst""");
                    break;
                case "tesT":
                    Console.WriteLine(@"the value is ""tesT""");
                    break;
                default:
                    Console.WriteLine("no value was found");
                        break;
            }
            
            
            
            
            Console.WriteLine("\nWe're out of the switch");

        }
    }
}