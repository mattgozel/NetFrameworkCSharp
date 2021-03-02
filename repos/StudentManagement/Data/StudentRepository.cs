using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentManagement.Data
{
    public class StudentRepository
    {
        private string _filePath;

        public StudentRepository(string filePath)
        {
            _filePath = filePath;
        }
        public ListStudentResponse List()
        {
            ListStudentResponse response = new ListStudentResponse();
            response.Success = true;
            
            response.Students = new List<Student>();

            try
            {
                using (StreamReader sr = new StreamReader(_filePath))
                {
                    sr.ReadLine();
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {                        
                            Student newStudent = new Student();

                            string[] columns = line.Split(',');
                            newStudent.FirstName = columns[0];
                            newStudent.LastName = columns[1];
                            newStudent.Major = columns[2];
                            newStudent.GPA = double.Parse(columns[3]);

                            response.Students.Add(newStudent);
                    }
                }
            }
            catch(Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }      

            return response;
        }

        public void AddStudent(Student student)
        {
            using(StreamWriter sw = new StreamWriter(_filePath, true))
            {
                string line = CreateCsvForStudent(student);

                sw.WriteLine(line);
            }
        }

        public void EditStudent(Student student, int id)
        {
            var response = List();
            response.Students[id] = student;
            CreateStudentFile(response.Students);
        }

        public void DeleteStudent(int id)
        {
            var response = List();
            response.Students.RemoveAt(id);
            CreateStudentFile(response.Students);
        }

        private string CreateCsvForStudent(Student student)
        {
            return string.Format($"{student.FirstName},{student.LastName},{student.Major},{student.GPA.ToString()}");
        }

        private void CreateStudentFile(List<Student> students)
        {
            if (File.Exists(_filePath))
                File.Delete(_filePath);

            using(StreamWriter sr = new StreamWriter(_filePath))
            {
                sr.WriteLine("FirstName,LastName,Major,GPA");
                foreach(var student in students)
                {
                    sr.WriteLine(CreateCsvForStudent(student));
                }
            }
        }
    }
}
