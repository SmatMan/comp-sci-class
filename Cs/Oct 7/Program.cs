﻿using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int radius=5;
            const double pi = 3.141;
            double area = pi * radius * radius;

            int radius2=8;
            double area2 = pi * radius2 * radius2;

            Console.WriteLine($"The area of a circle with radius {radius} is {area}.");
            Console.WriteLine($"The area of a circle with radius {radius2} is {area2}.");

            double db1 = 1.8, db2 = 3.2;
            

        }
    }
}
