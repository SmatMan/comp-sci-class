using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int ?answer;
            
            Console.Write("First Number?");
            int num1 = Int32.TryParse(Console.ReadLine(), out int tempNum1) ? tempNum1 : 0; // if num1 is not an int, set it to 0
            Console.Write("Second Number?");
            int num2 = Int32.TryParse(Console.ReadLine(), out int tempNum2) ? tempNum2 : 0; // if num2 is not an int, set it to 0

            Console.Write("Operator?");
            string ?op = Console.ReadLine();

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
            
            answer = answer.HasValue ? answer.Value : 0;
            Console.WriteLine($"{num1} {op} {num2} = {answer}");

        }
    }
}