using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            string myOperator;
            int a;
            int b;
            int result;

            // Explains what the program does
            Console.WriteLine("This program takes in an operator and two numbers, and outputs the result.");

            // Prompts user for an operator
            Console.WriteLine("Enter an operator ( + or - or * or / ): ");
            myOperator = Console.ReadLine();

            // Prompts user for operand #1
            Console.WriteLine("Enter the first number: ");
            a = int.Parse(Console.ReadLine());

            // Prompts user for operand #2
            Console.WriteLine("Enter the second number: ");
            b = int.Parse(Console.ReadLine());

            // Complete calculation
            // Citation:
            //      https://codereview.stackexchange.com/questions/131158/simple-calculator-in-c
            //      The below block of code checks what operator the user input and calculates the 'result' variable's value.
            if (myOperator == "+")
            {
                result = a + b;
                Console.WriteLine(a + " + " + b + " = " + result);
            }
            else if (myOperator == "-")
            {
                result = a - b;
                Console.WriteLine(a + " - " + b + " = " + result);
            }
             else if (myOperator == "*")
            {
                result = a * b;
                Console.WriteLine(a + " * " + b + " = " + result);  
            }
             else if (myOperator == "/" && b == 0 )
            {
                Console.WriteLine("You cannot divide by 0, silly!");
                Console.WriteLine("Enter a new number to divide by: ");
                b = int.Parse(Console.ReadLine());
                result = a / b;
                Console.WriteLine(a + " / " + b + " = " + result);   
            }
              else if (myOperator == "/" && b != 0 )
            {
                result = a / b;
                Console.WriteLine(a + " / " + b + " = " + result);   
            }
            else
            {
               Console.WriteLine("One or more of your inputs were incorrect, sorry. Please try again!"); 
            }

            // Tells user how to quit program
            Console.WriteLine("Press enter to quit program...");

            // Waits for user to continue
            Console.ReadLine();
        }
    }
}
