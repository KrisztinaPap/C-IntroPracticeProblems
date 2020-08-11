using System;

namespace BirthYearCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user for their age ('userAge')
            Console.WriteLine("How old are you?");
            int userAge = int.Parse(Console.ReadLine());

            // Subtract age from current year ('birthYear')
            int birthYear = 2020 - userAge;

            // Give user 'birthYear'
            Console.WriteLine("You were born in " + birthYear + "!");

            // Tell user how to quit program
            Console.WriteLine("Press enter to quit program...");

            // Wait for user to continue
            Console.ReadLine();
        }
    }
}
