using System;

namespace DecisionMakingStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            if else
            if else if else
            ternary operator, shorthand of if else or if else if else
            switch
            */

            //Even - odd

            int n = 47;

            /*
            if(n % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else { //  sometimes else is optional
                Console.WriteLine("Number is Odd");
            }*/

            //Ternary - 3 Operator

            String result = (n % 2 == 0) ? "Number is Even" : "Number is Odd";

            Console.WriteLine(result);

        }
    }
}
