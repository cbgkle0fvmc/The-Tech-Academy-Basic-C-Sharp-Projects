using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod_SubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            operations operations = new operations(); //instantiate class operations
            decimalOperation decimalOperation = new decimalOperation();
            stringToNum stringToNum = new stringToNum();
            

            Console.WriteLine("Enter number to perform math on.");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(operations.additionOperation(userInput));

            Console.WriteLine("Input decimal number for math operation");
            decimal userInputDecimal = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(decimalOperation.decimalOp(userInput));

            try
            {
                Console.WriteLine("If possible, string will be converted to integer");
                string userInputString = Console.ReadLine();
                int userInputToInt = Convert.ToInt32(userInputString);
                Console.WriteLine(stringToNum.stringToNumber(userInputToInt));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
        
    }
}
