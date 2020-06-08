using Lab5.Models;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Lecture lecture=new Lecture("Department of No","IDA","IM-15","13.07.2002",35);
            int wordsCount = lecture.AmountOfWordsInDepartmentName(lecture);
            Assert.AreEqual(3,wordsCount);
        }
    }
}