using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring variables
            int startNumber = 0;
            int endNumber = 0;
            int numberOne = 0;
            int numberTwo = 0;
            int numberThree = 0;
            string wordOne = "wordOne";
            string wordTwo = "wordTwo";
            string wordThree = "wordThree";


            // Explains what the program does
            Console.WriteLine("This program counts from your desired starting number to your chosen ending number, replacing the numbers that are divisible by your 3 numbers of choice with 3 words of your choice.");

            // Prompts user for starting and ending numbers
            
            while ( startNumber <= 0 )
            {
                try
                {
                    Console.WriteLine("Enter your starting number: ");
                    startNumber = int.Parse(Console.ReadLine());
                    if ( startNumber <= 0 )
                        {
                            throw new Exception();
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Your starting number must be larger than 0. Try again");
                        endNumber = int.Parse(Console.ReadLine());
                    }
                    
            }

            // Prompts user for ending number (must be larger than starting number)
            // Aaron Barthel gave me the idea to wrap a try-catch block in a while loop

            while ( endNumber <= 0 || startNumber >= endNumber || (endNumber - startNumber) > 100 )
            {
                try
                {
                    Console.WriteLine("Enter your ending number (must be larger than starting number and the span between the two cannot be more than 100.): ");
                    endNumber = int.Parse(Console.ReadLine());
                    if ( endNumber <= 0 || endNumber <= startNumber )
                        {
                            throw new Exception();
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Your ending number must be larger than your starting number, and the span between the two cannot be more than 100. Try again");
                        endNumber = int.Parse(Console.ReadLine());
                    }
                    
            }
            
            // Prompts user for 3 numbers to replace

            // Prompts user for first number
           
            while ( numberOne < 2 )
            {
                // Aaron Barthel gave me the idea to wrap a try-catch block in a while loop
                try
                {
                Console.WriteLine("What number's duplicates do you want replaced? Enter your first number (must be an integer, 2 or larger): ");
                numberOne = int.Parse(Console.ReadLine());
                if ( numberOne < 2 )
                    {
                        throw new ArgumentException();
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Your number must be an integer, 2 or larger. Try again!");
                    numberOne = int.Parse(Console.ReadLine());
                }
            }
            
            // Prompts user for second number and keeps prompting until user enters a number that is not the same as the first one
           
            while ( numberTwo < 2 || numberTwo == numberOne )
            {
                // Aaron Barthel gave me the idea to wrap a try-catch block in a while loop
                try
                {
                Console.WriteLine("What number's duplicates do you want replaced? Enter your second number (must be an integer, 2 or larger, not the same as your first number): ");
                numberTwo = int.Parse(Console.ReadLine());
                if ( numberTwo == numberOne || numberTwo < 2 )
                    {
                        throw new ArgumentException();
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Your number must be an integer, 2 or larger, not the same as your first number. Try again!");
                    numberTwo = int.Parse(Console.ReadLine());
                }
            }

            // Prompts user for a third number and keeps prompting until a number is entered that is different from the first two

            while ( numberThree < 2 || numberThree == numberOne || numberThree == numberTwo )
            {
                // Aaron Barthel gave me the idea to wrap a try-catch block in a while loop
                try
                {
                    Console.WriteLine("What number's duplicates do you want replaced? Enter your third number (must be integer larger than 2, not the same as your first two numbers): ");
                    numberThree = int.Parse(Console.ReadLine());
                    if ( numberThree == numberOne || numberThree == numberTwo || numberThree < 2 )
                        {
                            throw new ArgumentException();
                        }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Your number must be an integer, 2 or larger, not the same as your first two numbers. Try again!");
                    numberThree = int.Parse(Console.ReadLine());
                }
            }

        

            // Prompts user for 3 words

            //Prompts user for first word and keeps prompting until they enter something

            while ( wordOne == "wordOne" || wordOne == "")
            {
                Console.WriteLine("Enter your first word: ");
                wordOne = Console.ReadLine();
                wordOne = wordOne.Trim();
            }         

            // Keeps prompting the user for a second word until they enter something that is not the same as wordOne
            while ( wordTwo == "wordTwo" || wordTwo == wordOne || wordTwo == "" )
            {
                // Aaron Barthel gave me the idea to wrap a try-catch block in a while loop
                try
                {
                    Console.WriteLine("Enter your second word: ");
                    wordTwo = Console.ReadLine();
                    wordTwo = wordTwo.Trim();
                    if ( wordTwo == wordOne || wordTwo == "" )
                    {
                        throw new ArgumentException();
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Try again! Enter your second word: ");
                    wordTwo = Console.ReadLine();
                }
            }
            
            // Keeps prompting the user for a third word until they enter something that is not the same as wordOne or wordTwo
            while ( wordThree == "wordThree" || wordThree == wordOne || wordThree == wordTwo || wordThree == "" )
            {
                // Aaron Barthel gave me the idea to wrap a try-catch block in a while loop
                try
                {
                Console.WriteLine("Enter your third word: ");
                wordThree = Console.ReadLine();
                wordThree = wordThree.Trim();

                if ( wordThree == wordTwo || wordThree == "wordThree" || wordThree == "" )
                    {
                        throw new ArgumentException();
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Try again! Enter your third word: ");
                    wordThree = Console.ReadLine();
                }
            } 

            // For loop to count
            for (int i = startNumber; i < endNumber +1; i++)
            {
                if ( i % numberOne == 0 ) 
                {
                    Console.WriteLine(wordOne);
                }
                else if ( i % numberTwo == 0 )
                {
                    Console.WriteLine(wordTwo);
                }
                else if ( i % numberThree == 0 )
                {
                    Console.WriteLine(wordThree);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            // Tells user how to quit program
            Console.WriteLine("Cool, right? Press enter to quit program...");

            // Waits for user to continue
            Console.ReadLine();
        }
    }
}
