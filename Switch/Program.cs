using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            // Switch - Menu Driven Programs        

            Console.WriteLine("Press 1. Addition");
            Console.WriteLine("Press 2. Logical And Operator");
            Console.WriteLine("Press 3. Bitwise X-OR");
            Console.WriteLine("Press 4. Swap Numbers");
            Console.WriteLine("Enter your choice");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Console.WriteLine("Enter value for a:");
                    a = Convert.ToInt32(Console.ReadLine());
                    
                    Console.WriteLine("Enter value for b:");
                    b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Addition is: "+(a + b));
                    break;

                case 2:
                    Console.WriteLine("Enter value for a:");
                    a = Convert.ToInt32(Console.ReadLine());
                    
                    Console.WriteLine("Enter value for b:");
                    b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Logical And Operator is: "+(a > 10 && b < 30));
                    break;

                case 3:
                    Console.WriteLine("Enter value for a:");
                    a = Convert.ToInt32(Console.ReadLine());
                    
                    Console.WriteLine("Enter value for b:");
                    b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("X-OR is: "+(a ^ b));
                    break;

                case 4:
                    Console.WriteLine("Enter value for a:");
                    a = Convert.ToInt32(Console.ReadLine());
                    
                    Console.WriteLine("Enter value for b:");
                    b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(a +" "+ b);

                    int temp = a;
                    a = b;
                    b = temp;

                    Console.WriteLine(a +" "+ b);                   
                    break;

                default:
                Console.WriteLine("Invalid Choice");
                break;
            }

            //Console.WriteLine("Outside the Switch Block");

        }
    }
}
