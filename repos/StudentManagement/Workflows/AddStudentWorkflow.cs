﻿using StudentManagement.Data;
using StudentManagement.Helpers;
using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Workflows
{
    class AddStudentWorkflow
    {
        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("Add Student");
            Console.WriteLine(ConsoleIO.SeperatorBar);
            Console.WriteLine();

            Student newStudent = new Student();

            newStudent.FirstName = ConsoleIO.GetRequiredStringFromUser("First Name: ");
            newStudent.LastName = ConsoleIO.GetRequiredStringFromUser("Last Name: ");
            newStudent.Major = ConsoleIO.GetRequiredStringFromUser("Major: ");
            newStudent.GPA = ConsoleIO.GetRequiredDoubleFromUser("GPA: ");

            Console.WriteLine();
            ConsoleIO.PrintStudentListHeader();
            Console.WriteLine(ConsoleIO.StudentLineFormat, newStudent.LastName + ", " + newStudent.FirstName, newStudent.Major, newStudent.GPA);

            Console.WriteLine();
            if(ConsoleIO.GetYesNoAnswerFromUser("Add the following information") == "Y")
            {
                StudentRepository repo = new StudentRepository(Settings.FilePath);
                repo.AddStudent(newStudent);
                Console.WriteLine("Student Added!");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Add Cancelled!");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}