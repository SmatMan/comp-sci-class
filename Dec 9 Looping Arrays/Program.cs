using System;

namespace SumArrayElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[6] { 1, 2, 3, 4, 5, 6 };

            int sum = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                sum += myArray[i];
            }

            Console.WriteLine("The sum of the array elements is: " + sum);
        }
    }
}