using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = new int[5];
            nums[0] = 1;
            nums[1] = 2;
            nums[2] = 3; 
            nums[3] = 4; 
            nums[4] = 5;

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}