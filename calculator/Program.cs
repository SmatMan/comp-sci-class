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

            switch (op) {
                case "+":
                    answer = num1 + num2;
                    break;
                case "-":
                    answer = num1 - num2;
                    break;
                case "*":
                    answer = num1 * num2;
                    break;
                case "/":
                    answer = num1 / num2;
                    break;
                case "%":
                    answer = num1 % num2;
                    break;
                default:
                    answer = null;
                    break;
            }
            
            Console.WriteLine($"{num1} {op} {num2} = {answer}");

        }
    }
}