using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
            int num = 4;
            Console.WriteLine(num);
            num += 1;
            Console.WriteLine(num);
            num = ++num - 4;
            */

            int a = 5;
            int b = 6;
            int c = 4;

            Console.WriteLine(a++ - b / c++);
            Console.WriteLine(a++ + ++b * c);
            Console.WriteLine(c <= a%c);
        }
    }
}