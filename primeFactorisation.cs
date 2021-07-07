using System;

namespace primeFactorisation
{
    class primeFactorisation
    {
        static void Main(string[] args)
        {
             int i = 0;
             int num = 0;
             int factorial = 1;
                
            Console.Write("Enter the number: ");
            num = Convert.ToInt32(Console.ReadLine());


            for (i = 1; i <= num; i++)
            {
                factorial *= i;
                Console.Write("The Factorial of {0} is: {1}\n", num, factorial);
            }
        }

        
    }
    
}
