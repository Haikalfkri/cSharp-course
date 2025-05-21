using System;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // if statements = conditional statements that execute a block of code if a
            //                 specified condition is true


            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 18) {
                Console.WriteLine("You are a minor.");
            }
            else if (age < 65)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a senior citizen.");

            }

        }
    }
}