using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.Data;
using StudentManagement.Models;
using StudentManagement.Helpers;

namespace StudentManagement.Workflows
{
    public class EditStudentWorkflow
    {
        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("Edit Student GPA");

            StudentRepository repo = new StudentRepository(Settings.FilePath);
            ListStudentResponse response = repo.List();

            if(!response.Success)
            {
                ConsoleIO.PrintListErrorMessage(response);
                return;
            }

            List<Student> students = response.Students;

            ConsoleIO.PrintPickListOfStudents(students);
            Console.WriteLine();

            int index = ConsoleIO.GetStudentIndexFromUser("Which student would you like to edit?", students.Count());
            index--;

            Console.WriteLine();
            students[index].GPA = ConsoleIO.GetRequiredDoubleFromUser(string.Format($"Enter new GPA for {students[index].FirstName} {students[index].LastName}: "));

            repo.EditStudent(students[index], index);

            Console.WriteLine("GPA Updated!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
