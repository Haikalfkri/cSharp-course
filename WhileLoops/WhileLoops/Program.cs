using System;


namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // while loops

            string name = "";
            string exit = "";

            while (exit != "exit")
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();

                Console.Write("Again? ");
                exit = Console.ReadLine();
            }

            Console.WriteLine("Hello " + name);

            Console.ReadKey();
        }
    }
}