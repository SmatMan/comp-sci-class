// random number guessing game
using System;

namespace starting
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 11);
            int guess = 0;
            int count = 0;
            while (guess != number)
            {
                Console.Write("Guess my number: ");
                guess = Convert.ToInt32(Console.ReadLine());
                count++;
            }
            Console.WriteLine($"You guessed it in {count} tries.");
        }
    }
}


