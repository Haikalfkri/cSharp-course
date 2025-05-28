using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // array = a variable that can store multiple values

            // string[] cars = { "BMW", "Mustang", "Porsche" };

            string[] cars = new string[3]; // fixed size

            // get values of array
            //Console.WriteLine(cars.Length);
            //Console.WriteLine(cars[0]);
            //Console.WriteLine(cars[1]);
            //Console.WriteLine(cars[2]);

            // update array
            cars[0] = "Lambo";
            cars[1] = "Mustang";
            cars[2] = "Porsche";

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
         

            Console.ReadKey();
        }
    }
}