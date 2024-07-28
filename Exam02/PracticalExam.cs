using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class PracticalExam : Exam
    {

        public PracticalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions)
        {
        }

        public override void CreateListOfQuestions()
        {
            ListOfQuestions = new MCQQuestion[NumberOfQuestions];
            for (int i = 0; i < ListOfQuestions?.Length; i++)
            {
                ListOfQuestions[i] = new MCQQuestion();
                ListOfQuestions[i].AddQuestion();
                Console.Clear();
            }
        }


        public override void ShowExam()
        {

            foreach (var Question in ListOfQuestions)
            {

                Console.WriteLine(Question);


                for (int i = 0; i < Question.AnswerList?.Length; i++)
                    Console.WriteLine(Question.AnswerList[i]);
                Console.WriteLine("---------------------------");


                int UserAnswerId;
                do
                {
                    Console.WriteLine("Please Enter Number of your answer : ");
                } while (!int.TryParse(Console.ReadLine(), out UserAnswerId) && UserAnswerId < 1 || UserAnswerId > 3);

                Question.UserAnswer.AnswerId = UserAnswerId;
                Question.UserAnswer.AnswerText = Question.AnswerList[UserAnswerId - 1].AnswerText;
                Console.WriteLine("*********************************************************** \n");
            }
            Console.Clear();



            Console.WriteLine("Right Answers: \n");
            for (int i = 0; i < ListOfQuestions?.Length; i++)
            {
                Console.WriteLine($"Question ({i + 1}) : {ListOfQuestions[i].Body}");
                Console.WriteLine($"Right Answer => {ListOfQuestions[i].RightAnswer.AnswerText}");
                Console.WriteLine("-----------------------------------------------------------");
            }

        }
    }

}
