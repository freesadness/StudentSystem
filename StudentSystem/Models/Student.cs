using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public class Student
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String FullName { get; set; }
        public String CourseCode { get; set; }
        public String Email
        {
            get; set;
        }
        public double? Gpa { get; set; }
        public int? StudentId { get; set; }
    }
}
