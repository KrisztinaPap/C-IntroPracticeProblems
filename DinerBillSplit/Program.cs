using System;

namespace DinerBillSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for total bill amount ('total') ($, double)
            Console.WriteLine("How much is the bill total in dollars? ");
            double total = double.Parse(Console.ReadLine());

            // Prompt user for number of diners ('diners')
            Console.WriteLine("How many people are splitting the bill? ");
            int diners = int.Parse(Console.ReadLine());

            // Calculate even shares: 'share' ('total' divided by 'diners')
            double share = total / diners;

            // Show equal share $ value

            Console.WriteLine("Each person should pay $" + share + " to be fair if splitting a $" + total + " bill between " + diners + " people.");

            // Let user know how to quit program
            Console.WriteLine("Press enter to quit...");

            // Wait for user to continue
            Console.ReadLine();
        }
    }
}
