using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // for loop
            int sum = 0;
            for (int i = 1; i <= 50; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
            // while loop
            sum = 0;
            int add = 0;
            while (add <= 50)
            {
                sum += add;
                add++;
            }
            Console.WriteLine(sum);
            // do while loop
            sum = 0;
            add = 0;
            do
            {
                sum += add;
                add++;
            } while (add <= 50);
            Console.WriteLine(sum);

        }
    }
}