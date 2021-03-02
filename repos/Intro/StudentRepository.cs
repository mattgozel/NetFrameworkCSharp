using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    public class StudentRepository
    {
        public static List<Student> SelectAll()
        {
            return new List<Student>
            {
                new Student {FirstName="Matty", LastName="Humble", Major="Computer Science", GPA=4.0M},
                new Student {FirstName="Emily", LastName="Norling", Major="Landscape Arch", GPA=3.6M},
                new Student {FirstName="Bodie", LastName="Gozel", Major="Computer Science", GPA=3.8M},
                new Student {FirstName="Lucca", LastName="Gozel", Major="Basketball", GPA=4.0M},
                new Student {FirstName="Paul", LastName="Westerberg", Major="Music", GPA=2.0M},
                new Student {FirstName="Bruce", LastName="Springsteen", Major="Music", GPA=2.5M},
            };
        }
    }
}
