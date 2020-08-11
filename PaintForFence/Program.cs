using System;

namespace PaintForFence
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompts user for number of fence posts.
            Console.WriteLine("How many fence posts do you want to paint? ");
            int numberOfPosts = int.Parse(Console.ReadLine());

            // Calculates amount of paint needed (# of fence posts / 4)
            int amountOfPaint = numberOfPosts / 4;
            
            // Checks if there was a remainder after dividing the number of fence posts by 4. If so, it adds an extra bucket of paint to cover those.
            if ( (numberOfPosts % 4) != 0 )
            {
                amountOfPaint += 1;
            }

            // Display how much paint the user will need
            Console.WriteLine("You will need " + amountOfPaint + " bucket(s) of paint.");

            // Tells user how to quit program
            Console.WriteLine("To quit press enter...");

            // Waits for user input
            Console.ReadLine();
        }
    }
}
