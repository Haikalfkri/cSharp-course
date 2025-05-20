using System;

namespace TypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Type Casting Section

            // type casting = Converting a variable from one type to another
            //                Usefull when accept user input (string)
            //                Different data types can do different things

            double a = 3.14;
            int b = Convert.ToInt32(a);

            int c = 12;
            double d = Convert.ToDouble(c);

            int e = 321;
            string f = Convert.ToString(e);

            string g = "@";
            char h = Convert.ToChar(g);

            string i = "true";
            bool j = Convert.ToBoolean(i);

            Console.WriteLine(b.GetType());
            Console.WriteLine(d.GetType());
            Console.WriteLine(f);
            Console.WriteLine(h);
            Console.WriteLine(j.GetType());

            Console.ReadKey();
        }
    }
}