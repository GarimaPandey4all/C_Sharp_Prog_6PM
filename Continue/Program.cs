using System;

namespace Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 10; i++)
            {
                if(i == 5) // true
                {   
                    i++; // i = 5 + 1 = 6
                    continue; // i = 6 = skip
                }

                Console.WriteLine(i);
            }
        }
    }
}
