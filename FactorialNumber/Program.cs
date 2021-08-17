using System;

namespace FactorialNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = 1;

            Console.WriteLine("Enter any number:");
            int n = Convert.ToInt32(Console.ReadLine());

            //for(int i = n; i >= 1; i--)
            for(int i = 1; i <= n; i++)
            {
                temp = i * temp;
            }

            Console.WriteLine(temp);
        }
    }
}
