using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i < 6; i++) {
                for (int j = 0; j < i; j++) {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
