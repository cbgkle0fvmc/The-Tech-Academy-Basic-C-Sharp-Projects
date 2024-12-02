using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static void Main(string[] args)
    {

        //try block for program to be executed
        try
        {
            //Create list of integers named intList, add values into intList
            List<int> intList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            //Write "inut number to divide each number in the list by" to the console
            Console.WriteLine("Input number to divide each number in the list by.");

            //create variable userInput to store user input in, which math will be computed based on
            int userInput = Convert.ToInt32(Console.ReadLine());

            //initialize loop at index 0 of intList; continue loop until index is less than count of loop
            //increase by 1 each time loop is completed
            for (int i = 0; i < intList.Count; i++)
            {
                //create variable to hold values of each index divided by user input
                int mathOutput = intList[i] / userInput;

                //concatenate i(index value) / userInput(number to be divided by) = answer to equation 
                Console.WriteLine(i + "/" + userInput + "=" + mathOutput);
            }
        }

        // Output if 0 is written as userInput
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Cannot divide integer by 0. Please enter number that is not zero");
            //Console.WriteLine(ex.Message); writes error message in program
        }

        //Output if string is written as user input
        catch (FormatException ex)
        {
            Console.WriteLine("Enter an integer to perform division on.");
            //return;
        }

        Console.ReadLine();

        
    }
}
