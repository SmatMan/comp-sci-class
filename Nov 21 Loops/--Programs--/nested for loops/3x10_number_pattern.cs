using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int width=10;
            int height=3;
            for (int i=1; i <= height; i++) {
                for (int j=1; j <= width; j++) {
                    Console.Write((i*j)+"\t");
                }
                Console.WriteLine();
            }
        }
    }
}