using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x, n;
            x = Int32.TryParse(Console.ReadLine(), out x) ? x : 0;
            n = Int32.TryParse(Console.ReadLine(), out n) ? n : 0;
            int i = 1;
            double sum = 0;
            while (i <= n) {
                sum += i / Math.Pow(x, i + 1);
                i++;
            }
            Console.WriteLine(sum);
        }
    }
}