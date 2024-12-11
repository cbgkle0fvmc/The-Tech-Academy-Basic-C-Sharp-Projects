using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elseIf
{
    internal class Program
    {
        static void Main()
        {
            string runPermissive = "Run";

            if (runPermissive == "Run")
            {
                Console.WriteLine("System Run Permitted");
            }
            else if (runPermissive != "Run") 
            {
                Console.WriteLine("System Shutdown");
            }
        }
    }
}
