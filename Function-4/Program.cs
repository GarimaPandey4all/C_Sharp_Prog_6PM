using System;

namespace Function_4
{
    class Program
    {
        static int Sum(int a, int b)
        {
            return (a + b);
        }

        static void Main(string[] args)
        {
            int result = Sum(20, 50);

            Console.WriteLine("Addition is: "+result);
        }
    }
}
