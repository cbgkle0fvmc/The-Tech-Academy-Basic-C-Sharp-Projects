using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "This is string 1 which will be concatenated with string 2. "; //create string 1
            string str2 = "This is string 2, which will be concatenated after string 1. "; //create string 2
            string str3 = "This is string 3, which will be concatenated after string 2."; //create string 3
            string concatStr = str1 + str2 + str3; //concatenate strings 1, 2 and 3
            StringBuilder editString = new StringBuilder(); //Create instance of String Builder named editString

            string str1toUpper = str1.ToUpper(); //Print str1 in uppercase
            
            Console.WriteLine(concatStr); //Print concatenated string in console
            Console.WriteLine(str1toUpper ); //Print str1 in uppercase
            editString.Append("This is a stringBuilder String."); //Write value to editString String Builder
            Console.WriteLine(editString); //Print editString String Builder

            Console.ReadLine();
        }
    }
}
