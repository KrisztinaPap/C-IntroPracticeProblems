using System;

namespace CubeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for a number
            Console.WriteLine("Hello User! Pick a whole number (then press enter): ");

            // Output the cube of that number
            int myNumber = int.Parse(Console.ReadLine());

            // Calculate cube of chosen number
            int myCube = myNumber * myNumber * myNumber;

            // Give user the results
            Console.WriteLine("The cube of " + myNumber + " is: " + myCube);
            
            // Tell user how to quit program
            Console.WriteLine("To quit press enter...");

            // Wait for user input
            Console.ReadLine();
        }
    }
}
