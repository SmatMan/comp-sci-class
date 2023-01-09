using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i < 11; i++) {
                if (i % 2 != 0) {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}