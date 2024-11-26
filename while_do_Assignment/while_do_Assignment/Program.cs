using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_do_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Process Variable:\n");
            int PV = Convert.ToInt32(Console.ReadLine());
            int SP = 300;
            bool setpoint = PV == SP;

            while (PV <= SP)
            {
                Console.Write("Process Variable Below Setpoint.");
                break;
            }

            do
            {
                switch (PV)
                {
                    case 0:
                        Console.WriteLine("Loop out of service.");
                        Console.WriteLine("Enter a flowrate");
                        PV = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 75:
                        Console.WriteLine("PV below SP, Actuator Opening.");
                        Console.WriteLine("Enter a flowrate");
                        PV = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 150:
                        Console.WriteLine("PV below SP, Actuator Opening.");
                        Console.WriteLine("Enter a flowrate");
                        PV = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 300:
                        Console.WriteLine("PV at SP, Actuator to remain in same position.");
                        setpoint = true;
                        break;
                    case 315:
                        Console.WriteLine("PV above SP, closing actuator");
                        Console.WriteLine("Enter a flowrate");
                        PV = Convert.ToInt32(Console.ReadLine());
                        break;

                    default:
                        Console.WriteLine("PV is not at SP");
                        Console.WriteLine("Enter a flowrate");
                        PV = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }

            while (PV != SP);

            Console.ReadLine();
        }
    }
}
