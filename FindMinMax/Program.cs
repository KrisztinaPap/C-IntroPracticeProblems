using System;

namespace FindMinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            // Explains the program to the user and waits 
            // for them to continue
            Console.WriteLine("This program will prompt you for three (3) numbers. Then, it will display the lowest and highest values for you. Press enter when you are ready to start.");
            Console.ReadLine();
            
            // Prompts the user for the 3 integers
            Console.WriteLine("Please enter the first number:");
            int numberOne = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number:");
            int numberTwo = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the third number:");
            int numberThree = int.Parse(Console.ReadLine());

            // Determines lowest value
            int lower = Math.Min(numberOne, numberTwo);
            int lowest = Math.Min(lower, numberThree);

            // Determines highest value
            int higher = Math.Max(numberOne, numberTwo);
            int highest = Math.Max(higher, numberThree);

            // Displays lowest and highest values
            Console.WriteLine("The lowest value of the 3 numbers you entered is: " + lowest);
            Console.WriteLine("The highest value of the 3 numbers you entered is: " + highest);
            
            // Tells user how to quit program
            Console.WriteLine("Press enter to quit program...");

            // Waits for user input
            Console.ReadLine();
        }
    }
}
