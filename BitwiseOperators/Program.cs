using System;

namespace BitwiseOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4, b = 5;

            Console.WriteLine(a & b);
            Console.WriteLine(a | b);
            Console.WriteLine(a ^ b);
            Console.WriteLine(a << 1);
            Console.WriteLine(a >> 1);
        }
    }
}
