using System;
using System.Diagnostics;

namespace CalculatorProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            // calculator program

            double num1 = 0;
            double num2 = 0;
            double result = 0;
            string operation = "";
            bool playAgain = true;

            while (playAgain)
            {
                string userInput = "";

                Console.WriteLine("------------------");
                Console.WriteLine("Calculator Program");
                Console.WriteLine("------------------");

                Console.Write("Enter first number: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter an option: ");
                Console.WriteLine("+ : Add");
                Console.WriteLine("- : Subtract");
                Console.WriteLine("* : Multiply");
                Console.WriteLine("/ : Divide");

                Console.Write("Choose an operation: ");
                operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result: {num1} + {num2} = {result}");
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result: {num1} - {num2} = {result}");
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result: {num1} * {num2} = {result}");
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your result: {num1} / {num2} = {result}");
                        break;
                }

                while (userInput != "yes" && userInput != "no")
                {
                    Console.Write("Do you want to play again? (yes/no): ");
                    userInput = Console.ReadLine().ToLower();

                    if (userInput == "yes")
                    {
                        playAgain = true;
                    }
                    else if (userInput == "no")
                    {
                        playAgain = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Try again!");
                    }
                }
            }

            Console.WriteLine("Thanks for playing!");
            
            Console.ReadKey();
        }
    }
}