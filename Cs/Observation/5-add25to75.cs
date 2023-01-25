using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 25; i <= 75; i++)
            {
                // Console.WriteLine(i);
                sum += i;
            }
            Console.WriteLine($"The sum of the integers between 25 and 75 is {sum} using a for loop.");
            sum = 0;
            int j = 25;
            while (j <= 75)
            {
                // Console.WriteLine(j);
                sum += j;
                j++;
            }
            Console.WriteLine($"The sum of the integers between 25 and 75 is {sum} using a while loop.");
            sum = 0;
            int k = 25;
            do
            {
                // Console.WriteLine(k);
                sum += k;
                k++;
            } while (k <= 75);
            Console.WriteLine($"The sum of the integers between 25 and 75 is {sum} using a do while loop.");
        }
    }
}
