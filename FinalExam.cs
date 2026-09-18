using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_2
{
    public class FinalExam : Exam
    {
        public FinalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions)

        {
        }
        public override void ShowExam()
        {
            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine("FINAL EXAM");
            Console.WriteLine("=================================");


            double grade = 0;


            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Question {i + 1}:");
                Console.WriteLine("-------------------------");

                Questions[i].DisplayQuestion();

                Console.Write("Enter your answer ID: ");
                int userAnswerId = int.Parse(Console.ReadLine());

                if (userAnswerId == Questions[i].RightAnswer.AnswerId)
                {
                    grade += Questions[i].Mark;
                }
            }
            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine("          EXAM RESULT");
            Console.WriteLine("=================================");

            Console.WriteLine($"Your Grade = {grade}");
            Console.WriteLine($"Total Grade = {GetTotalGrade()}");

            Console.WriteLine("=================================");
        }

        private double GetTotalGrade()
        {
            double total = 0;

            foreach (Question question in Questions)
            {
                total += question.Mark;
            }

            return total;
        }

    }
}
