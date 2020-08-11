using System;

namespace EnterInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring variables
            int myNumber = 0;

            // Explains what the program does
            Console.WriteLine("This program prompts the user for an integer between 1 and 10 (inclusive) until one is entered.");

            // Prompts user for integer if 'myNumber' is larger than 10 or smaller than 1
            while ( ( myNumber > 10 ) || ( myNumber < 1 ))
            {
                Console.WriteLine("Please enter an integer between 1 and 10 (inclusive): ");
                
                try
                {
                    myNumber = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }

            // Thanks user after breaking the loop / entering proper value
            Console.WriteLine("Well done! Thank you!");

            // Tells user how to quit program
            Console.WriteLine("Press enter to quit program...");

            // Waits for user to continue
            Console.ReadLine();
        }
    }
}
