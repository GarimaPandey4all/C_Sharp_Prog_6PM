using System;

namespace AssignmentOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;

            a += 30; // a = a + 30; // shorthand
            a *= 50;
            a %= 100;
            a <<= 45;
        }
    }
}
