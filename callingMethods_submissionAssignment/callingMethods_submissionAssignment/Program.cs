using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callingMethods_submissionAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            integerOperations integerOperations = new integerOperations();
            Console.WriteLine("What number do you want to do mathemic operations on?");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(integerOperations.additionOperation(userInput));
            Console.WriteLine(integerOperations.multiplicationOperation(userInput));
            Console.WriteLine(integerOperations.divisionOperation(userInput));
            Console.ReadLine();



        }
    }
}
