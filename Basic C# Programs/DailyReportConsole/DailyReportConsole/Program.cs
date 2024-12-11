using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy \n");
            Console.WriteLine("Student Daily Report \n");

            Console.WriteLine("What is your name? "); //Create string variable studentName for input
            string studentName = Console.ReadLine();

            Console.WriteLine("What course are you on?"); // Create string variable studentCourse for course student is on
            string studentCourse = Console.ReadLine();

            Console.WriteLine("What page are you on?"); // Create string variable for page number input, convert to int
            string coursePageNumber = Console.ReadLine();
            int pageNumber = Convert.ToInt32(coursePageNumber);

            Console.WriteLine("Do you ned help with anything? Please answer \"true\" or \"false.\"");
            string studentNeedsHelp = Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you\'d like to share? Please give specifics.");
            string studnetInputPositive = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you\'d like to provide? Please be specific.");
            string otherFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hoursStudiedDaily = Console.ReadLine();
            int dailyHoursStudied = Convert.ToInt32(hoursStudiedDaily);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
