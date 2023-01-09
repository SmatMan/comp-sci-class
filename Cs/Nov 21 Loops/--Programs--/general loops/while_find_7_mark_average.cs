using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int sum, i = 0, 1;
            int mark;
            double average;
            while (i < 7) {
                Console.WriteLine("Enter mark: ");
                mark = Convert.ToInt32(Console.ReadLine());
                sum = sum + mark;
                i = i + 1;
            }
            average = sum / 7;
            Console.WriteLine("Average mark is: " + average);
        }
    }
}