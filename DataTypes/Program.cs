using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            char ch = 'A';
            float c = 35.67f;
            double d = 37.87;
            string name = "Brain";
            bool state = true; // bool - boolean : true or false

/*
            Console.WriteLine(a);
            Console.WriteLine(ch);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(name);
            Console.WriteLine(state);*/

            //Console.WriteLine("{0} {4} {5} {1} {2} {3}", a, ch, c, d, name, state);

            Console.WriteLine("Int = {0} Char = {1} Float = {2} Double = {3} String = {4} Bool = {5}", a, ch, c, d, name, state);
        }
    }
}
