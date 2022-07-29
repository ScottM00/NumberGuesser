using System;

// Namespace
namespace NumberGuesser
{
    //Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo(); // Run GetAppInfo function
            GreetUser(); // Run GreetUser function

            while (true)
            {

                // Set correct number
                // int correctNumber = 7;

                // Create a new random object
                Random rand = new Random();

                int correctNumber = rand.Next(1, 10);

                // Initialize guess variable
                int guess = 0;

                // Ask for a number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    // Error check that input is a number
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColourMessage(ConsoleColor.Red, "Error! Please enter a nunber!"); // Print error message
                        continue;
                    }

                    // Cast input (string) as an integer and put into guess
                    guess = Int32.Parse(input);

                    // Check if guess is correct
                    if (guess != correctNumber)
                    {
                        PrintColourMessage(ConsoleColor.Yellow, "Wrong number, please try again"); // Print to user that guess is wrong
                    }
                }

                PrintColourMessage(ConsoleColor.Green, "You are correct! Well done!"); // Print success message
        
                // Ask to play again
                Console.WriteLine("Play again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                // Check input
                if (answer == "Y")
                {
                    continue;
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

        // Outputs application information
        static void GetAppInfo()
        {
            // Initialize Variables 
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Scott MacLachlan";

            // Change console text colour
            Console.ForegroundColor = ConsoleColor.Green;

            // Print application Info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text colour
            Console.ResetColor();
        }

        // Asks users name and greet
        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name?");

            // Get users input
            string nameInput = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game.", nameInput);
        }

        // Prints a message of a set colour then resets colour
        static void PrintColourMessage(ConsoleColor color, string message)
        {
            // Change console text colour
            Console.ForegroundColor = color;

            // Print error message
            Console.WriteLine(message);

            // Reset text colour
            Console.ResetColor();
        }
    }
} 