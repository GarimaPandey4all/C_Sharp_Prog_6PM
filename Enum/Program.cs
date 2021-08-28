using System;

namespace Enum
{
    class Program
    {
        //Enum: Enumeration is a predefined class in C#, that represents a group of constants.

        enum week {
            Monday = 1, // 0
            Tuesday, // 1
            Wednesday, // 2
            Thursday, // 3
            Friday, // 4
            Saturday, // 5
            Sunday // 6
        }

        static void Main(string[] args)
        {
            //var today = (week) 0;

            week today = week.Saturday;
            Console.WriteLine(today);

            int today2 = (int)week.Saturday;
            Console.WriteLine(today2);
        }
    }
}
