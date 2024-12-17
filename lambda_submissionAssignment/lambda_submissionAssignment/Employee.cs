using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda_submissionAssignment
{
    public class Employee //Step 1. Create Employee class with Id, Fname, Lname Properties
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Below : Constructor to initialize properties
        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;

        }
    }
}
