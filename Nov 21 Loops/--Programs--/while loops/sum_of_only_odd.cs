using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i = 1;
            int num = Int32.TryParse(Console.ReadLine(), out num) ? num : 0;
            int sum = 0;
            while (num != -999) {
                if (num % 2 != 0) {
                    sum += num;
                }
                num = Int32.TryParse(Console.ReadLine(), out num) ? num : 0;

                Console.WriteLine($"Sum:{sum}");
            }
        }
    }
}