using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public static class ListStudents
    {
        public static IEnumerable<Student> students() {
            return new List<Student>()
            {
                new Student{LastName="Abel", StudentId=1000001, FirstName = "Lucas", Gpa = 1, CourseCode = "COMP229"},
                new Student{LastName="White", StudentId=1000002, FirstName = "Lucas", Gpa = 3.2, CourseCode = "COMP100"},
                new Student{LastName="Kaye", StudentId=1000003, FirstName = "Lucas", Gpa = 1.2, CourseCode = "COMP123"},
                new Student { LastName = "Ekko", StudentId=1000004, FirstName = "Lucas", Gpa = 3.2, CourseCode = "COMP123" },
            };
        }

    }
}
