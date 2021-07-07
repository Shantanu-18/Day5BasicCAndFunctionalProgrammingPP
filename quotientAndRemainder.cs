using System;

namespace computeQuotientAndRemainder
{
    class computeQuotientAndRemainder
    {
        static void Main(string[] args)
        {
            int dividend, divisor, remainder, quotient;
            Console.WriteLine("Enter Dividend: ");
            dividend = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Divisor: ");
            divisor = int.Parse(Console.ReadLine());

            double r = Math.DivRem(dividend, divisor, out remainder);
            quotient = dividend / divisor;

            Console.WriteLine("Quotient = "+quotient);
            Console.WriteLine("Remainder = "+remainder);

        }
    }
}
