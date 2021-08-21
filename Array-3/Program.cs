using System;

namespace Array_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            Console.WriteLine("Enter Values");
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Values in Array are");
            foreach(int i in numbers)
            {
                Console.Write(i+" ");
            }
            
        }
    }
}
