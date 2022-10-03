using System;
public class Program
{
    public static void Main(string[] args)
    {
        bool isAbove50(int num) {
            if (num > 50) {
                return(true);
            }
            else {
                return(false);
            }
        }
        Console.WriteLine("Input number: ");
        int num = Console.Read();
        if (isAbove50(num)) {
            Console.WriteLine("Number is above 50.");
        } else {
            Console.WriteLine("Number is not above 50.");
        }
        Thread.Sleep(1000);
    }
}