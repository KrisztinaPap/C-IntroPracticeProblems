using System;

namespace DigitSumCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompts user for a 4 digit number ('userNumber')
            Console.WriteLine("Enter 4 digit number: ");

            // Citation:
            //      https://www.w3schools.com/cs/cs_user_input.asp
            //      The following line converts user input into an integer and 
            //      saves it as the variable 'userNumber' 
            int userNumber = Convert.ToInt32(Console.ReadLine());

            // Calculates digits using place values         
            int thousands = userNumber / 1000;
            int newNumber1 = userNumber - thousands * 1000;
            int hundreds = newNumber1 / 100;
            int newNumber2 = newNumber1 - hundreds * 100;
            int tens = newNumber2 / 10;
            int newNumber3 = newNumber2 - tens * 10;
            int ones = newNumber3; 

            // Adds digits to get 'digitTotal'
            int digitTotal = thousands + hundreds + tens + ones;

            // Tells user 'digitTotal'
            Console.WriteLine("The total of digits is: " + digitTotal);

            // Tells user how to quit program
            Console.WriteLine("Press enter to quit program...");

            // Waits for user to continue
            Console.ReadLine();
        }
    }
}
