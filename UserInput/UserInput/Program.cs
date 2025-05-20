using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            // user input section

            Console.Write("Enter Your Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your name is " + name);
            Console.WriteLine("You age is " + age);

            Console.ReadKey();
        }
    }
}