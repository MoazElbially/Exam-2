namespace Exam_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("       EXAMINATION SYSTEM");
            Console.WriteLine("=================================");

            Console.Write("Enter Subject ID: ");
            int subjectId = int.Parse(Console.ReadLine());

            Console.Write("Enter Subject Name: ");
            string subjectName = Console.ReadLine();


            Subject subject = new Subject(subjectId, subjectName);

            Console.WriteLine();
            Console.WriteLine("Choose Exam Type:");
            Console.WriteLine("1 - Final Exam");
            Console.WriteLine("2 - Practical Exam");

            Console.Write("Enter your choice: ");
            int examType = int.Parse(Console.ReadLine());

            Console.Write("Enter Exam Time: ");
            int time = int.Parse(Console.ReadLine());

            Console.Write("Enter Number Of Questions: ");
            int numberOfQuestions = int.Parse(Console.ReadLine());

            Exam exam;

            if (examType == 1)
            {
                exam = new FinalExam(time, numberOfQuestions);
            }
            else
            {
                exam = new PracticalExam(time, numberOfQuestions);
            }

            for (int i = 0; i < numberOfQuestions; i++)
            {
                Console.WriteLine();
                Console.WriteLine("=================================");
                Console.WriteLine($"       QUESTION {i + 1}");
                Console.WriteLine("=================================");

                Console.WriteLine("Choose Question Type:");
                Console.WriteLine("1 - True / False");
                Console.WriteLine("2 - MCQ");

                Console.Write("Enter Question Type: ");
                int questionType = int.Parse(Console.ReadLine());

                Console.Write("Enter Question Header: ");
                string header = Console.ReadLine();

                Console.Write("Enter Question Body: ");
                string body = Console.ReadLine();

                Console.Write("Enter Question Mark: ");
                double mark = double.Parse(Console.ReadLine());

                if (questionType == 1)
                {
                    Answer[] answers = new Answer[2];

                    answers[0] = new Answer(1, "True");
                    answers[1] = new Answer(2, "False");

                    Console.WriteLine();
                    Console.WriteLine("Choose Right Answer:");
                    Console.WriteLine("1 - True");
                    Console.WriteLine("2 - False");

                    Console.Write("Enter Right Answer ID: ");
                    int rightAnswerId = int.Parse(Console.ReadLine());

                    Answer rightAnswer = answers[rightAnswerId - 1];

                    exam.Questions[i] =
                        new TrueFalseQuestion(header, body, mark, answers, rightAnswer);
                }

                else if (questionType == 2)
                {
                    Answer[] answers = new Answer[4];

                    Console.WriteLine();
                    Console.WriteLine("Enter 4 Answers:");

                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write($"Answer {j + 1}: ");
                        string answerText = Console.ReadLine();

                        answers[j] =
                            new Answer(j + 1, answerText);
                    }

                    Console.Write("Enter Right Answer ID: ");
                    int rightAnswerId = int.Parse(Console.ReadLine());

                    Answer rightAnswer = answers[rightAnswerId - 1];

                    exam.Questions[i] = new MCQQuestion(header, body, mark, answers, rightAnswer);
                }
            }
            subject.CreateExam(exam);


            Console.WriteLine();
            Console.WriteLine("Press Enter to Start Exam...");
            Console.ReadLine();

            subject.Exam.ShowExam();

            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine("       ICloneable Demo");
            Console.WriteLine("=================================");

            Question originalQuestion = exam.Questions[0];

            Question clonedQuestion = (Question)originalQuestion.Clone();


            Console.WriteLine("Original Question:");
            Console.WriteLine(originalQuestion);

            Console.WriteLine();

            Console.WriteLine("Cloned Question:");
            Console.WriteLine(clonedQuestion);

            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine("       IComparable Demo");
            Console.WriteLine("=================================");

            if (exam.Questions.Length >= 2)
            {
                int result =
                    exam.Questions[0].CompareTo(exam.Questions[1]);

                if (result > 0)
                {
                    Console.WriteLine(
                        "Question 1 has a higher mark.");
                }
                else if (result < 0)
                {
                    Console.WriteLine(
                        "Question 2 has a higher mark.");
                }
                else
                {
                    Console.WriteLine(
                        "Both questions have the same mark.");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
