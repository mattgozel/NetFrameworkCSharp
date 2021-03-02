using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using StudentManagement.Data;
using StudentManagement.Models;
using System.IO;

namespace SystemIO.Tests
{
    [TestFixture]
    public class Tests
    {
        public const string filePath = @"C:\data\SystemIO\StudentTest.txt";
        public const string originalData = @"C:\data\SystemIO\StudentTestSeed.txt";

        [SetUp]
        public void Setup()
        {
            if(File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            File.Copy(originalData, filePath);
        }

        [Test]
        public void CanReadDataFromFile()
        {
            StudentRepository repo = new StudentRepository(filePath);

            List <Student> students = repo.List().Students;

            Assert.AreEqual(4, students.Count());

            Student check = students[2];

            Assert.AreEqual("Jane", check.FirstName);
            Assert.AreEqual("Doe", check.LastName);
            Assert.AreEqual("Computer Science", check.Major);
            Assert.AreEqual(4.0, check.GPA);
        }

        [Test]
        public void CanAddStudentToFile()
        {
            StudentRepository repo = new StudentRepository(filePath);

            Student newStudent = new Student();
            newStudent.FirstName = "Testy";
            newStudent.LastName = "McTester";
            newStudent.Major = "Research";
            newStudent.GPA = 3.2;

            repo.AddStudent(newStudent);

            List<Student> students = repo.List().Students;

            Assert.AreEqual(5, students.Count());

            Student check = students[4];

            Assert.AreEqual("Testy", check.FirstName);
            Assert.AreEqual("McTester", check.LastName);
            Assert.AreEqual("Research", check.Major);
            Assert.AreEqual(3.2, check.GPA);
        }
        
        [Test]
        public void CanDeleteStudent()
        {
            StudentRepository repo = new StudentRepository(filePath);
            repo.DeleteStudent(0);

            List<Student> students = repo.List().Students;

            Assert.AreEqual(3, students.Count);

            Student check = students[0];

            Assert.AreEqual("Mary", check.FirstName);
            Assert.AreEqual("Jones", check.LastName);
            Assert.AreEqual("Business", check.Major);
            Assert.AreEqual(3.0, check.GPA);
        }

        [Test]
        public void CanEditStudent()
        {
            StudentRepository repo = new StudentRepository(filePath);
            List<Student> students = repo.List().Students;
            students[0].GPA = 3.0;
            repo.EditStudent(students[0], 0);

            Assert.AreEqual(4, students.Count);

            students = repo.List().Students;

            Student check = students[0];

            Assert.AreEqual("Joe", check.FirstName);
            Assert.AreEqual("Smith", check.LastName);
            Assert.AreEqual("Computer Science", check.Major);
            Assert.AreEqual(3.0, check.GPA);
        }
    }
}
