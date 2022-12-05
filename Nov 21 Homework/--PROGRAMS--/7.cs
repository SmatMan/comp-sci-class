using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // calculate y= 1/x^2 + 2/x^3 + 3/x^4 + ... + n/x^(n+1) using while
            int x, n; //defines ints
            x = Int32.TryParse(Console.ReadLine(), out x) ? x : 0; // gets value of x from user and tries to turn it into an integer; 2
            n = Int32.TryParse(Console.ReadLine(), out n) ? n : 0; // gets value of n from user and tries to turn it into an integer; 4
            int i = 1; // defines iterator
            double sum = 0; // defines sum
            while (i <= n) { //while i is less than or equal to n
                sum += i / Math.Pow(x, i + 1); // increase sum by i divided by x to the power of i+1; sum = 2/x^3
                i++; //increase i by 1 
            }
            Console.WriteLine(sum); // output the sum
        }
    }
}
