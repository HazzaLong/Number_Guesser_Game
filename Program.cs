﻿using System;

// Namespace
namespace NumberGuess
{
    // Main class
    class MainClass
    {
        // Entry point Method
        static void Main(string[] args)
        {

            getAppInfo(); // Run GetAppInfo function to get info

            GreetUser(); // Ask for users name and greet

            while (true)
            {

                // Innit correct number
                //int correctNumber = 7;

                // Create a new random object
                Random random = new Random();

                // Innit correct number
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    // Make sure it is a number
                    if (!int.TryParse(input, out guess))
                    {

                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        // Keep going
                        continue;
                    }

                    // cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                       
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                // Print success message
                PrintColorMessage(ConsoleColor.Yellow, "Correct!! You guessed it");

                // Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {

                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        // Get and display app info
        static void getAppInfo()
        {
            // Set app vars
            string appName = "Number Guess";
            string appVersion = "1.0.0";
            string appAuthor = "Harry Long";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }

        // Ask users name and greet
        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user inputName
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Tell user it is not a number
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}
