using System;


namespace RockPaperScissorsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // rock paper scissors game

            Random random = new Random();
            bool playAgain = true;
            string playAgainInput;
            string player;
            string computer;

            while (playAgain)
            {
                player = "";
                computer = "";
                playAgainInput = "";

                while ( player != "ROCK" && player != "PAPER" && player != "SCISSORS" )
                {
                    Console.Write("Enter ROCK, PAPER, or SCISSORS: ");
                    player = Console.ReadLine().ToUpper();
                }

                // generate a random number between 1 and 3
                int randomNumber = random.Next(1, 4);
                // assign computer's choice based on the random number
                switch (randomNumber)
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }

                Console.WriteLine("Player choose: " + player);
                Console.WriteLine("Computer choose: " + computer);

                // check who wins
                if (player == computer)
                {
                    Console.WriteLine("It's a tie!");
                }
                else if (player == "ROCK" && computer == "SCISSORS" || 
                         player == "PAPER" && computer == "ROCK" ||
                         player == "SCISSORS" && computer == "PAPER")
                {
                    Console.WriteLine("Player wins!");
                }
                else
                {
                    Console.WriteLine("Computer wins!");
                }

                // ask the player if they want to play again
                while (playAgainInput != "yes" && playAgainInput != "no")
                {
                    Console.Write("Do you want to play again? (yes/no): ");
                    playAgainInput = Console.ReadLine().ToLower();
                    

                    if (playAgainInput == "yes")
                    {
                        playAgain = true;
                    }
                    else if ( playAgainInput == "no")
                    {
                        playAgain = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter 'yes' or 'no'");
                    }
                }
            }

            Console.WriteLine("Thank for playing!");

            Console.ReadKey();
        }
    }
}