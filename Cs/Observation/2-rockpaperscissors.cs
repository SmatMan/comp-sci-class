using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            string[] options = {"rock", "paper", "scissors"};
            int player1 = 0;

            Console.WriteLine("Welcome to Rock Paper Scissors.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Please choose rock, paper or scissors by typing it below:");

            string input = Console.ReadLine().ToLower();
            
            switch (input)
            {
                case "rock":
                    Console.WriteLine("You chose rock.");
                    player1 = 0;
                    break;
                case "paper":
                    Console.WriteLine("You chose paper.");
                    player1 = 1;
                    break;
                case "scissors":
                    Console.WriteLine("You chose scissors.");
                    player1 = 2;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    System.Environment.Exit(1);
                    break;
            }

            Random rnd = new Random();
            int computer = rnd.Next(0, 3);

            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("Rock.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Paper.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Scissors.");
            System.Threading.Thread.Sleep(1000);

            Console.WriteLine($"The computer chose {options[computer]}.");
            System.Threading.Thread.Sleep(1000);
            if (player1 == computer)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (player1 == 0 && computer == 2) // rock and scissors
            {
                Console.WriteLine("You win!");
            }
            else if (player1 == 1 && computer == 0) // paper and rock
            {
                Console.WriteLine("You win!");
            }
            else if (player1 == 2 && computer == 1) // scissors and paper
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }

        }
    }
}