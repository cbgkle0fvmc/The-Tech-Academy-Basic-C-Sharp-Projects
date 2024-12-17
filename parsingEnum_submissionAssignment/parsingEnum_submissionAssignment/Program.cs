using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace parsingEnum_submissionAssignment
{
    //Step 1. Create an enum for days of the week
    public enum daysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Step 2. Prompt the user to enter the current day of the week.
            Console.WriteLine("Please enter day of the week.");

            
            //Step 4. Wrap the above statement in a try/catch block and have it print
            //"Please enter an actual day of the week.” to the console if an error occurs.
            try
            {
                //Step 3. Assign the value to a variable of that enum data type you just created
                string userInputTodaysDay = Console.ReadLine();
                daysOfWeek currentDay = (daysOfWeek)Enum.Parse(typeof(daysOfWeek), userInputTodaysDay, true); //true makes input case sensitive
                //Enum.Parse(type,string)method: convert string to daysOfWeek enum int 

                Console.WriteLine($"You entered: {currentDay}");
            }
            catch (ArgumentException) 
            {
                ////
                Console.WriteLine("Please enter an actual day of the week.");
            }
        }
    }
}
