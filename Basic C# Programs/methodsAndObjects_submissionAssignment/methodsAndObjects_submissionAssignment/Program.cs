using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsAndObjects_submissionAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            person personId = new person()
            {
                FirstName = "Zach",
                LastName = "Cordova"

            };
            personId.SayName();
            Console.ReadLine();
        }
    }
}
