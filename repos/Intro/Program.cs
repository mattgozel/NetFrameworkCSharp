using System;
using System.Collections.Generic;
using System.Linq;

namespace Intro
{
    class Program
    {
        static void Main()
        {
            //PrintStudents(StudentRepository.SelectAll());
            //MethodSyntax1();
            //MethodSyntax2();
            //MethodSyntax3();
            //MethodSyntax4();
            //MethodSyntax5();
            //QuerySyntax1();
            //QuerySyntax2();
            //QuerySyntax3();
            AnonymousType();

            Console.ReadKey();
        }

        static void MethodSyntax1()
        {
            var students = StudentRepository.SelectAll();

            decimal avg = students.Average(s => s.GPA);

            Console.WriteLine($"The average GPA is: {avg}");
        }

        static void MethodSyntax2()
        {
            var honorRoll = StudentRepository.SelectAll().Where(s => s.GPA >= 3.5M);
            PrintStudents(honorRoll);
        }

        static void MethodSyntax3()
        {
            var orderByGPA = StudentRepository.SelectAll().OrderByDescending(s => s.GPA);
            PrintStudents(orderByGPA);
        }

        static void MethodSyntax4()
        {
            var topThree = StudentRepository.SelectAll().OrderByDescending(s => s.GPA).Take(3);
            PrintStudents(topThree);
        }

        static void MethodSyntax5()
        {
            var groups = StudentRepository.SelectAll().GroupBy(s => s.Major);
            string lineFormat = "{0,-15} {1,-15}";

            foreach (var group in groups)
            {
                Console.WriteLine($"Major: {group.Key}");
                Console.WriteLine("---------------------------------------");
                foreach(var student in group)
                {
                    Console.WriteLine(lineFormat, student.LastName, student.FirstName);
                }

                Console.WriteLine("---------------------------------------");
                Console.WriteLine();
            }
        }

        private static void QuerySyntax1()
        {
            var honorRoll = from s in StudentRepository.SelectAll()
                            where s.GPA > 3.5M
                            select s;

            PrintStudents(honorRoll);
        }

        static void QuerySyntax2()
        {
            var topThree = (from s in StudentRepository.SelectAll()
                           orderby s.GPA descending
                           select s).Take(3);

            PrintStudents(topThree);
        }

        static void QuerySyntax3()
        {
            var groups = from s in StudentRepository.SelectAll()
                         group s by s.Major into newgroup
                         orderby newgroup.Key
                         select newgroup;

            string lineFormat = "{0,-15} {1,-15}";

            foreach (var group in groups)
            {
                Console.WriteLine($"Major: {group.Key}");
                Console.WriteLine("---------------------------------------");
                foreach (var student in group)
                {
                    Console.WriteLine(lineFormat, student.LastName, student.FirstName);
                }

                Console.WriteLine("---------------------------------------");
                Console.WriteLine();
            }
        }

        static void AnonymousType()
        {
            var students = from s in StudentRepository.SelectAll()
                           select new { LastFirst = s.LastName + ", " + s.FirstName, s.Major, s.GPA };

            string lineFormat = "{0,-30} {1,-18} {2,4}";
            Console.WriteLine(lineFormat, "Name", "Major", "GPA");
            Console.WriteLine("--------------------------------------------------------");

            foreach (var student in students)
            {
                Console.WriteLine(lineFormat, student.LastFirst, student.Major, student.GPA);
            }
        }

        static void PrintStudents(IEnumerable<Student> students)
        {
            string headingFormat = "{0,-15} {1,-15} {2,-18} {3,4}";
            string lineFormat = "{0,-15} {1,-15} {2,-18} {3,4}";

            Console.WriteLine(headingFormat, "Last Name", "First Name", "Major", "GPA");
            Console.WriteLine("--------------------------------------------------------");
            foreach(var student in students)
            {
                Console.WriteLine(lineFormat, student.LastName, student.FirstName, student.Major, student.GPA);
            }

            Console.WriteLine("");
        }
    }
}
