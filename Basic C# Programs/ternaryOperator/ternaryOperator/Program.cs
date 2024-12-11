using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ternaryOperator
{
    internal class Program
    {
        static void Main()
        {
            int injSP = 500;
            int PV = 400;

            string output = PV < injSP ? "Process variable is below setpoint" : "Process variable is at or above setpoint.";
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
