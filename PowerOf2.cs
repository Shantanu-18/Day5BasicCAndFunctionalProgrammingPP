using System;

namespace PowerOf2
{
    class PowerOf2
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Enter value of N:");
            N = int.Parse(Console.ReadLine());

            if (0 < N)
            {
                Console.WriteLine("Error. Value of N should be 0 <= N < 31");
            }



            else if (N < 31)
            {
                int i = 0;
                while (i <= N)
                {
                    i++;
                    double table = Math.Pow(2, i);
                    Console.WriteLine("2^N= " + table);
                }
            }

            
            else
            {
                Console.WriteLine("Error. Value of N should be 0 <= N < 31");
            }
        }
    }
}
