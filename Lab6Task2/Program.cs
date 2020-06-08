using System;
using System.Collections.Generic;
using System.IO;
using Lab5.Models;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Lecture control = new Lecture();
            List<Lecture> lectures = new List<Lecture>();
            control.FileInformationRead(lectures);
            sign:
            Console.WriteLine("1.Add a new information");
            Console.WriteLine("2.Edit existing information");
            Console.WriteLine("3.Destroy existing information");
            Console.WriteLine("4.Show the existing information");
            Console.WriteLine("5.Show average value of amount of student on lectures");
            Console.WriteLine("6.Show amount of words in department name");
            Console.WriteLine("7.Show lectures with the biggest amount of students");
            Console.WriteLine("8.Exit");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                {
                    control.FileInformationWrite(lectures);
                    goto sign;
                }
                case 2:
                {
                    control.FileInformationEdit(lectures);
                    goto sign;
                }
                case 3:
                {
                    control.RemoveExistingInformation(lectures);
                    goto sign;
                }
                case 4:
                {
                    control.ShowInformation(lectures);
                    Console.ReadLine();
                    goto sign;
                }
                case 5:
                {
                    Console.WriteLine(control.AverageAmountOfStudents(lectures) +
                                      " students are averagely present on lectures");
                    Console.ReadLine();
                    goto sign;
                }
                case 6:
                {
                    for (int i = 0; i < lectures.Count; i++)
                    {
                        Console.WriteLine(i + 1 + "." + lectures[i]);
                    }

                    Console.WriteLine("Type the number of department you want to inspect");
                    int counter = int.Parse(Console.ReadLine()) - 1;
                    Console.WriteLine(control.AmountOfWordsInDepartmentName(lectures[counter]) +
                                      " words are in department name");
                    Console.ReadLine();
                    goto sign;
                }
                case 7:
                {
                    control.LecturesWithTheBiggestAmountOfStudents(lectures);
                    Console.ReadLine();
                    goto sign;
                }
                case 8:
                {
                    break;
                }
                default:
                {
                    throw new ArgumentException("You typed the wrong symbol");
                }
            }
        }
    }
}