using System.Linq.Expressions;

namespace lambda_submissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 2. In the Main() method, create a list of at least 10 employees.
            //At least two employees should have the first name “Joe”.

            //List from class Employee referred to as employee in program.cs, new list
            //new Employee structure is from constructor in Employee.cs line 16
            List<Employee> employees = new List<Employee>()
            {
                new Employee(1, "Joe", "Doe"),
                new Employee(2, "Jane", "Doe"),
                new Employee(3, "Mike", "Jones"),
                new Employee(4, "Daisy", "Hawk"),
                new Employee(5, "Lola", "Healer"),
                new Employee(6, "Lucy", "Aussie"),
                new Employee(7, "Jake", "Red"),
                new Employee(8, "Margaret", "Shepherd"),
                new Employee(9, "Zeus", "Weiller"),
                new Employee(10, "Joe", "Patron")

            };

            //Step 3. Using a foreach loop, create a new list of all employees with the first name “Joe”.
            //In your comparison statement, remember to reference the property of the object you are checking.\

            //new list of Employees named employeesNamedJoe, loop through each employee, if name == joe, add employee
            //to list, foreach loop below to print employeesnamedjoe 
            List<Employee> employeesNamedJoe = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FirstName=="Joe")
                {
                    employeesNamedJoe.Add(employee);
                }
            }

            Console.WriteLine("Employees named Joe: \n");

            foreach (Employee joe in employeesNamedJoe)
            {
                Console.WriteLine($"{joe.FirstName} {joe.LastName} (ID: {joe.Id})");
            }

            //Step 4. Perform the same action again, but this time with a lambda expression.

            List<Employee> employeesNamedJoe2 = employees.Where(e => e.FirstName == "Joe").ToList();

            Console.WriteLine("employees named joe via lambda expression: \n");
            foreach (Employee joe2 in employeesNamedJoe2)
            {
                Console.WriteLine($"{joe2.FirstName} {joe2.LastName} (ID: {joe2.Id})");
            }

            //Step 5. Using a lambda expression, make a list of all employees with an Id number greater than 5.
            Console.WriteLine("Employees with ID greater than 5: \n");
            List <Employee> idGreaterThan5 = employees.Where(e => e.Id > 5).ToList();
            foreach (Employee isGreaterThan5 in idGreaterThan5)
            {
                Console.WriteLine($"{isGreaterThan5.FirstName} {isGreaterThan5.LastName} (ID: {isGreaterThan5.Id})");
            }
  



        }
    }
}
