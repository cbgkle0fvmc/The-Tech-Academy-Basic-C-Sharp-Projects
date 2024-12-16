using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Operators_submissionAssignment
{
    public class Employee //Step 1. Create an employee class with Id, FirstName and LastName properties.
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        //public List <Employee> Employees { get; set; }

        /* Step 2. In the Employee class, overload the “==” operator so it checks if two Employee objects are equal 
         * by comparing their Id property. Remember that comparison operators must be overloaded in pairs. */

        //Line 24 of Program.cs : Console.writeline(employee1==employee2), if true,
        //Line 22 of Employee.cs will execute and return bool of 
        public static bool operator == (Employee employee1, Employee employee2)
        {
            return employee1.Id == employee2.Id; //return statement specifies employee id property ==
        }

        public static bool operator != (Employee employee1, Employee employee2)
        {
            return employee1.Id != employee2.Id;

        }



    }
}
