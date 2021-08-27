using System;

namespace Function_2
{
    class Program
    {
        // 2. Function with arguments and without return type

        static void Sum(int a, int b) // Parameters / Formal Arguments
        {
            Console.WriteLine("Addition is: "+(a + b));
        }

        static void Main(string[] args)
        {
           Sum(10, 40); // Actual Arguments
        }
    }
}
