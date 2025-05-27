using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // number guessing game
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            string response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                number = random.Next(min, max + 1);
                response = "";

                while (guess != number)
                {
                    Console.Write("Guess a number between " + min + " - " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("You guessed: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine("Your guess is too high, Try Again!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine("Your guess is too low, Try Again!");
                    }
                    guesses++;
                }

                Console.WriteLine("Number: " + number);
                Console.WriteLine("You guess is correct!");
                Console.WriteLine("Your guesses: " + guesses);

                Console.Write("Do you want to play again? (Yes/No): ");
                response = Console.ReadLine().ToLower();

                if (response == "yes" )
                {
                    playAgain = true;
                }
                else if (response == "no" )
                {
                    playAgain = false;
                }
            }

            Console.WriteLine();

            Console.WriteLine("Thanks for playing!");


            Console.ReadKey();
        }
    }
}