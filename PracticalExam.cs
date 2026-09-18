using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_2
{
    public class PracticalExam : Exam
    {

        public PracticalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions)

        {
        }

        public override void ShowExam()
        {
            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine("        PRACTICAL EXAM");
            Console.WriteLine("=================================");



            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Question {i + 1}");
                Console.WriteLine("---------------------------------");

                Questions[i].DisplayQuestion();

                Console.Write("Enter your answer ID: ");
                int userAnswerId = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine("       CORRECT ANSWERS");
            Console.WriteLine("=================================");

            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine($"Question {i + 1}: " + $"{Questions[i].RightAnswer.AnswerText}");

            }
            Console.WriteLine("=================================");

        }
    }
}
