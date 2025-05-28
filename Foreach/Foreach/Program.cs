using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // foreach loop = a simpler way to iterate over an array, but it's less flexible

            string[] cars = { "BMW", "Lambo", "Mustang" };

            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}