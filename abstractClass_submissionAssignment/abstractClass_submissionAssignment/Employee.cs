using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractClass_submissionAssignment
{
    public class Employee : Person //Step 3. Create another class called employee and have it inherit from the Person class
    {
        public override void SayName() //Step 4. Implement the SayName() method inside of the Employee class.
        {
            base.SayName();
        }
        
    }
}
