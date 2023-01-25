using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = new int[100];
            int sum = 0;

            for (int i = 0; i < 100; i++)
            {
                Console.Write("Input number " + (i + 1) + ": ");
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            int num = 0;

            while (num < nums.Length)
            {
                sum += nums[num];
                num++;
            }

            Console.WriteLine("Sum of numbers: " + sum);
        }
    }
}
