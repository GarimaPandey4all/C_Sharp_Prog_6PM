using System;

namespace VariableAndConstant
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10; // Declaration/Create and Initialization/Assignment/Definition

            int c = a + 30;

            Console.WriteLine(c);

            c = 60;

            Console.WriteLine(c);

            const float pi = 3.14f; // const : constant : fixed value, value can't be changed

            pi = 56.7f;

            Console.WriteLine(pi);
        }
    }
}
