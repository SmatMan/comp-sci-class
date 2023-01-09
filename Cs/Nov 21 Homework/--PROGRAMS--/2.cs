using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //input 100 random integers sum using while
            int sum = 0;
            int i = 0;
            while (i < 100) {
                sum += Int32.Parse(Console.ReadLine());
                i++;
                Console.WriteLine(sum);
            }
        }
    }
}