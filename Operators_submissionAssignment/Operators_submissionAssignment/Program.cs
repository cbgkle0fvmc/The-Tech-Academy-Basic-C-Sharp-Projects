using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_submissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        /* In the "Program.cs" file, instantiate two objects of the Employee class and assign values to their
         * properties. Then compare the two Employee objects using the newly overloaded operators and display 
         * the results. */
        {
            Employee employee = new Employee(); //Instantiate employee object
            //employee.Employees = new List<Employee>(); //Instantiate employee list

            //assign values to employee 1 properties
            Employee employee1 = new Employee() { Id= 1, FirstName="Joshua", LastName="Cordova"};
            //assign values to employee 2 properties
            Employee employee2 = new Employee() { Id = 2, FirstName = "Alicia", LastName = "Cordova" };

            Console.WriteLine(employee1 == employee2); //Call operator overload ==
            /* Employee class referred to as employee in 'employee' in program.cs
             * Line 20 Employee (Class) employee1 (new instance of Employee object)
             * Line 24: employee1==employee2 calls bool operator overloading, executes bool employee1.id==employee2.id*/
            Console.ReadLine();



        }
    }
}
