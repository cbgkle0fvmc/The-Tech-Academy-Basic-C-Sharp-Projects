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
            int secondIntInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(math.operation(intInput, secondIntInput));

            Console.ReadLine();

        }
    }
}
