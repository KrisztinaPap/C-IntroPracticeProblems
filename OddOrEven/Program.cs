using System;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            // Explains what the program does
            Console.WriteLine("This program prompts you for a number and tells you if it's odd or even.");

            // Prompts user for a number
            Console.WriteLine("Please enter a number: ");
            int myNumber = int.Parse(Console.ReadLine());

            // Calculates whether number is even or odd and tells the user
            if ( myNumber % 2 == 0 ) 
            { 
                Console.WriteLine("Your number is even.");
            }
            else 
            { 
                Console.WriteLine("Your number is odd.");
            }

            // Tells user how to quit program
            Console.WriteLine("Press enter to quit program...");

            // Waits for user to continue
            Console.ReadLine();
        }
    }
}
