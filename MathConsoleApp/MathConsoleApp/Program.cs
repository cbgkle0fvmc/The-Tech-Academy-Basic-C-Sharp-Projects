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


        }
    }
}
