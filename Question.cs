using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_2
{
    public abstract class Question : ICloneable, IComparable<Question>
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public double Mark { get; set; }

        public Answer[] AnswerList { get; set; }

        public Answer RightAnswer { get; set; }


        protected Question() : this("", "", 0)
        {
        }

        protected Question(string header, string body, double mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
            AnswerList = new Answer[0];
            RightAnswer = new Answer();
        }

        public abstract void DisplayQuestion();

        public object Clone()
        {
            return MemberwiseClone();
        }
        public int CompareTo(Question? other)
        {
            if (other == null)
                return 1;

            return Mark.CompareTo(other.Mark);
        }


        public override string ToString()
        {
            return $"{Header}: {Body} : Mark = {Mark}";
        }









    }
}
