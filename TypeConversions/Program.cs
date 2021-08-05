using System;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Two types of type conversions/type casting

            1. Implicit conversions , automatically
                    - smaller type into a larger type
                e.g: char(2 bytes) to int (4 bytes)
            2. Explicit conversions , manually
                    - larger type into a smaller type
                e.g: double (8 bytes) to int (4 bytes)*/

            //Implicit Casting

            int a = 50;
            double d = a; // automatically

            Console.WriteLine(a);
            Console.WriteLine(d);
            
            //Explicit Casting

            double b = 56.78;
            int i = (int)b; // manually

            Console.WriteLine(b);
            Console.WriteLine(i);

        }
    }
}
