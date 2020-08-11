using System;

namespace RandomPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Explains what program does
            Console.WriteLine("This program generates a 5 character long password consisting of uppercase letters. Press enter when you are ready.");

            // Waits for user to continue
            Console.ReadLine();

            // Generate first character 
            // Citation:
            //      https://www.asciitable.com/
            //      (ASCII code Dec 65 = A, 90 = Z)
            Random rng = new Random();
            int firstDigit = rng.Next(65, 91);

            // Convert random int into a char
            // Citation:
            //      https://www.codeproject.com/Questions/1252017/Converting-int-to-char-in-Csharp
            //      https://stackoverflow.com/questions/289792/int-to-char-in-c-sharp
            //      The next line of code converts the random number generated into an ASCII character

            char firstChar = (char)firstDigit;

            // Convert char into string
            // Citation:
            //      https://www.codeproject.com/Questions/1252017/Converting-int-to-char-in-Csharp
            //      The next line of code converts the char into a string

            string firstLetter = firstChar.ToString();

            // Generate second character 
            // Citation:
            //      https://www.asciitable.com/
            //      (ASCII code Dec 65 = A, 90 = Z)
            Random rng2 = new Random();
            int secondDigit = rng2.Next(65, 91);

            // Convert random int into a char
            // Citation:
            //      https://www.codeproject.com/Questions/1252017/Converting-int-to-char-in-Csharp
            //      https://stackoverflow.com/questions/289792/int-to-char-in-c-sharp
            //      The next line of code converts the random number generated into an ASCII character

            char secondChar = (char)secondDigit;

            // Convert char into string
            // Citation:
            //      https://www.codeproject.com/Questions/1252017/Converting-int-to-char-in-Csharp
            //      The next line of code converts the char into a string

            string secondLetter = secondChar.ToString();

            // Generate third character
            // Citation:
            //      https://www.asciitable.com/
            //      (ASCII code Dec 65 = A, 90 = Z)
            Random rng3 = new Random();
            int thirdDigit = rng3.Next(65, 91);

            // Convert random int into a char
            // Citation:
            //      https://www.codeproject.com/Questions/1252017/Converting-int-to-char-in-Csharp
            //      https://stackoverflow.com/questions/289792/int-to-char-in-c-sharp
            //      The next line of code converts the random number generated into an ASCII character

            char thirdChar = (char)thirdDigit;

            // Convert char into string
            // Citation:
            //      https://www.codeproject.com/Questions/1252017/Converting-int-to-char-in-Csharp
            //      The next line of code converts the char into a string

            string thirdLetter = thirdChar.ToString();

            // Generate fourth character
            // Citation:
            //      https://www.asciitable.com/
            //      (ASCII code Dec 65 = A, 90 = Z)
            Random rng4 = new Random();
            int fourthDigit = rng4.Next(65, 91);

            // Convert random int into a char
            // Citation:
            //      https://www.codeproject.com/Questions/1252017/Converting-int-to-char-in-Csharp
            //      https://stackoverflow.com/questions/289792/int-to-char-in-c-sharp
            //      The next line of code converts the random number generated into an ASCII character

            char fourthChar = (char)fourthDigit;

            // Convert char into string
            // Citation:
            //      https://www.codeproject.com/Questions/1252017/Converting-int-to-char-in-Csharp
            //      The next line of code converts the char into a string

            string fourthLetter = fourthChar.ToString();

            // Generate fifth character
            // Citation:
            //      https://www.asciitable.com/
            //      (ASCII code Dec 65 = A, 90 = Z)
            Random rng5 = new Random();
            int fifthDigit = rng5.Next(65, 91);

            // Convert random int into a char
            // Citation:
            //      https://www.codeproject.com/Questions/1252017/Converting-int-to-char-in-Csharp
            //      https://stackoverflow.com/questions/289792/int-to-char-in-c-sharp
            //      The next line of code converts the random number generated into an ASCII character

            char fifthChar = (char)fifthDigit;

            // Convert char into string
            // Citation:
            //      https://www.codeproject.com/Questions/1252017/Converting-int-to-char-in-Csharp
            //      The next line of code converts the char into a string

            string fifthLetter = fifthChar.ToString();

            // Generates password
           
            string newPassword = firstLetter + secondLetter + thirdLetter + fourthLetter + fifthLetter;

            // Displays password for user
            Console.WriteLine("Your random password is: " + newPassword);


            // Tells user how to quit program
            Console.WriteLine("Press enter to quit program...");

            // Waits for user to continue
            Console.ReadLine();
        }
    }
}
