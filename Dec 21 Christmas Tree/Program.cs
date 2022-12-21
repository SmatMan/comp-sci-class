using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    if (j == 0 || j == 2 * i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("|");
                    }
                }
                Console.WriteLine();
            }

            
        }
    }
}
