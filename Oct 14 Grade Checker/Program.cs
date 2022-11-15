using System;


namespace Oct14
{
    class Program
    {
        static void Main(string[] args)
        {
            int percentage;
            Console.Write("Enter the percentage: ");
            percentage = Convert.ToInt32(Console.ReadLine());

            if (percentage >= 90) {
                Console.WriteLine("The grade {0} is above 90 and below 100", percentage); 
                }
            else if (percentage >= 80) {
                Console.WriteLine("The grade {0} is above 80 and below 90", percentage); 
                }
            else if (percentage >= 70) {
                Console.WriteLine("The grade {0} is above 70 and below 80", percentage); 
                }
            else if (percentage >= 60) {
                Console.WriteLine("The grade {0} is above 60 and below 70", percentage); 
                }
            else if (percentage >= 50) {
                Console.WriteLine("The grade {0} is above 50 and below 60", percentage); 
                }
            else if (percentage >= 40) {
                Console.WriteLine("The grade {0} is above 40 and below 50", percentage); 
                }
            else if (percentage >= 30) {
                Console.WriteLine("The grade {0} is above 30 and below 40", percentage); 
                }
            else if (percentage >= 20) {
                Console.WriteLine("The grade {0} is above 20 and below 30", percentage); 
                }
            else if (percentage >= 10) {
                Console.WriteLine("The grade {0} is above 10 and below 20", percentage); 
                }
            else if (percentage >= 00) {
                Console.WriteLine("The grade {0} is above 0 and below 10", percentage); 
                }
            else {
                Console.WriteLine("The grade {0} is below 0", percentage); 
                }
        }
    }
}