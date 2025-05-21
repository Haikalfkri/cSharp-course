using System;

namespace MathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Math Class

            double x = 3;
            double y = 10;

            // pow = power, s it raises x to the power of 2, which is x^2
            // double a = Math.Pow(x, 2);

            // sqrt = square root, it calculates the square root of x
            // double b = Math.Sqrt(x);

            // abs = absolute value, it returns the absolute value of x
            // double c = Math.Abs(x);

            // round = round, it rounds x to the nearest integer
            // double d = Math.Round(x);

            // ceiling = ceiling, it rounds x up to the nearest integer
            // double e = Math.Ceiling(x);

            // floor = floor, it rounds x down to the nearest integer
            // double f = Math.Floor(x);

            // max = maximum, it returns the maximum of x and y
            // double g = Math.max(x, y);

            // min = minimum, it returns the minimum of x and y
            double h = Math.Min(x, y);

            Console.WriteLine(h);

            Console.ReadKey();
        }
    }
}