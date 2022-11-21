using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 4x8 star pattern
            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < 8; j++) {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}