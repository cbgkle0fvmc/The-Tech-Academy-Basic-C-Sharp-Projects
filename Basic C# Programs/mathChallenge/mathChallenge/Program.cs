using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Math Challenge : Perform add, subtract, multiply and divide operations in the console. \n");

            int num1 = 20;
            int num2 = 20;
            int num3 = 10;

            int total = num1 + num2;
            int difference = total - num3;
            int product = num1 * num2;
            int quotient = num2 / num3;

            Console.WriteLine("Num1 + Num 2 = " + total);
            Console.WriteLine("Num 1 - Num 3 = " + difference);
            Console.WriteLine("Num1 * Num 2 = " + product);
            Console.WriteLine("Num 2 / Num 3 = " + quotient);

            Console.ReadLine();
        }
    }
}
