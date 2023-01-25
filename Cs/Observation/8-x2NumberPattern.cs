using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num = 1;

            do
            {
                Console.WriteLine(num);
                num = num * 2;
            } while (num <= 1024);
        }
    }
}
