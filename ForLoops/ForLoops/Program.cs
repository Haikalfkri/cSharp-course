using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // For Loop = repeats some code a FINITE amount of times

            /*
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            */

            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Close");

            Console.ReadKey();
        }
    }
}