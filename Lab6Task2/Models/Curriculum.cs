using System;
using System.Collections.Generic;
using System.IO;

namespace Lab5.Models
{
    public abstract class Curriculum:IFile
    {
        private string courseName;
        private string departmentName;
        public abstract int AverageAmountOfStudents(List<Lecture> lectures);
        public abstract void LecturesWithTheBiggestAmountOfStudents(List<Lecture> lectures);
        public abstract int AmountOfWordsInDepartmentName(Lecture lecture);

        public string CourseName
        {
            get => courseName;
            set => courseName = value;
        }
        
        public Curriculum(string courseName, string departmentName)
        {
            this.courseName = courseName;
            this.departmentName = departmentName;
        }
        public string DepartmentName
        {
            get => departmentName;
            set => departmentName = value;
        }

        public void FileInformationRead(List<Lecture> lectures)
        {
            string reader;
            string[] stringArray;
            using (StreamReader streamReader=new StreamReader("Lectures.txt"))
            {
                while (streamReader.EndOfStream == false)
                {
                    reader = streamReader.ReadLine();
                    if (reader != ""&& reader != " ")
                    {
                        stringArray = reader.Split("|");
                        lectures.Add(new Lecture(stringArray[0], stringArray[1], stringArray[2],
                            stringArray[3], int.Parse(stringArray[4])));
                    } 
                } 
            } 
        }
        public void FileInformationWrite(List<Lecture> lectures)
        {
            using (StreamWriter studentInformationWriter=new StreamWriter("Lectures.txt"))
            {
                Console.WriteLine("Type department name: ");
                string departmentName = Console.ReadLine();
                Console.WriteLine("Type course name");
                string courseName = Console.ReadLine();
                Console.WriteLine("Type group name");
                string group = Console.ReadLine();
                Console.WriteLine("Type date of lecture");
                string date = Console.ReadLine();
                Console.WriteLine("Type amount of students present on lecture");
                int amountOfStudents = int.Parse(Console.ReadLine());
                Lecture lectureInformationToAdd=new Lecture(departmentName, courseName, group,
                    date,amountOfStudents);
                lectures.Add(lectureInformationToAdd);
                foreach (Lecture lecture in lectures)
                {
                    studentInformationWriter.WriteLine(lecture.ToString());
                }
            }
        }
        public void FileInformationEdit(List<Lecture> lectures)
        {
            for (int i = 0; i < lectures.Count; i++)
            {
                Console.WriteLine(i+1+"."+lectures[i]);
            }
            Console.WriteLine("Type the number of student you want to edit");
            int number = int.Parse(Console.ReadLine())-1;
            Console.WriteLine("Select action:");
            Console.WriteLine("1.Edit department name");
            Console.WriteLine("2.Edit course name");
            Console.WriteLine("3.Edit group");
            Console.WriteLine("4.Edit date");
            Console.WriteLine("5.Edit amount of students present");
            Console.WriteLine("6.Edit all parameters");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                {
                    Console.WriteLine("Type new department name");
                    lectures[number].DepartmentName=Console.ReadLine();
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Type new course name");
                    lectures[number].CourseName=Console.ReadLine();
                    break;
                }
                case 3:
                {
                    Console.WriteLine("Type new group");
                    lectures[number].Group=Console.ReadLine();
                    break;
                }
                case 4:
                {
                    Console.WriteLine("Type new date");
                    lectures[number].Date=Console.ReadLine();
                    break;
                }
                case 5:
                {
                    Console.WriteLine("Type new amount of students");
                    lectures[number].AmountOfStudents=int.Parse(Console.ReadLine());
                    break;
                }
                case 6:
                {
                    Console.WriteLine("Type new department name");
                    lectures[number].DepartmentName=Console.ReadLine();
                    Console.WriteLine("Type new course name");
                    lectures[number].CourseName=Console.ReadLine();
                    Console.WriteLine("Type new group");
                    lectures[number].Group=Console.ReadLine();
                    Console.WriteLine("Type new date");
                    lectures[number].Date=Console.ReadLine();
                    Console.WriteLine("Type new amount of students");
                    lectures[number].AmountOfStudents=int.Parse(Console.ReadLine());
                    break;
                }
                default:
                {
                    throw new ArgumentException("You typed the wrong symbol");
                }
            }
            File.WriteAllText("Lectures.txt",String.Empty);
            using (StreamWriter sw=new StreamWriter("Lectures.txt")){
            
                foreach (Lecture lecture in lectures)
                {
                    sw.WriteLine(lecture.ToString());
                }
            } }
        public void RemoveExistingInformation(List<Lecture> lectures)
        {
            for (int i = 0; i < lectures.Count; i++)
            {
                Console.WriteLine(i+1+"."+lectures[i]);
            }
            Console.WriteLine("Type the number of information you want to remove");
            int number = int.Parse(Console.ReadLine())-1;
            lectures.RemoveAt(number);
            File.WriteAllText("Lectures.txt",String.Empty);
            using (StreamWriter sw=new StreamWriter("Lectures.txt"))
            {
                foreach (Lecture informationUnit in lectures)
                {
                    sw.WriteLine(informationUnit.ToString());
                }
            }
        }

        public void ShowInformation(List <Lecture> lectures)
        {
            foreach (Lecture informationUnit in lectures)
            {
                Console.WriteLine(informationUnit.ToString());
            }
        }
        public Curriculum(){}
    }
}