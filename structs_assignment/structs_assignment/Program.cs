namespace structs_assignment
{
    //Step 1. Create a struct called Number and give it the property “Amount” and have it be of data type decimal.
    struct Number //defines struct called number

    {
        //give it the property “Amount” and have it be of data type decimal.
        public decimal Amount;
        public Number(decimal amount) //constructor
        {
            Amount = amount;
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Step 2. In the Main() method, create an object of data type Number and assign an amount to it.
            Number number = new Number(100.95m);

            //Step 3. Print this amount to the console.
            Console.WriteLine("The amount is: " + number.Amount);


        }
    }
}
