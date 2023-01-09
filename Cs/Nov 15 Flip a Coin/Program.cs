using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // var end = true;
            while(true) 
            {
                Console.Clear();
                Console.WriteLine("Welcome to CoinFlip!");
                
                Console.Write("Would you like to flip a coin? (y/n): ");
                string input = Console.ReadLine().ToLower();
                Console.Clear();

                if (input != "y")
                {
                    Console.Clear();
                    break;
                }
                Console.WriteLine("Flipping...");
                var rnd = new System.Random();
                int coin = rnd.Next(0, 2);
                string result = coin == 0 ? "heads" : "tails";
                System.Threading.Thread.Sleep(1500);
                Console.WriteLine($"You flipped {result}.");
                System.Threading.Thread.Sleep(3000);
            }
        }
        }
    }

