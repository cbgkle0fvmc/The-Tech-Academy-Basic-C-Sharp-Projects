using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_submissionAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            math math = new math(); //instantiate
            Console.WriteLine("Please input first integer.");
            int intInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input second optional integer.");
            string secondIntInput = Console.ReadLine();

            int result;
            if (string.IsNullOrEmpty(secondIntInput))
            {
                //Call the method with only the first number 
                result = math.operation(intInput);
            }
            else
            {
                //Parse the second number and call the method with both numbers
                int num2 = int.Parse(secondIntInput);
                result = math.operation(intInput, num2);
            }

            //Display the result
            Console.WriteLine("The result is: " + result);

            Console.ReadLine();

        }
    }
}
