using System;

namespace LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // logical operators = Can be used to check if more than 1 condition is true/false

            // && = AND operator
            // || = OR operator
            // ! = NOT operator
            // ^ = XOR operator (exclusive OR)
            // & = AND operator (bitwise)
            // | = OR operator (bitwise)

            Console.WriteLine("What is the temperature?");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (temp >= 10 && temp <= 25)
            {
                Console.WriteLine("It's warm outside!");
            }
            else if (temp <= -50 || temp >= 50)
            {
                Console.WriteLine("Not Go Outside!");
            }
        }
    }
}