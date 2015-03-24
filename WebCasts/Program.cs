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
            ISalariable emp = new Employee("John", "Doe", "Sales Clerk", 2000);

            decimal salary = emp.Salary;
            emp.PaySalary();

        }
    }
}