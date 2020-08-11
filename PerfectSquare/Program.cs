using System;

namespace PerfectSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            // Explains what the program does
            Console.WriteLine("This program prompts you for a number and tells you if it is the perfect square of a whole number.");

            // Prompts user for a number
            Console.WriteLine("Please enter a number: ");
            double myNumber = double.Parse(Console.ReadLine());

            // Calculates square root of the number
            double mySquareRoot = Math.Sqrt(myNumber);

            // Calculates whether number is even or odd and tells the user
            // Citation:
            //      https://social.msdn.microsoft.com/Forums/en-US/78379949-6445-423b-b133-5b17782f525a/c-how-to-check-is-integer
            //      The next line of code checks if the square root of the number equals its rounded form to zero decimals (<= is it a whole number)
            if ( mySquareRoot == Math.Round(mySquareRoot, 0) ) 
            { 
                Console.WriteLine("Your number is the perfect square of " + mySquareRoot + ", a whole number.");
            }
            else 
            { 
                Console.WriteLine("Your number is not the perfect square of any whole numbers.");
            }

            // Tells user how to quit program
            Console.WriteLine("Press enter to quit program...");

            // Waits for user to continue
            Console.ReadLine();
        }
    }
}
