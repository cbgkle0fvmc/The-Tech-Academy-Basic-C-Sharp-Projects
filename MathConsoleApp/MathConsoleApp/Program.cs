using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Please input number");
            string userInput = Console.ReadLine();
            int intUserInput = Convert.ToInt32 (userInput);
            int product = intUserInput * 50;
            Console.WriteLine(product);
            Console.ReadLine();

            Console.WriteLine("Please input number");
            string userInput1 = Console.ReadLine();
            int intUserInput1 = Convert.ToInt32(userInput1);
            int addition = intUserInput1 + 25;
            Console.WriteLine(addition);
            Console.ReadLine();

            Console.WriteLine("Please input number");
            string userInput2 = Console.ReadLine();
            double intUserInput2 = Convert.ToInt64(userInput2);
            double division = intUserInput2 / 12.5;
            Console.WriteLine(division);
            Console.ReadLine();

            Console.WriteLine("Please input number");
            string userInput3 = Console.ReadLine();
            int intUserInput3 = Convert.ToInt32(userInput3);
            bool greaterThan = intUserInput3 > 50;
            Console.WriteLine(greaterThan);
            Console.ReadLine();

            Console.WriteLine("Please enter number");
            string UserInput4 = Console.ReadLine();
            int intUserInput4 = Convert.ToInt32(UserInput4);
            int percent = intUserInput4 % 7;
            Console.WriteLine(percent);
        }
    }
}
