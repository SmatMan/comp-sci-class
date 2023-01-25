using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string pattern = "";

            for (var i = 0; i < 5; i++)
            {
                pattern += $"{i + 1} ";
                Console.WriteLine(pattern);
            }
        }
    }
}
