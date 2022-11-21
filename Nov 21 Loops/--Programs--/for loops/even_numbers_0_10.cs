using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 11; i++) {
                if (i % 2 == 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}