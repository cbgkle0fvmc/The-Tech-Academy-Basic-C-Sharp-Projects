using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymousIncomeComparison
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program\n");
            Console.WriteLine("Person 1 : What is your hourly rate?");
            string person1HourlyRate = Console.ReadLine();
            int person1HourlyRateInt = Convert.ToInt32(person1HourlyRate);
            Console.WriteLine("Person 1: How many hours did you work this week?");
            string person1HoursWorked = Console.ReadLine();
            int person1HoursWorkedInt = Convert.ToInt32(person1HoursWorked);

            Console.WriteLine("Anonymous Income Comparison Program\n");
            Console.WriteLine("Person 2 : What is your hourly rate?");
            string person2HourlyRate = Console.ReadLine();
            int person2HourlyRateInt = Convert.ToInt32(person2HourlyRate);
            Console.WriteLine("Person 2: How many hours did you work this week?");
            string person2HoursWorked = Console.ReadLine();
            int person2HoursWorkedInt = Convert.ToInt32(person2HoursWorked);

            decimal person1Salary = person1HourlyRateInt * person1HoursWorkedInt * 52;
            decimal person2Salary = person2HourlyRateInt * person2HoursWorkedInt * 52;
            Console.WriteLine("Person 1 salary= " + person1Salary.ToString());
            Console.WriteLine("Person 2 salary= " + person2Salary.ToString());

            Console.WriteLine("Does person 1 make more money than person 2?");
            bool salaryComparison = person1Salary > person2Salary;
            Console.WriteLine(salaryComparison);

            Console.ReadLine();
        }
    }
}
