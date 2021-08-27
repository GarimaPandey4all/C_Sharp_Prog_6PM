using System;

namespace Function_3
{
    class Program
    {
        // 3. Function without arguments and with return type

        static int Sum()
        {
            int a, b;

            Console.WriteLine("enter any value for a and b:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Addition is: "+(a + b));

            //return (a + b);
            return 0;
        }

        static void Main(string[] args)
        {
            Sum();

           // int result = Sum();

            //Console.WriteLine("Addition is: "+result);
        }
    }
}
