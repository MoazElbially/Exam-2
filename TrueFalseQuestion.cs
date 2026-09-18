using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_2
{
    public class TrueFalseQuestion : Question
    {

        public TrueFalseQuestion(string header, string body, double mark, Answer[] answers, Answer rightAnswer) : base(header, body, mark)

        {

            {
                AnswerList = answers;
                RightAnswer = rightAnswer;
            }
            ;

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
