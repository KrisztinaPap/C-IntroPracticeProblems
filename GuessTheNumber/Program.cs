using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Explains what the program does
            Console.WriteLine("This game allows two players to guess a randomly generated number between 1 and 10. Press enter when you are ready to start.");

            // Waits for user to continue
            Console.ReadLine();

            // Prompts user 1 for guess
            Console.WriteLine("Player 1, enter your guess (a number between 1 and 10): ");
            int guessOne = int.Parse(Console.ReadLine());

            // Prompts user 2 for guess
            Console.WriteLine("Player 2, enter your guess (a number between 1 and 10): ");
            int guessTwo = int.Parse(Console.ReadLine());

            // Generates random number between 1 and 10
            Random rng = new Random();
            int randomNumber = rng.Next(1, 11);

            // Determines guesses' distance from random number by using absolute value
            int distOne = Math.Abs(randomNumber - guessOne);
            int distTwo = Math.Abs(randomNumber - guessTwo);

            // Determines the game outcome
            if ( guessOne == guessTwo ) {
                Console.WriteLine("The random number was: " + randomNumber);
                Console.WriteLine("You both guessed the same number. It's a draw!");
            }

            else if ( distOne == distTwo ) {
                Console.WriteLine("The random number was: " + randomNumber);
                Console.WriteLine("Both your guesses were " + distOne + " away from the random number. It's a draw!");
            }

            else if ( distOne < distTwo ) {
                Console.WriteLine("The random number was: " + randomNumber);
                Console.WriteLine("Player1 is the winner! Congratulations!");
            }

            else if ( distTwo < distOne ) {
                Console.WriteLine("The random number was: " + randomNumber);
                    Console.WriteLine("Player2 is the winner! Congratulations!");
            }

            else {
                Console.WriteLine("That was an invalid game. See you next time!");
            };

            // Tells user how to quit program
            Console.WriteLine("Press enter to quit program...");

            // Waits for user to continue
            Console.ReadLine();
        }
    }
}
