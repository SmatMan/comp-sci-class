using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int max = -1;
            int i = 1;
            do {
                Console.WriteLine("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                i++;
                if (num > max) {
                    max = num;
                }
            } while (i < 100);
            Console.WriteLine("The max is: " + max);
        }
    }
}