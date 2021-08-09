using System;

namespace ArithmeticOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 30;

            Console.WriteLine("Addition is "+(a + b));
            Console.WriteLine("Subtraction is "+(a - b));
            Console.WriteLine("Division is "+(a / b));
            Console.WriteLine("Multiplication is "+(a * b));
            Console.WriteLine("Modulus is "+(a % b)); // 10 % 30 = 10
            Console.WriteLine("Pre-Increment is "+(++a));  // 10+1 = 11 = a
            Console.WriteLine("Post-Increment is "+(a++)); // 11
            //11 + 1 = 12 = a
            Console.WriteLine(a);
            Console.WriteLine("Pre-Decrement is "+(--b)); // 30 - 1 = 29 = b
            Console.WriteLine("Post-Decrement is "+(b--)); // 29
            //29 - 1 = 28 = b
            Console.WriteLine(b);
        }
    }
}
