using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsAndObjects_submissionAssignment
{
    public class person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()
        {
            Console.WriteLine("Name: " + this.FirstName +  " " + this.LastName);
        }

    }

    
        
}
