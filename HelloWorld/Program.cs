using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks for the user's name
            Console.WriteLine("Please enter your name (and then press enter): ");

            // Stores user's input in the variable 'name'
            string userName = Console.ReadLine();

            // Greets the user 
            Console.WriteLine("Hello " + userName + "!");

            // Tells the user how to close the program
            Console.WriteLine("Press the enter key to close the program...");
        
            // Waits for key press before continuing
            Console.ReadLine();
        }
    }
}
