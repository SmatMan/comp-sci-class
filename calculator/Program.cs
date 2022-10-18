using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int ?answer;
            
            Console.Write("First Number?");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Second Number?");
            int num2 = Int32.Parse(Console.ReadLine());

            Console.Write("Operator?");
            string op = Console.ReadLine();

            
            if (op == "+")
            {
                answer = num1 + num2;
            }
            else if (op == "-")
            {
                answer = num1 - num2;
            }
            else if (op == "*")
            {
                answer = num1 * num2;
            }
            else if (op == "/")
            {
                answer = num1 / num2;
            }
            else
            {
                Console.WriteLine("Invalid operator");
                answer = null;
            }
            
            Console.WriteLine($"{num1} {op} {num2} = {answer}");

        }
    }
}