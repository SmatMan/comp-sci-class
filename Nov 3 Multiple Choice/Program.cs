using System;

namespace ConsoleApp {
    public class Program
    {
        public class Question {
            public string ?question;
            public string[] ?choices;
            public string ?correctAnswer;
        };
        public static void Main(string[] args)
        {
            System.Console.Clear();
            Question[] questions = new Question[5];


            questions[0] = new Question();
            questions[0].question = "What language was this program written in?";
            questions[0].choices = new string[] { "C#", "C++", "Java", "Python" };
            questions[0].correctAnswer = "1";

            questions[1] = new Question();
            questions[1].question = "What is the name of the IDE used to write this program?";
            questions[1].choices = new string[] { "Visual Studio", "Visual Studio Code", "Visual Studio Express", "Visual Studio Community" };
            questions[1].correctAnswer = "2";

            questions[2] = new Question();
            questions[2].question = "What do you call the method that is used if an if statement is false?";
            questions[2].choices = new string[] { "else", "else if", "if", "if else" };
            questions[2].correctAnswer = "1";

            questions[3] = new Question();
            questions[3].question = "What is the name of the method that is used to print to the console?";
            questions[3].choices = new string[] { "print", "write", "WriteLine", "printLine" };
            questions[3].correctAnswer = "3";

            questions[4] = new Question();
            questions[4].question = "What is the name of the method that is used to read input from the console?";
            questions[4].choices = new string[] { "read", "readLine", "Read", "ReadLine" };
            questions[4].correctAnswer = "4";

            int score = 0;

            for (int i = 0; i < questions.Length; i++)
            {
                System.Console.Clear();
                Console.WriteLine($"\n{questions[i].question}");
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine($"{j+1} {questions[i].choices[j]}");
                }
                Console.Write("Enter your answer: ");
                string answer = Console.ReadLine();
                if (answer == questions[i].correctAnswer)
                {
                    Console.WriteLine("Correct!");
                    score++;
                } else {
                    Console.WriteLine("Incorrect!");
                }
                System.Threading.Thread.Sleep(2000);
            }

            Console.WriteLine($"Congrats! Your score is {score}/{questions.Length}");

    }
}
}