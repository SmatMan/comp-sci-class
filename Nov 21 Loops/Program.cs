using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x,y;
            x = Int32.TryParse(Console.ReadLine(), out x) ? x : 0;
            y = Int32.TryParse(Console.ReadLine(), out y) ? y : 0;
            int result = 1;
            for (int i = 1; i <= y; i++) {
                result *= x;
            }
            Console.WriteLine(result);
        }
    }
}