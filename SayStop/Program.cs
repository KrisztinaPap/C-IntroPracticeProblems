using System;

namespace SayStop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring variables
            string userInput = "";
            string myString = "";

             // Explains what the program does
            Console.WriteLine("This program will keep saying \"Hello\" until the user enters \"stop\".");

            // Do-while loop to keep prompting user until they say "stop"
            do
            {

                // Prompts user for input
                Console.WriteLine("Hello! Say stop or I'll keep saying hello!");
                userInput = Console.ReadLine();
                // Converts user input to lowercase to ensure case insensitivity
                myString = userInput.ToLower();

            } while ( myString != "stop");

            // Tells user how to quit program
            Console.WriteLine("Fine... don't play... Press enter to quit program...");

            // Waits for user to continue
            Console.ReadLine();
        }
    }
}
