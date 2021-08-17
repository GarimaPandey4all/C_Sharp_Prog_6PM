using System;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number:");
            int n = Convert.ToInt32(Console.ReadLine());

            int n1 = 0, n2 = 1;

            Console.Write("Fibonacci Series of {0} is: {1} {2}", n, n1, n2);
            for(int i = 2; i < n; i++)
            {
                int n3 = n1 + n2;
                Console.Write(" "+n3);
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
