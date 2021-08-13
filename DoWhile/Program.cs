using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            Console.WriteLine("Enter any number to be print the table");
            int n = Convert.ToInt32(Console.ReadLine());

            do {
                Console.WriteLine("{0} * {1} = {2}", n, i, n * i);
                i++;
            }while(11 <= 10);
        }
    }
}
