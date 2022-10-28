using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num = Int32.TryParse(Console.ReadLine(), out int tempNum) ? tempNum : 0; 

            switch (num)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                case 3:
                    Console.WriteLine("Case 3");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }
    }
}
