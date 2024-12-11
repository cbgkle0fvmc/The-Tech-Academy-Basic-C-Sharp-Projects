using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shippingQuote
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n");
            Console.WriteLine("Please enter package weight.");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day");
            }

            Console.WriteLine("Please enter a package width.");
            int packageWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a package height");
            int packageHeight = Convert.ToInt32(Console.ReadLine());

            int shippingCalculation = packageHeight * packageWidth * packageWeight * packageWeight / 100;
            Console.WriteLine("Your estimated total for shipping this package is: $" + shippingCalculation);
            
            Console.ReadLine();
        }
    }
}
