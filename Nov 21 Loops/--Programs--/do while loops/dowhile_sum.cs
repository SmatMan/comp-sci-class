using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double number, sum = 0.0;
            do {
                Console.WriteLine("Enter a number: ");
                number = Convert.ToDouble(Console.ReadLine());
                sum += number;
            } while (number != 0.0);
            Console.WriteLine("Sum = " + sum);
            }
        }
    }
}
