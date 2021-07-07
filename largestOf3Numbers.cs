using System;

namespace greatestOf3Numbers
{
    class largestOf3Numbers
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.Write("Enter first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            num3 = int.Parse(Console.ReadLine());

            if (num1>num2 && num1>num3)
            {
                Console.WriteLine("The largest number is: "+num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("The largest number is: " + num2);
            }
            else
            {
                Console.WriteLine("The largest number is: " + num3);
            }
        }
    }
}
