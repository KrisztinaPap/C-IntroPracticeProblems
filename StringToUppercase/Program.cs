using System;

namespace StringToUppercase
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompts the user for some text and saves it as a string variable
            Console.WriteLine("Enter the text you wish to convert to all uppercase: (press enter when done)");
            string myText = Console.ReadLine();

            // Converts 'myText' to uppercase and displays it
            // Citation:
            //      https://www.w3schools.com/cs/cs_strings.asp
            //      The below line displays the user's text after applying the 'ToUpper' method to it
            Console.WriteLine(myText.ToUpper()); 

            // Tells user how to quit program
            Console.WriteLine("Press enter to quit program...");

            // Waits for user input
            Console.ReadLine();
        }
    }
}
