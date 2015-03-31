using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstProject.MyFirstDataTypes;

namespace MyFirstProject.MyFirstDataTypes
{
    /*public delegate void SayMessage(string message);

    class DelegateOne
    {
        public void Method(string message)
        {
            Console.WriteLine(message);
        }
    }

    class DelegateTwo
    {
        public void MethodTwo(SayMessage fn)
        {
            fn("Hello, World from DelegateTwo!");
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            DelegateOne one = new DelegateOne();
            DelegateTwo two = new DelegateTwo();

            two.MethodTwo(one.Method);

        }
    }*/
    class Program
    {

        static void Main(string[] args)
        {

            List<string> names = new List<string>
            {
                "Jeremy",
                "Jeffrey",
                "John",
                "Jennifer",
                "Jackie",
                "Julianne",
            };

            Func<string, bool> fn = FindNamesWithE;
            Predicate<string> pred = name => name.IndexOf("e") == 1;

            Func<int, string, bool> fn2 = (i, s) =>
            {
                return true;
            };
            

            bool result = fn("ae");

            Console.WriteLine(result);

            var namesWithE = names.FindAll(
                delegate(string name)
                {
                    return name.IndexOf("e") == 1;
                }
            );

            foreach (var name in namesWithE)
            {
                Console.WriteLine(name);
            }
        }
        public static bool FindNamesWithE(string name)
        {
            return name.IndexOf("e") == 1;
        }
    }
}