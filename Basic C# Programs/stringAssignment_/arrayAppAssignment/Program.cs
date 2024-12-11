using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayAppAssignment
{
    internal class Program
    {
        static void Main()
        {
            string[] stringArray = { "Here", "Work", "Computer", "PCCU", "charger", "dock" };
            int[] intArray = { 45, 90, 120, 156, 256, 512, 1024, 2048, 4096, };
            List<string> stringList = new List<string>() { "Home", "Wife", "Study", "Relax", "Programming", "C#" };

            Console.WriteLine("Select an index of String array to display results.");
            int UserInput = Convert.ToInt32(Console.ReadLine());

            if (UserInput < stringArray.Length)
            {
                Console.Write(stringArray[UserInput]);
            }

            else if (UserInput > stringArray.Length)
            {
                Console.WriteLine("User input does not exist in String Array");
            }

            Console.WriteLine("\n");

            Console.WriteLine("Select an index of the integer array to display value.");
            int intUserInput = Convert.ToInt32(Console.ReadLine());

            if (UserInput < intArray.Length)
            {
                Console.WriteLine(intArray[intUserInput]);
            }

            else if (UserInput > intArray.Length)
            {
                Console.WriteLine("User input does not exist in Int Array.");
            }

            Console.WriteLine("Select an index of String List to display value");
            int strUserInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(stringList[strUserInput]);

            Console.ReadLine();
        }
    }
}
