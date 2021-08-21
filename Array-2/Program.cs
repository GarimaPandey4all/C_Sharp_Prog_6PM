using System;
using System.Linq;

namespace Array_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1, 9, 12, 2, 0, 1, 18, 17, 100};

            Array.Sort(arr);

            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(arr.Max());
            Console.WriteLine(arr.Min());
            Console.WriteLine(arr.Sum());
        }
    }
}
