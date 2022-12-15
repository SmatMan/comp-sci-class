using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // for loop
            int sum = 0;
            for (int i = 25; i <= 75; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);

            // while loop
            sum = 0;
            int add = 25;
            while (add <= 75)
            {
                sum += add;
                add++;
            }
            Console.WriteLine(sum);
            // do while loop
            sum = 0;
            add = 25;
            do
            {
                sum += add;
                add++;
            } while (add <= 75);
            Console.WriteLine(sum);

        }
    }
}