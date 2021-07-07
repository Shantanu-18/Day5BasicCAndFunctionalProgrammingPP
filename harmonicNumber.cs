using System;

namespace harmonicNumber
{
    class harmonicNumber
    {
        static void Main(string[] args)
        {
            int N,i;
            double sum=0;
            Console.WriteLine("Enter value of N:");
            N = int.Parse(Console.ReadLine());

            for (i = 1; i <= N; i++)
            {
                Console.Write("1/{0} + ", i);
                sum+= 1 / (float)i;
            }
            Console.Write("\nSum of Series upto {0} terms : {1} ", N, sum);

        }
    }
}
