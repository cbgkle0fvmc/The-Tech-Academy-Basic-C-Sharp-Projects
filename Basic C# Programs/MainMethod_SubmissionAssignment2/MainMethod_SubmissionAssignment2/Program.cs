using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod_SubmissionAssignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mathOperations mathOperations = new mathOperations();
            

            Console.WriteLine("Enter number to do math on.");
            int UserInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(mathOperations.MathOperation(UserInput));

            Console.WriteLine("Enter decimal number to show method overloading.");
            decimal decimalUserInput = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(mathOperations.MathOperation((decimal)decimalUserInput));

            try
            {
                Console.WriteLine("This will convert a string to int if possible. Please enter number");
                string strUserInput = Console.ReadLine();
                Console.WriteLine(mathOperations.MathOperation(strUserInput));
            }
            catch
            {
                Console.WriteLine("Please enter integer.");
            }
            

            
        }
        
    }
}
