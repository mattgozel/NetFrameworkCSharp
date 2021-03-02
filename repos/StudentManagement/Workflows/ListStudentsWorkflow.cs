using StudentManagement.Data;
using StudentManagement.Helpers;
using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Workflows
{
    class ListStudentsWorkflow
    {
        public void Execute()
        {
            StudentRepository repo = new StudentRepository(Settings.FilePath);

            ListStudentResponse response = repo.List();

            if (!response.Success)
            {
                ConsoleIO.PrintListErrorMessage(response);
                return;
            }

            List<Student> students = response.Students;

            Console.Clear();
            Console.WriteLine("Student List");
            ConsoleIO.PrintStudentListHeader();
            foreach(var student in students)
            {
                Console.WriteLine(ConsoleIO.StudentLineFormat, student.LastName + ", " + student.FirstName, student.Major, student.GPA);
            }
            Console.WriteLine();
            Console.WriteLine(ConsoleIO.SeperatorBar);
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
    }
}
