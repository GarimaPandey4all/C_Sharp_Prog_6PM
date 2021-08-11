using System;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 40, c = 70;

            if(a > b && a > c)
            {
                Console.WriteLine("A is Greater");
            }
            else if(b > c)
            {
                Console.WriteLine("B is Greater");
            }
            else {
                Console.WriteLine("C is Greater");
            }
        }
    }
}
