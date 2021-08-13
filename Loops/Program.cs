using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. for
            2. while
            3. do-while
            4. for each 
            */

            Console.WriteLine("Enter any number to be print the table");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", n, i, n * i);
            }
        }
    }
}
