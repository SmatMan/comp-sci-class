using System;

namespace ConsoleApp
{
    public class Units {
        public static (double, string, string) fttom(double feet) {
            return (feet * 0.3048, "ft", "m");
        }
        public static (double, string, string) mtoft(double meters) {
            return (meters * 3.28084, "m", "ft"); 
        }
        public static (double, string, string) mitokm(double miles) {
            return (miles * 1.60934, "mi", "km");
        }
        public static (double, string, string) kmtomi(double kilometers) {
            return (kilometers * 0.621371, "km", "mi");
        }
        public static (double, string, string) lbstokg(double pounds) {
            return (pounds * 0.453592, "lb", "kg");
        }
        public static (double, string, string) kgtolbs(double kilograms) {
            return (kilograms * 2.20462, "kg", "lb");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            double input, unit;
            var output = (0.0, "", "");
            Console.WriteLine("Welcome to the Unit Converter!");
            Console.WriteLine("What unit would you like to convert?");
            Console.WriteLine("1. Feet to Meters");
            Console.WriteLine("2. Meters to Feet");
            Console.WriteLine("3. Miles to Kilometers");
            Console.WriteLine("4. Kilometers to Miles");
            Console.WriteLine("5. Pounds to Kilograms");
            Console.WriteLine("6. Kilograms to Pounds");
            Console.WriteLine("7. Quit");
            unit = double.TryParse(Console.ReadLine(), out unit) ? unit : 0;

            Console.WriteLine("Enter a value to convert:");
            input = double.TryParse(Console.ReadLine(), out input) ? input : 0;

            switch (unit) {
                case 1:
                    output = Units.fttom(input);
                    break;
                case 2:
                    output = Units.mtoft(input);
                    break;
                case 3:
                    output = Units.mitokm(input);
                    break;
                case 4:
                    output = Units.kmtomi(input);
                    break;
                case 5:
                    output = Units.lbstokg(input);
                    break;
                case 6:
                    output = Units.kgtolbs(input);
                    break;
                case 7:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    System.Environment.Exit(1);
                    break;


            }
            Console.WriteLine($"{input}{output.Item2} to {output.Item3} is {output.Item1}.");

        }
    }
}