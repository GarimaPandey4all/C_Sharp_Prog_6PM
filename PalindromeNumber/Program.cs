using System;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number:");
            int n = Convert.ToInt32(Console.ReadLine());

            int temp = n;

            int sum = 0;
            while(n > 0)
            {   // n = 121
                int r = n % 10; // 1, 2, 1
                sum = sum * 10 + r; // 1, 12, 121
                n = n / 10; // 12, 1, 0
            }

            n = temp;
            
            if(sum == n)
            {
                Console.WriteLine("Number is Palindrome");
            }
            else {
                Console.WriteLine("Number is not Palindrome");
            }
        }
    }
}
