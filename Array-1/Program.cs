using System;

namespace Array_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array: It is a collection of similar types of data. It contains multiple values in single variable.

            int[] marks = {10, 20, 30, 40, 50};

            Console.WriteLine(marks[0]);
            Console.WriteLine(marks[1]);
            Console.WriteLine(marks[2]);
            Console.WriteLine(marks[4]);

            for(int i = 0; i < marks.Length; i++)
            {
                Console.Write(marks[i] + " ");
            }

            Console.WriteLine("\n" +marks.Length);


        }
    }
}
