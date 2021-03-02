using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Helpers
{
    class ConsoleIO
    {
        public const string SeperatorBar = "======================================================";
        public const string StudentLineFormat = "{0,-20} {1,-15} {2,5}";
        public const string PickStudentLineFormat = "{0,2} {1,-20} {2,-15} {3,5}";
        public static void PrintStudentListHeader()
        {
            Console.WriteLine(SeperatorBar);
            Console.WriteLine(StudentLineFormat, "Name", "Major", "GPA");
            Console.WriteLine(SeperatorBar);
        }

        public static void PrintPickListOfStudents(List<Student> students)
        {
            Console.WriteLine(SeperatorBar);
            Console.WriteLine(PickStudentLineFormat, "", "Name", "Major", "GPA");
            Console.WriteLine(SeperatorBar);
            for (int i = 0; i < students.Count(); i++)
            {
                Console.WriteLine(PickStudentLineFormat, i + 1, students[i].LastName + ", " + students[i].FirstName, students[i].Major, students[i].GPA);
            }

            Console.WriteLine();
            Console.WriteLine(SeperatorBar);
        }

        public static string GetRequiredStringFromUser(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("You must enter a valid text.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }

                else
                {
                    return input;
                }
            }
        }

        public static string GetYesNoAnswerFromUser(string prompt)
        {
            while (true)
            {
                Console.Write(prompt + " (Y/N)? ");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("You must enter Y/N.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }

                else
                {
                    if (input != "Y" && input != "N")
                    {
                        Console.WriteLine("You must enter Y/N.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        continue;
                    }
                    return input;
                }
            }
        }

        public static int GetStudentIndexFromUser(string prompt, int max)
        {
            int output;

            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (!int.TryParse(input, out output))
                {
                    Console.WriteLine("You must enter a number.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }

                else
                {
                    if (output < 1 || output > max)
                    {
                        Console.WriteLine($"GPA must be between 1 and {max}.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        continue;
                    }

                    return output;
                }
            }
        }

        public static double GetRequiredDoubleFromUser(string prompt)
        {
            double output;
            
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (!double.TryParse(input, out output))
                {
                    Console.WriteLine("You must enter a number.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }

                else
                {
                    if(output < 0 || output > 4)
                    {
                        Console.WriteLine("GPA must be between 0 and 4.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        continue;
                    }

                    return output;
                }
            }
        }

        public static void PrintListErrorMessage(ListStudentResponse response)
        {
            Console.WriteLine("An arror occurred loading the student list:");
            Console.WriteLine(response.Message);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            return;
        }
    }
}
