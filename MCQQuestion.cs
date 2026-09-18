using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_2
{
    internal class MCQQuestion : Question
    {
        public MCQQuestion(string header, string body, double mark, Answer[] answers, Answer rightAnswer) : base(header, body, mark)
        {
            AnswerList = answers;
            RightAnswer = rightAnswer;
        }
        public override void DisplayQuestion()
        {
            Console.WriteLine(Header);
            Console.WriteLine(Body);

            foreach (Answer answer in AnswerList)
            {
                Console.WriteLine(answer);
            }
        }
    }
}
