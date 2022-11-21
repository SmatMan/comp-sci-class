using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 100 random numbers input, count odd even using for loop
            int odd = 0;
            int even = 0;
            for (int i = 0; i < 100; i++) {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0) {
                    even++;
                } else {
                    odd++;
                }
                Console.WriteLine($"Odd:{odd} Even:{even}");
            }

        }
    }
}