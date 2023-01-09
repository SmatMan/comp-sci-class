using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i = 1;
            do {
                Console.WriteLine(i);
                i *= 2;
            } while (i < 1024);
            
        }
    }
}