using System;

namespace Pattern_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 5; i++)  // rows
            {
                for(int j = 1; j <= 5; j++) // cols
                {
                    //Console.Write("*");
                    //Console.Write(i);
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
