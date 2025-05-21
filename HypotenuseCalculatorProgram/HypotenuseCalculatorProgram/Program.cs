using System;

namespace HypotenuseCalculatorProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hypotenuse Calculator!");

            Console.Write("Enter Side A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Side B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt((a * a) + (b * b));

            Console.WriteLine("The Hypotenuse is: " + c);

            Console.ReadKey();

        }
    }
}