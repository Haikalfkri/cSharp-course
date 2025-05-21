using System;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Random Numbers

            Random random = new Random();

            // Generate a random number between 1 and 6 (inclusive)
            // int num = random.Next(1, 7);

            // Generate a random number between 0.0 and 1.0 (exclusive)
            double num = random.NextDouble();

            Console.WriteLine(num);

            Console.ReadKey();
        }
    }
}