using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 2;
            while (i <= 20)
            {
                Console.WriteLine(i);
                i += 2;
            }

            i=2;
            do
            {
                Console.WriteLine(i);
                i += 2;
            } while (i <= 20);

            for (i = 2; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
