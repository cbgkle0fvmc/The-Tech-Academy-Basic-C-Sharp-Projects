using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractClass_submissionAssignment
{
    public class Employee : Person, IQuittable 
    {
        public override void SayName()
        {
            base.SayName();
        }
        public void Quit() //Step 2. Have your employee class inherit that interface
                           //and implement  the Quit() method
        {
            Console.WriteLine("Do you wish to close the console? enter y or n.");
            string closeOrNot = Console.ReadLine();
            if (closeOrNot == "y")
            {
                Console.WriteLine("Press enter to close console.");
            }
            else
            {
                Console.WriteLine("You chose not to close the console");
                Console.ReadLine();
            }

        }
    }
}
