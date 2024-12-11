using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Highlight block, ctrl+k+c = comment block
            //cntrl + k + u = uncomment block
            //console.writeline("what is your name?");
            //string yourname = console.readline();
            //console.writeline("your name is: " + yourname);
            //console.readline();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();

            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemp = -23;
            char questionMark = '\u2103';

            decimal moneyInBank = 100.5m;

            double heightInCentimeters = 211.303020354;

            float secondsLeft = 2.62f;

            short temperatureOnMars = -341;

            string myName = "Josh";

            int currentAge = 30;
            string yeasOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);
            Console.WriteLine(rainingStatus);
            Console.ReadLine();

        }
    }
}
