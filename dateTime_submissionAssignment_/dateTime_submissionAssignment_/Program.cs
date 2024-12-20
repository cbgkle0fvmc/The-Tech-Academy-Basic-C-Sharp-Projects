namespace dateTime_submissionAssignment_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); //Step 1. Prints the current date and time to the console.
            Console.WriteLine("Please input number."); //Step 2. Asks the user for a number.
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int hours)) //Step 3. Prints to the console the exact time it will
                                                        //be in X hours, X being the number the user entered in step 2.

            {
                DateTime futureTime = DateTime.Now.AddHours(hours);
                Console.WriteLine($"In {hours} hours, it will be: {futureTime}");
            }
            else
            {
                Console.WriteLine("You did not enter a valid number.");
            }
            Console.ReadLine();
            /**** Without Loop, input converted to int without parse method ****/
            Console.WriteLine("Please enter another number");
            int intUserInput = Convert.ToInt32(Console.ReadLine());

            DateTime futureTime2 = DateTime.Now.AddHours(intUserInput);
            Console.WriteLine($"In {intUserInput} hours, it will be: {futureTime2}");
            Console.ReadLine();
        }
    }
}
