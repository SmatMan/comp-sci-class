using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] names = { "John", "Mary", "Bob", "Sue" };

            Console.WriteLine("Who would you like to search for?");
            string input = Console.ReadLine();
            for (int i = 0; i < names.Length; i++) {
                if (names[i].ToString().ToLower() == input.ToLower()) {
                    Console.WriteLine($"{input} is in the {i+1}th place of the array.");
                }
            }
        }
    }
}