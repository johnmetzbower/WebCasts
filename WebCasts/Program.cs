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
            /*char[] foo = new char[5];

            foo[0] = 'H';
            foo[1] = 'E';
            foo[2] = 'L';
            foo[3] = 'L';
            foo[4] = 'O';

            char[] foo = new char[]
            {
                'H', //0
                'E', //1
                'L', //2
                'L', //3
                'O'  //4


            };

            foreach (char c in foo)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine(string.Empty);*/

            string[] names = new string[] 
            {
                "James",
                "John",
                "Jennifer",
                "Jackie"
            };

            var namesList = new List<string>();
            namesList.AddRange(names);

            /*var newList = namesList.FindAll((s) => s[1] == 'a');

            foreach (var name in newList)
            {
                Console.WriteLine(name);
            }

            namesList.Remove("Jackie");

            var newList = namesList;

            foreach (var name in newList)
            {
                Console.WriteLine(name);
            }*/

            var dictionary = new Dictionary<string, string>();
            dictionary.Add("a", "Jeremy");
            dictionary.Add("bill", "Jeffrey");

            foreach (var kvp in dictionary)
            {
                Console.WriteLine(kvp.Key + " = " + kvp.Value);
            }

            string value = dictionary["a"];
        }
    }
}