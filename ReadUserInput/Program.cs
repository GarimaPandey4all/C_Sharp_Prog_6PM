using System;

namespace ReadUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Age");
            int age = Convert.ToInt32(Console.ReadLine()); // Console.ReadLine() - Read User Input

            Console.WriteLine("Your age is "+age);
        }
    }
}
