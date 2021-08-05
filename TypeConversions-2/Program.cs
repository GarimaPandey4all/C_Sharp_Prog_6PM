using System;

namespace TypeConversions_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Explicit Way - 2 of Type Conversions
/*
            1. Convert.ToBoolean
            2. Convert.ToDouble
            3. Convert.ToString
            4. Convert.ToInt32 - int - 4 bytes - 32 bits
            5. Convert.ToInt64 - long - 8 bytes - 64 bits
            */

            int a = 10;
            double d = 56.78;
            bool state = true;

            Console.WriteLine(Convert.ToString(a));  // int ot string
            Console.WriteLine(Convert.ToDouble(a)); // int to double
            Console.WriteLine(Convert.ToInt32(d)); // double to int
            Console.WriteLine(Convert.ToString(state));  // bool to string
        }
    }
}
