using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = new int[100];
            int odd = 0;
            int even = 0;

            for (int i = 0; i < 100; i++)
            {
                Console.Write($"Input number {i + 1}: ");
                nums[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 100; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    Console.WriteLine($"Even number: {nums[i]}");
                    even++;
                }
                else
                {
                    odd++;
                }
            }

            Console.WriteLine($"Even numbers: {even}");
            Console.WriteLine($"Odd numbers: {odd}");
        }
    }
}
