using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greaterLessThanOperators
{
    internal class Program
    {
        static void Main()
        {
            int heaterTempF = 115;
            int heaterHH = 125;

            if (heaterTempF > heaterHH)
            {
                Console.WriteLine("Temperatue Alarm");
            }
            else
            {
                Console.WriteLine("Heater Temperature is: " +  heaterTempF);
            }

            Console.ReadLine();
        }
    }
}
