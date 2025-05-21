using System;
using System.Diagnostics;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Switch Statement = A control statement that executes a block of code
            //                    among many alternatives

            Console.WriteLine("What day is today?");
            string day = Console.ReadLine().ToLower();

            switch(day)
            {
                case "monday":
                    Console.WriteLine("Today is Monday.");
                    break;
                case "tuesday":
                    Console.WriteLine("Today is Tuesday.");
                    break;
                case "wednesday":
                    Console.WriteLine("Today is Wednesday");
                    break;
                case "thursday":
                    Console.WriteLine("Today is Thursday");
                    break;
                case "friday":
                    Console.WriteLine("Today is Friday");
                    break;
                case "saturday":
                    Console.WriteLine("Today is Saturday");
                    break;
                case "sunday":
                    Console.WriteLine("Today is Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day entered.");
                    break;
            }

            Console.ReadKey();
        }
    }
}