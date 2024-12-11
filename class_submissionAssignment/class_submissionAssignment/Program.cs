using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_submissionAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            voidMethod intOutput = new voidMethod();

            Console.WriteLine("Please enter number to divide by 2.");
            int number = Convert.ToInt32(Console.ReadLine());

            intOutput.mathOp(number); //call function
            Console.WriteLine(intOutput.value);

            Console.ReadLine();

            Console.WriteLine("Enter text.");
            string stringInput = Console.ReadLine();
            string stringOp = intOutput.stringValue(stringInput, out int outputInt);
            Console.WriteLine(stringOp);
            Console.ReadLine();

            staticClass.staticMethod();
            Console.ReadLine();

            
        }
    }
}
