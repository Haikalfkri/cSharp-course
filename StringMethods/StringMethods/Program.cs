using System;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // String Methods

            string fullName = "John Doe";
            string phoneNumber = "123-456-7890";

            //fullName = fullName.ToUpper();
            //fullName = fullName.ToLower();
            //Console.Write(fullName);

            //phoneNumber = phoneNumber.Replace("-", "");
            //Console.WriteLine(phoneNumber);

            //string username = fullName.Insert(0, "@Mr.");
            //Console.WriteLine(username);

            //Console.WriteLine(fullName.Length);

            string firstName = fullName.Substring(0, 4);
            string lastName = fullName.Substring(5, 3);
            Console.WriteLine(firstName + " " + lastName); 

            Console.ReadKey();
        }
    }
}