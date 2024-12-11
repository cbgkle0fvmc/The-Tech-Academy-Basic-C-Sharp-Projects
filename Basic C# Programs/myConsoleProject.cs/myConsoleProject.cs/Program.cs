using System;
using System.Collections.Generic; //Namespace containing interfaces and classes
                                  //That define various collections of objects
                                  // (Lists, arrays, dictionaries, etc)

using System.Linq; //Lanuage Integrated Query 
                   //With LINQ, you could quickly find the first person named “Jesse”
                   //in a set (a Collection) of names. 

using System.Text; //Enables easy way to manipulate text

using System.Threading.Tasks; //Enables CPU to do more than one thing at a time

namespace myConsoleProject.cs
{
    internal class Program //main class in console program, starts application
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine(); //instead of printing to the screen,
                                              //it takes input from the screen
            Console.WriteLine("Hello, " + name + "!");
            Console.Read();
        }
    }
}
