using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractClass_submissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {    
            Employee employee1 = new Employee() { firstName="Sample", lastName="Student"};
            employee1.SayName();
            //Console.ReadLine();

            //Step 3. Use Polymorphism to create an object that can call the quit() method on it
            IQuittable endProgram = new Employee();
            endProgram.Quit();                      
            /* **** I was got stuck at this step. The I'm not sure of step 3 is correct, please 
             * provide guidance if it got this wrong. Thanks **** */ 
        }
    }
}
