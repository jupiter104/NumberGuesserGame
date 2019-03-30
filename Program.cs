using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();

            GreetUser();

            while (true)
            {
                Random random = new Random();
                int correctNumber = random.Next(1, 11);

                int guess = 0;

                Console.WriteLine("Guess a number between 1 to 10.");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "You may type a number only.");
                        continue;
                    }

                    guess = int.Parse(input);

                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "That's not correct. Try again!");
                    }
                }

                PrintColorMessage(ConsoleColor.Green, "You are right! That is the correct number!");

                Console.WriteLine("Play Again? (Y or N)");

                string answer = Console.ReadLine().ToUpper();

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

        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.1.0";
            string appAuthor = "Debashis";

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("{0} v{1} Edited by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
        }

        static void GreetUser()
        { 
            Console.WriteLine("What is your name?");
            string inputName = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}