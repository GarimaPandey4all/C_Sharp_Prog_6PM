using System;

namespace _2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] matrix1 = new int[2, 2];
            int [,] matrix2 = new int[2, 2];
            int [,] result = new int[2, 2];

            Console.WriteLine("Enter any values in Matrix-1");
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            
            Console.WriteLine("Enter any values in Matrix-2");
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            Console.WriteLine("Addition:");
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.Write(result[i, j]+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
