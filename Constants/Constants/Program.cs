using System;

namespace Constants
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Constant Section");

            // Constants = immutable values which are known at compile time and do not change for the life
            //             of the program. Constants are declared using the const keyword.

            const double PI = 3.14; // constant declaration

            Console.WriteLine(PI);
            Console.ReadKey();
        }
    }
}