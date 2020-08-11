using System;

namespace WhatMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declares variables
            string monthCode;
            string myMonth;
            int myYear;

            // Explains what the program does
            Console.WriteLine("This program takes in a 3 character month code (case insensitive) and outputs the full name of the month and the number of days in that month.");

            // Prompts user for 3 character month code
            Console.WriteLine("Enter the 3 character month code ( i.e. Jan, Mar or Dec): ");
            monthCode = Console.ReadLine();

            // Converts user input into all uppercase
            myMonth = monthCode.ToUpper();

            // switch statement -> displays full name of month and number of days
            switch (myMonth)
            {
                case "JAN":
                    Console.WriteLine("Month: January");
                    Console.WriteLine("Number of days: 31");
                    break;
                case "FEB":
                    Console.WriteLine("Month: February");
                    // Citation:
                    //      https://www.tutorialspoint.com/csharp/nested_switch_statements_in_csharp.htm
                    //      The below block of code checks whether the February the user is referring to was a leap year.
                    Console.WriteLine("What year?");
                    myYear = int.Parse(Console.ReadLine());
                    // Citation:
                    //      https://docs.microsoft.com/en-us/dotnet/api/system.datetime.isleapyear?view=netcore-3.1
                    //      The below line uses the DateTime.IsLeapYear(Int32) Method to check if a year is a leap year.
                    if (DateTime.IsLeapYear(myYear))
                    {
                        Console.WriteLine("That's a leap year!");
                        Console.WriteLine("Number of days: 29");
                    }
                    else
                    {
                        Console.WriteLine("That's not a leap year.");
                        Console.WriteLine("Number of days: 28");
                    }
                    break;
                case "MAR":
                    Console.WriteLine("Month: March");
                    Console.WriteLine("Number of days: 31");
                    break;
                case "APR":
                    Console.WriteLine("Month: April");
                    Console.WriteLine("Number of days: 30");
                    break;
                case "MAY":
                    Console.WriteLine("Month: May");
                    Console.WriteLine("Number of days: 31");
                    break;
                case "JUN":
                    Console.WriteLine("Month: June");
                    Console.WriteLine("Number of days: 30");
                    break;
                case "JUL":
                    Console.WriteLine("Month: July");
                    Console.WriteLine("Number of days: 31");
                    break;
                case "AUG":
                    Console.WriteLine("Month: August");
                    Console.WriteLine("Number of days: 31");
                    break;
                case "SEP":
                    Console.WriteLine("Month: September");
                    Console.WriteLine("Number of days: 30");
                    break;
                case "OCT":
                    Console.WriteLine("Month: October");
                    Console.WriteLine("Number of days: 31");
                    break;
                case "NOV":
                    Console.WriteLine("Month: November");
                    Console.WriteLine("Number of days: 30");
                    break;
                case "DEC":
                    Console.WriteLine("Month: December");
                    Console.WriteLine("Number of days: 31");
                    break;                
                default:
                    Console.WriteLine("You didn't enter a valid month code. Please try again!");
                    break;
            }


            // Tells user how to quit program
            Console.WriteLine("Press enter to quit program...");

            // Waits for user to continue
            Console.ReadLine();
        }
    }
}
