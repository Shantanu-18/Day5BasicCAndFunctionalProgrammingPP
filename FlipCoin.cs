using System;

namespace FlipCoin
{
    public class FlipCoin
    {
        static void Main(string[] args)
        {
            int numberOfTimes;
            Console.WriteLine("Enter number of time you want to flip the coin :");
            numberOfTimes = int.Parse(Console.ReadLine());
            
            int numberOfItration = 0;
            int numberOfHeads = 0;
            int numberOfTails = 0;
            while (numberOfItration <= numberOfTimes)
            {
                numberOfItration++;
                Random random = new Random();
                double coinFlip = random.NextDouble();
                //Console.WriteLine("Check"+coinFlip);
                

                if (coinFlip<0.5)
                {
                    Console.WriteLine("You got Tails.");
                    numberOfTails++;
                }
                else
                {
                    Console.WriteLine("You got Heads.");
                    numberOfHeads++;
                }

            }
            double percentOfHeads = numberOfHeads * 100 / numberOfTimes;
            Console.WriteLine("Percentage of Heads is " + percentOfHeads + "%");
            double percetOfTails = 100 - percentOfHeads;
            Console.WriteLine("Percentage of Tails is " + percetOfTails + "%");
        }
    }
}
