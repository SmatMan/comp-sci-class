using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 != 0) {
                    sum += i;
                }
            }
            Console.WriteLine($"The sum of the first 50 only odd integers is {sum} using a for loop.");
            sum = 0;
            int j = 1;
            while (j <= 50)
            {
                if (j % 2 != 0) {
                    sum += j;
                }
                j++;
            }
            Console.WriteLine($"The sum of the first 50 only odd integers is {sum} using a while loop.");
            sum = 0;
            int k = 1;
            do
            {
                if (k % 2 != 0) {
                    sum += k;
                }
                k++;
            } while (k <= 50);
            Console.WriteLine($"The sum of the first 50 only odd integers is {sum} using a do while loop.");
        }
    }
}
