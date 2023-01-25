using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var starString = "";
            var loopNum = 5;

            for (var i = 0; i < 5; i++)
            {
                for (var j = 0; j < loopNum; j++)
                {
                    starString += "*";
                }
                Console.WriteLine(starString);
                starString = "";
                loopNum -= 1;
            }
        }
    }
}
