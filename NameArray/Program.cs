using System;
// Citation
//      https://www.youtube.com/watch?reload=9&v=RQ0JHMGiobo&feature=youtu.be
//      Need this Collection to be able to manipulate lists
using System.Collections.Generic;
// Citation
//      https://stackoverflow.com/questions/1206019/converting-string-to-title-case
//      Need this Collection to be able to use ToTitleCase()  

using System.Globalization;

namespace NameArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            int myOperator = 0;
            int howToDelete = 0;
            int indexToDelete;
            string nameToDelete = "";
            int howToUpdate = 0;
            int indexToUpdate;
            string nameToUpdate;
            string nameToUpdateWith = "";
            string newName = "";
            // Citation:
            //      https://www.youtube.com/watch?reload=9&v=RQ0JHMGiobo&feature=youtu.be
            //      The below line of code initializes an empty list
            List<string> names = new List<string> ();

            // Explains what the program does
            Console.WriteLine("This program allows the user to enter up to ten names, and display (output) and manipulate the list (insert, update, delete).");

            // Prompts the user for operation and continues to do so until they are done
            while ( Convert.ToInt32(myOperator) != 5 )
            {
    
                    // Prompts user for an operator and saves it in myOperator variable
                    Console.WriteLine("What would you like to do? (enter the corresponding number)");
                    Console.WriteLine("1. insert, 2. update, 3. delete, 4. output, 5. quit");
                    myOperator = Convert.ToInt32(Console.ReadLine());

                    // If user chooses 1 for insert

                    if ( Convert.ToInt32(myOperator) == 1 )
                    {
                        // User can only enter a new name if the list has room
                        if ( names.Count != 10 )
                        {
                            // Citation:
                            //      https://www.tutorialspoint.com/How-to-check-if-an-item-exists-in-a-Chash-list-collection
                            //      names.Contains(newName) checks if the user input already exists on our list
                            while ( newName == "" || newName.Contains(" ") || newName.Length < 2 || names.Contains(newName) == true )
                            {
                                // Aaron Barthel gave me the idea to wrap a try-catch block in a while loop
                                try
                                {
                                    Console.WriteLine("Enter the name you want to insert:");
                                    newName = Console.ReadLine();

                                    // Trims any whitespace from user entry
                                    newName = newName.Trim();
                                    
                                    // Citation:
                                    //      https://stackoverflow.com/questions/1206019/converting-string-to-title-case
                                    //      Code below uses ToTitleCase() - adds ToLower to also be able to handle all capital input
                                    TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                                    newName = textInfo.ToTitleCase(newName.ToLower());

                                    // Citation:
                                    //      https://www.tutorialspoint.com/How-to-check-if-an-item-exists-in-a-Chash-list-collection
                                    //      newName.Contains(newName) checks if the user input has whitespaces in it (if it's more than 1 word)
                                    if ( newName == "" || newName.Contains(" ") || newName.Length < 2 || names.Contains(newName) == true )
                                    {
                                        throw new ArgumentException();
                                    }
                                }
                                catch (ArgumentException)
                                {
                                    Console.WriteLine("Enter the name you want to insert:");
                                    newName = Console.ReadLine();

                                    // Trims any whitespace from user entry
                                    newName = newName.Trim();

                                    // Citation:
                                    //      https://stackoverflow.com/questions/1206019/converting-string-to-title-case
                                    //      Code below uses ToTitleCase() - adds ToLower to also be able to handle all capital input
                                    TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                                    newName = textInfo.ToTitleCase(newName.ToLower());
                                }

                            }
                        names.Add(newName);
                        Console.WriteLine("You have inserted " + newName + " into your list. This is item #" + names.Count);
                        }
                        // List is limited to 10 items (index 0-9)
                        else
                        {
                            Console.WriteLine("You can only have 10 names on your list!");
                        }
                 
                    }

                    // If user chooses 2 for update

                    else if ( Convert.ToInt32(myOperator) == 2 )
                    {
                        // Asks user whether they want to update by index or name

                        Console.WriteLine("Do you want to update by 1. index or 2. name? (enter the corresponding number)");
                        howToUpdate =  Convert.ToInt32(Console.ReadLine());

                        // If user chooses update by index number

                        if ( howToUpdate == 1 )
                        {
                            Console.WriteLine("What is the index number you want to update?");
                            indexToUpdate = Convert.ToInt32(Console.ReadLine());

                            // Citation:
                            //      https://www.tutorialspoint.com/How-to-check-if-an-item-exists-in-a-Chash-list-collection
                            //      names.Contains(newName) checks if the user input already exists on our list
                            while ( nameToUpdateWith == "" || nameToUpdateWith.Contains(" ") || nameToUpdateWith.Length < 2 || names.Contains(nameToUpdateWith) == true )
                            {
                                // Aaron Barthel gave me the idea to wrap a try-catch block in a while loop
                                try
                                {
                                    Console.WriteLine("What name do you want to update it with?");
                                    nameToUpdateWith = Console.ReadLine();

                                    // Trims any whitespace from user entry
                                    nameToUpdateWith = nameToUpdateWith.Trim();

                                    // Citation:
                                    //      https://stackoverflow.com/questions/1206019/converting-string-to-title-case
                                    //      Code below uses ToTitleCase() - adds ToLower to also be able to handle all capital input
                                    TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                                    nameToUpdateWith = textInfo.ToTitleCase(nameToUpdateWith.ToLower());

                                    // Citation:
                                    //      https://www.tutorialspoint.com/How-to-check-if-an-item-exists-in-a-Chash-list-collection
                                    //      newName.Contains(newName) checks if the user input has whitespaces in it (if it's more than 1 word)
                                    if ( nameToUpdateWith == "" || nameToUpdateWith.Contains(" ") || nameToUpdateWith.Length < 2 || names.Contains(nameToUpdateWith) == true )
                                    {
                                        throw new ArgumentException();
                                    }
                                }
                                catch (ArgumentException)
                                {
                                    Console.WriteLine("What name do you want to update it with?");
                                    nameToUpdateWith = Console.ReadLine();

                                    // Trims any whitespace from user entry
                                    nameToUpdateWith = nameToUpdateWith.Trim();

                                    // Citation:
                                    //      https://stackoverflow.com/questions/1206019/converting-string-to-title-case
                                    //      Code below uses ToTitleCase() - adds ToLower to also be able to handle all capital input
                                    TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                                    nameToUpdateWith = textInfo.ToTitleCase(nameToUpdateWith.ToLower());
                                }
                            }

                        names[indexToUpdate-1] = nameToUpdateWith;
                        Console.WriteLine("Done!");  
                        }

                        // If user chooses to update by name

                        else if ( howToUpdate == 2 )
                        {
                            Console.WriteLine("What name do you want to update?");
                            nameToUpdate = Console.ReadLine();

                            while ( nameToUpdateWith == "" || nameToUpdateWith.Contains(" ") || nameToUpdateWith.Length < 2 || names.Contains(nameToUpdateWith) == true )
                            {
                                // Aaron Barthel gave me the idea to wrap a try-catch block in a while loop
                                try
                                {
                                    Console.WriteLine("What name do you want to update it with?");
                                    nameToUpdateWith = Console.ReadLine();

                                    // Trims any whitespace from user entry
                                    nameToUpdateWith = nameToUpdateWith.Trim();

                                    // Citation:
                                    //      https://stackoverflow.com/questions/1206019/converting-string-to-title-case
                                    //      Code below uses ToTitleCase() - adds ToLower to also be able to handle all capital input
                                    TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                                    nameToUpdate = textInfo.ToTitleCase(nameToUpdate.ToLower());

                                    // Citation:
                                    //      https://stackoverflow.com/questions/1206019/converting-string-to-title-case
                                    //      Code below uses ToTitleCase() - adds ToLower to also be able to handle all capital input
                                    nameToUpdateWith = textInfo.ToTitleCase(nameToUpdateWith.ToLower());

                                     // Citation:
                                    //      https://www.tutorialspoint.com/How-to-check-if-an-item-exists-in-a-Chash-list-collection
                                    //      newName.Contains(newName) checks if the user input has whitespaces in it (if it's more than 1 word)
                                    if ( nameToUpdateWith == "" || nameToUpdateWith.Contains(" ") || nameToUpdateWith.Length < 2 || names.Contains(nameToUpdateWith) == true )
                                    {
                                        throw new ArgumentException();
                                    }
                                }
                                catch (ArgumentException)
                                {
                                    Console.WriteLine("What name do you want to update it with?");
                                    nameToUpdateWith = Console.ReadLine();

                                    // Trims any whitespace from user entry
                                    nameToUpdateWith = nameToUpdateWith.Trim();

                                    // Citation:
                                    //      https://stackoverflow.com/questions/1206019/converting-string-to-title-case
                                    //      Code below uses ToTitleCase() - adds ToLower to also be able to handle all capital input
                                    TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                                    nameToUpdateWith = textInfo.ToTitleCase(nameToUpdateWith.ToLower());
                                }
                            }

                            // Citation:
                            //      https://www.tutorialspoint.com/How-to-find-the-index-of-an-item-in-a-Chash-list-in-a-single-step
                            //      The bwlo line of code finds the index of the list item that contains the name the user entered (nameToUpdate)
                            indexToUpdate = names.FindIndex(a => a.Contains(nameToUpdate));

                            names[indexToUpdate] = nameToUpdateWith;
                            Console.WriteLine("Done!");
                        }
                    }

                    // If user wants to delete

                    else if ( Convert.ToInt32(myOperator) == 3 )
                    {

                        // Asks user whether they want to delete by index number or name

                        Console.WriteLine("Do you want to delete by 1. index or 2. name? (enter the corresponding number)");
                        howToDelete =  Convert.ToInt32(Console.ReadLine());

                        // If user chooses to delete by index number

                        if ( howToDelete == 1 )
                        {
                            Console.WriteLine("What is the index number of the name you want to delete?");
                            indexToDelete = Convert.ToInt32(Console.ReadLine());

                            names.RemoveAt (indexToDelete - 1);
                            Console.WriteLine("Done!");
                        }

                        // If user chooses to delete by name

                        else if ( howToDelete == 2 )
                        {
                            Console.WriteLine("What name do you want to delete?");
                            nameToDelete = Console.ReadLine();

                            // Citation:
                            //      https://stackoverflow.com/questions/1206019/converting-string-to-title-case
                            //      Code below uses ToTitleCase() - adds ToLower to also be able to handle all capital input
                            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                            nameToDelete = textInfo.ToTitleCase(nameToDelete.ToLower());

                            names.Remove (nameToDelete);
                            Console.WriteLine("Done!");
                        }

                        // If the user chooses anything but option 1 or 2

                        else 
                        {
                            Console.WriteLine("That's not a valid choice!");
                        }

                    }

                    // If the user chooses to display current list (output feature)

                    else if ( Convert.ToInt32(myOperator) == 4 )
                    {
                        for (int i = 0; i <= names.Count - 1; i++)
                        {
                            // (i+1) because user wants to see list starting at 1 not the default zero index
                            Console.WriteLine( (i+1) + ". " + names[i] );
                        }
                    }

                    // If user chooses to quit (they are done)

                    else if ( Convert.ToInt32(myOperator) == 5 )
                    {
                        Console.WriteLine("Thank you for using NameArray! Press enter to quit program."); 
                    }

                    // If user chooses anything but valid options (1-5)

                    else
                    {
                        Console.WriteLine("That was not one of your choices! Please try again!");
                    }
            }
            
            // Waits for user to continue
            Console.ReadLine();
        }
    }
}
