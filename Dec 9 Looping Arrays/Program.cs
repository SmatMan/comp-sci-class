using System;

namespace SumArrayElements
{
    class Program
    {
        static void Mai2n(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6 };

            int sum = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                sum += myArray[i];
            }

            Console.WriteLine("The sum of the array elements is: " + sum);
        }
    }
    class Program2 {
        static void Main(string[] args)
        {
            double[] myArray = new double[5];
            double output;
            Console.WriteLine($"Input {myArray.Length} numbers:");
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = double.TryParse(Console.ReadLine(), out output) ? output : 0;
            }
            Console.WriteLine("\nThe numbers are:");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}