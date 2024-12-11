using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchChallenge
{
    internal class Program
    {
        static void Main()
        {
            int injectionFlowrate = 125;
            int flowrateSP = 300;

            bool flowrateLTSP = injectionFlowrate < flowrateSP;
            bool flowrateEqSP = injectionFlowrate == flowrateSP;
            bool flowrateGTSP = injectionFlowrate > flowrateSP;

            switch (injectionFlowrate)
            {
                case 1:
                    if (injectionFlowrate < flowrateSP == true)
                    {
                        Console.WriteLine("Command Actuator Open.");
                    }
                break;
                case 2:
                    if (flowrateEqSP == true)
                    {
                        Console.WriteLine("Actuator Remain In Same Position.");
                    }
                break;
                case 3:
                    if (flowrateGTSP == true)
                    {
                        Console.WriteLine("Command Actuator Closed.");
                    }
                break;

                //Console.ReadLine();

                //default:
                //    Console.WriteLine("Awaiting feedback.");
            }
        }
    }
}
