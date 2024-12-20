namespace constructor_submissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string fName = ("Please enter your first name."); //Step 1. Create a const variable
            Console.WriteLine(fName);

            var lName = ("Please enter your last name.."); //Step 2. Create a variable using the keyword “var.”
            Console.Write(lName);

            twoConstructors person1 = new twoConstructors() { FName="Josh", Lname="Cordova"};

            Console.WriteLine(person1);

            Console.ReadLine();
        }
       

    }
    
}
