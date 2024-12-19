using static System.Net.Mime.MediaTypeNames;


namespace inputAssignment

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input whole number."); //Step 1. Ask the user for a number.
            string logUserInput = Console.ReadLine();
            Console.WriteLine(logUserInput);
            using (StreamWriter file = new StreamWriter(@"C:\Users\cordo\Desktop\Log\inputAssignment.txt"))
            {
                file.WriteLine(logUserInput + "\n");
            }
        }
    }
}
