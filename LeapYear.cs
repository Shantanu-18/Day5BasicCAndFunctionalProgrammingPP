using System;

namespace LeafYear
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter year in YYYY format:");
            year = int.Parse(Console.ReadLine());

            string yearstg = year.ToString();

            if (yearstg.Length != 4)
            {
                Console.WriteLine("you didn't enter 4 digit number.please re-enter:");
                year = int.Parse(Console.ReadLine());
            }

            
            int resultA;
            int resultB;
            int resultC;
            int A = Math.DivRem(year, 4, out resultA);
            int B = Math.DivRem(year, 100, out resultB);
            int C = Math.DivRem(year, 400, out resultC);
            

            if (resultB == 0 && resultC == 0)
            {
                Console.WriteLine(+year+" is Leap Year.");
            }
            else if (resultA==0)
            {
                Console.WriteLine(+year + " is Leap Year.");
            }
            else
            {
                Console.WriteLine(+year + " is Not a Leap Year.");
            }


        }
    }
}
