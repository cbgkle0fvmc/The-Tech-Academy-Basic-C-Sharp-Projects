using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace IterateAnArrayAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Step 1. Create one dimensional array of strings
            string[] stringArray = {"window", "cloudy", "studying", "home", "holiday", "Thanksgiving"} ;

            //Array with matching strings
            string[] stringArray2 = { "window", "window", "cloudy", "studying", "home", "holiday", "Thanksgiving" };

            //Step 2. Ask user to input some text
            Console.WriteLine("Input text to be added to each string in array.");
            string userInputStringArray = Console.ReadLine();

            //Step 3. Loop to add user input to end of each string
            //do { ***CREATE INFINITE LOOP
                //Init counter at 0, loop until count is less than count of array, increase count by 1
                for (int i = 0; i < stringArray.Length; i++)
                {
                    //stringArray[i] references each index, is concatenated with user input
                    stringArray[i] = (stringArray[i] + userInputStringArray);
                }

                //Init counter at 0, loop until count is less than count of array, increase count by 1
                for (int i = 0; i < stringArray.Length; i++)
                {
                    //Writes index value to console
                    Console.WriteLine(stringArray[i]);
                }

                if (stringArray.Length <= 10)
                {
                Console.WriteLine("String array contains less than or equal to 10 indicies.");
                }

            //Ask user for input to search array and output like terms
            Console.WriteLine("Please enter text to search for matches in string array.");
            string userInputMatchText = Console.ReadLine();

            //Create loop to iterate through list and display items containing matching text
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i].Contains(userInputMatchText))
                {
                    Console.WriteLine(stringArray[i]);
                }
            }

            //Create loop to iterate through array, ask for user input, return results that match
            //If user input is not on list, output text to tell them not in array

            Console.WriteLine("Please enter text to search for matches in string array.");
            string userInputMatchText2 = Console.ReadLine();


            for (int i = 0; i < stringArray2.Length; i++)
            {
                if (stringArray2[i].Contains(userInputMatchText2) == false)
                {
                    Console.WriteLine("User input does not exist in array.");
                    break;
                }

                else if (stringArray2[i].Contains(userInputMatchText2))
                {
                    Console.WriteLine(stringArray2[i]);
                    //break;
                }

            }

            //Create a foreach loop that evaluates each item in the list and displays
            //a message showing the string and whether or not it has already appeared on the list 

           List <string> stringList = new List<string>();
            stringList.Add("House");
            stringList.Add("Dog");
            stringList.Add("Computer");
            stringList.Add("Prime Rib");
            stringList.Add("Turkey");
            stringList.Add("House");

            // Initialize a HashSet to track seen strings.
            HashSet<string> seenStrings = new HashSet<string>();

            // Loop through each string in the list.
            foreach (string str in stringList)
            {
                // Check if the string has already been seen.
                if (seenStrings.Contains(str))
                {
                    Console.WriteLine($"{str} - this item is a duplicate");
                }
                else
                {
                    Console.WriteLine($"{str} - this item is unique");
                    seenStrings.Add(str); // Mark the string as seen.
                }
            }

            //List <string> distinctstringlist = stringList.Distinct().ToList();
            //foreach (string str in stringList)
            //{

            //    Console.WriteLine(str);
            //}


            Console.ReadLine();
            //}
            //while (stringArray[] > stringArray.Length);
            //******END INFINITE LOOP*******//, NO BREAK STATEMENT, REMOVE DO WHILE LOOP





            ////Step 1. Create one dimensional array of strings
            //string[] stringArray = { "window", "cloudy", "studying", "home", "holiday", "Thanksgiving" };

                ////Step 2. Ask user to input some text
                //Console.WriteLine("Input text to be added to each string in array.");
                //string userInputStringArray = Console.ReadLine();



                ////Step 3. Loop to add user input to end of each string
                //foreach (string str in stringArray)
                //{
                //    string addUserInputToStringArray = (str + userInputStringArray);
                //    Console.WriteLine(addUserInputToStringArray);
                //}

        }
    }
}
