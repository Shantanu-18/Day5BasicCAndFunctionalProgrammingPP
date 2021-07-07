using System;

namespace evenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, answer;
            Console.Write("Enter number that you want to check: ");
            number = Convert.ToInt32(Console.ReadLine());


            answer = number % 2;

            if (answer == 0)
            {
                Console.WriteLine(+number+" is even number.");
            }
            else
            {
                Console.WriteLine(+number+" is odd number.");
            }
        }
    }
}
