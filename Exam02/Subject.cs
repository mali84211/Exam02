﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class Subject
    {

        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam SubjectExam { get; set; }


        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        public void CreateExam()
        {
            int ExamType, Time, NumOfQuestions;
            do
            {
                Console.Write("Please choose the type of the EXam [1 for Practical, 2 for Final] :  ");
            } while (!int.TryParse(Console.ReadLine(), out ExamType) || ExamType < 1 || ExamType > 2);

            do
            {
                Console.Write("Please Enter the time of the Exam in minutes (From 30 Min To 180 Min) :  ");
            } while (!int.TryParse(Console.ReadLine(), out Time) || Time < 30 || Time > 180);

            do
            {
                Console.Write("Please Enter Number of questions :  ");
            } while (!int.TryParse(Console.ReadLine(), out NumOfQuestions));


            if (ExamType == 1)
                SubjectExam = new PracticalExam(Time, NumOfQuestions);
            else
                SubjectExam = new FinalExam(Time, NumOfQuestions);

            Console.Clear();

            SubjectExam.CreateListOfQuestions();


        }
    }
}
