using System;

namespace vowelOrConsonant
{
    class Program
    {
        static void Main(string[] args)
        {
            char alphabet;
            Console.Write("Enter alphabet you want to check: ");
            alphabet = Convert.ToChar(Console.ReadLine());

            if (alphabet=='a' |alphabet== 'e' | alphabet=='i' | alphabet=='o' | alphabet=='u' |
                alphabet == 'A' | alphabet == 'E' | alphabet == 'I' | alphabet == 'O' | alphabet == 'U')
            {
                Console.WriteLine("It is a Vowel.");
            }
            else
            {
                Console.WriteLine("It is a Consonant.");
            }
        }
    }
}
