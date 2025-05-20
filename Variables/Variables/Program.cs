using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Variables Section");

            int x; // declaration
            x = 12; // initialization

            int y = 21; // declaration + initialization

            int age = 21; // int -> whole integer
            double height = 1.75; // double -> decimal number
            bool isStudent = true; // bool -> true/false
            string name = "John Doe"; // string -> text
            char initiel = 'J'; // char -> single character with single quotes

            Console.WriteLine(name + " age is " + age);
            Console.WriteLine(name + " height is " + height + "m");
            Console.WriteLine("are " + name + " is student? " + isStudent);
            Console.WriteLine("initial of " + name + " is " + initiel);
        }
    }
}