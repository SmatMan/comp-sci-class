using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num = 3;
            int total = 0;

            while (num <= 99)
            {
                Console.WriteLine(num);
                total += num;
                num = num + 2;
            }

            Console.WriteLine(total);
        }
    }
}
