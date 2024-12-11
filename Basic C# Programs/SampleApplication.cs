using System; //System is main namespace of the base class library in C#
            //Using is a keyword that tells the compiler that you’ll be utilizing the System library.

class SampleApplication { //class SampleApplication instructs the compiler that anything between 
                        //curly braces { } is part of the class named SampleApplication
    static void Main() { //Main() is a function that tells the compiler to execute anything 
                        //between the curly braces.

                        //static is a keyword used as a type of modifier for the Main() function. 
                        //It refers to itself rather than creating an instance of the class it’s modifying.
                        // It tells the compiler that this function can be called without relying on reference to an object. 
        Console.WriteLine("Hello, World!");
    }
}