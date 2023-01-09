using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // calculate y= 1/x^2 + 2/x^3 + 3/x^4 + ... + n/x^(n+1) using while
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