using System;
using System.Collections.Generic;

namespace Lab5.Models
{
    public class Lecture : Curriculum
    {
        private string date;
        private string group;
        private int amountOfStudents;
        public override int AverageAmountOfStudents(List<Lecture> lectures)
        {
            int counter=0;
            foreach (Lecture lecture in lectures)
            {
                counter += lecture.amountOfStudents;
            }

            counter /= lectures.Count;
            
            return counter;
        }

        public override string ToString()
        {
            return this.DepartmentName + "|" + this.CourseName + "|" + this.group + "|" + this.Date + "|" +
                   this.amountOfStudents;
        }

        public override int AmountOfWordsInDepartmentName(Lecture lecture)
        {
            string[] splittedName = lecture.DepartmentName.Split(" ");
            return splittedName.Length;
        }

        public override void LecturesWithTheBiggestAmountOfStudents(List<Lecture> lectures)
        {
            int maxAmount = lectures[0].amountOfStudents;
            foreach (Lecture lecture in lectures)
            {
                if (maxAmount < lecture.amountOfStudents)
                {
                    maxAmount = lecture.amountOfStudents;
                }
            }
            foreach (Lecture lecture in lectures)
            {
                if (maxAmount == lecture.amountOfStudents)
                {
                    Console.WriteLine(lecture);
                }
            }
            
        }

        public Lecture(string departmentName, string courseName, string group, string date, int amountOfStudents):base(courseName,departmentName)
        {
            this.group = group;
            this.date = date;
            this.amountOfStudents = amountOfStudents;
        }

        public string Date
        {
            get => date;
            set => date = value;
        }

        public int AmountOfStudents
        {
            get => amountOfStudents;
            set => amountOfStudents = value;
        }

        public string Group
        {
            get => group;
            set => group = value;
        }

        public Lecture(){}
    }
}