using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_2
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
        public Answer()
        {
            AnswerId = 0;
            AnswerText = "";

        }
        public Answer(int answerId, string answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }
        public override string ToString()
        {
            return $"{AnswerId} {AnswerText}";
        }
    }
}
