using System;

namespace starting
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 5; 
            int numberTwo = 6;

            Console.WriteLine($"The sum of {numberOne} and {numberTwo} is {numberOne + numberTwo}.");
            Console.WriteLine($"The difference of {numberOne} and {numberTwo} is {numberOne - numberTwo}.");
            Console.WriteLine($"The product of {numberOne} and {numberTwo} is {numberOne * numberTwo}.");
            Console.WriteLine($"The quotient of {numberOne} and {numberTwo} is {numberOne / numberTwo}.");
            Console.WriteLine($"The modulus of {numberOne} and {numberTwo} is {numberOne % numberTwo}.");
        }
    }
}


