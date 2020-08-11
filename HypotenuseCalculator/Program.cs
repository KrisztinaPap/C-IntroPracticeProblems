using System;

namespace HypotenuseCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Explains program to user
            Console.WriteLine("This program takes in two sides of a right triangle and returns the length of the hypotenuse.");

            // Prompts user for side a
            Console.WriteLine("How long is side a?");
            double a = double.Parse(Console.ReadLine());

            // Prompts user for side b
            Console.WriteLine("How long is side a?");
            double b = double.Parse(Console.ReadLine());

            // Calculates hypotenuse
            double c = Math.Sqrt( (a * a) + ( b * b));

            // Citation:
            //      https://stackoverflow.com/questions/3212491/how-to-limit-a-decimal-number
            //      The below line of code rounds the variable c to 2 decimals and stores it in the result variable.
            // Formatting the result
            double result = Math.Round(c, 2);

            // Displays results
            Console.WriteLine("The hypotenuse is: " + result);

            // Tells user how to quit program
            Console.WriteLine("Press enter to quit program...");

            // Waits for user to continue
            Console.ReadLine();
        }
    }
}
