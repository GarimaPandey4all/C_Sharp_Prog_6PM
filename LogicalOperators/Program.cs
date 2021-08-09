using System;

namespace LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 40;

            Console.WriteLine(a > 5 && b < 20); // And 
            Console.WriteLine(a > 5 || b < 20); // Or
            Console.WriteLine(!(a > 5 && b < 20)); // Not
        }
    }
}
