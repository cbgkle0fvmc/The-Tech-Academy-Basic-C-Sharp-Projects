using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insuranceApprovalProject
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Insurance Appoval Project\n");
            Console.WriteLine("What is your age?"); //Ask for age input
            string applicantAge = Console.ReadLine(); // create variable string applicantAge, input in Console.ReadLine 
            int applicantAgeInt = Convert.ToInt32(applicantAge); //convert string applicantAge to Int

            Console.WriteLine("Have you ever had a DUI? true or false");
            string applicantDUI = Console.ReadLine(); // create variable string applicantDUI, input in Console.ReadLine
            bool applicantDUIBool = Convert.ToBoolean(applicantDUI); //convert string applicantDUI to Bool

            Console.WriteLine("How many speeding tickets do you have?"); 
            string applicantTickets = Console.ReadLine(); // create variable string applicantTickets, input in Console.ReadLine
            int applicantTicketsInt = Convert.ToInt32(applicantTickets); //convert string applicantTickets to Int

            //Applicant must be greater than age 15, ,must not have DUI, and have less than or equal to 3 tickets to be approved
            bool qualification = applicantAgeInt > 15 && applicantDUIBool == false && applicantTicketsInt <= 3;
            Console.WriteLine("Qualified?\n" + qualification);
            

            Console.ReadLine();
        }
    }
}
