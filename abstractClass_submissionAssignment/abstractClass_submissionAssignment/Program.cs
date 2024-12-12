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
            //Step 5. Inside the Main() method, instantiate the Employee object with the 
            //firstName "Sample" and lastName "Student". Call the SayName() method on the object

            Employee employee1 = new Employee() { firstName="Sample", lastName="Student"};
            employee1.SayName();
            Console.ReadLine();


            
        }
    }
}
