using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractClass_submissionAssignment
{
    public abstract class Person //Step 1. Create an abstract class called Person with two properties : string firstName and string lastName
    {
        public string firstName {  get; set; }
        public string lastName { get; set; }

        public virtual void SayName() //Step 2. Give it the method SayName()
        {
            Console.WriteLine("Name: " + this.firstName + " " + this.lastName);
        }
    }
}
