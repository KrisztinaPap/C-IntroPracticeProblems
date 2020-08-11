using System;

namespace EnterMarks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring variables
            bool startAgain = true;
            string toQuit;
            string toQuitLower;

            // do-while loop wrap to enable user to re-run program
            do {

                // Explains what the program does
                Console.WriteLine("This program will allow you to enter up to 20 marks that must be integers between 0 and 100. If you are done entering data sooner, just enter -1 and it will start prompting you for more. At that time, it will display the class average, the highest mark, and the lowest mark.");

                // Declaring variables
                int myNumber;
                int numberOfMarks = 0;
                int myTotal = 0;
                int myAverage = 0;
                int lowestMark = 100;
                int highestMark = 0;  

                // do-while loop until either 20 mark limit is reached or the user enters -1
                do {
                    Console.WriteLine("Enter a mark (must be an integer between 0 and 100): ");
                    myNumber = int.Parse(Console.ReadLine());

                    if ( myNumber >= 0 && myNumber <= 100 )
                    {
                        numberOfMarks++;
                        myTotal += myNumber;
                        if ( lowestMark > myNumber )
                        {
                            lowestMark = myNumber;
                        }
                        if ( highestMark < myNumber )
                        {
                            highestMark = myNumber;
                        }
                    } 

                } while ( (numberOfMarks < 20) && (myNumber != -1) );

                // Calculate average mark
                myAverage = myTotal / numberOfMarks;
                
                // Displays results
                Console.WriteLine("The average mark is: " + myAverage);
                Console.WriteLine("Lowest mark: " + lowestMark);
                Console.WriteLine("Highest mark: " + highestMark);
                
                // Asks user if they want to start again
                Console.WriteLine("Type in yes and hit enter to continue or simply press enter to quit the program.");
                toQuit = Console.ReadLine();

                // To make the 'yes' case insensitive, we convert it to all lowercase letters
                toQuitLower = toQuit.ToLower();

                if ( toQuitLower == "yes" )
                {
                    startAgain = true;
                } 
                else
                {
                    startAgain = false;
                }

            } while ( startAgain == true );

        }
    }
}
