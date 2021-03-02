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
    public class RemoveStudentWorkflow
    {
        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("Remove Student");

            StudentRepository repo = new StudentRepository(Settings.FilePath);

            ListStudentResponse response = repo.List();

            if (!response.Success)
            {
                ConsoleIO.PrintListErrorMessage(response);
                return;
            }

            List<Student> students = response.Students;

            ConsoleIO.PrintPickListOfStudents(students);
            Console.WriteLine();

            int index = ConsoleIO.GetStudentIndexFromUser("Which student would you like to delete?", students.Count());
            index--;

            string answer = ConsoleIO.GetYesNoAnswerFromUser($"Are you sure you want to remove {students[index].FirstName} {students[index].LastName}");

            if (answer=="Y")
            {
                repo.DeleteStudent(index);
                Console.WriteLine("Student Removed!");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Removal Cancelled!");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
