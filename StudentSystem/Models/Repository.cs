using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public static class Repository
    {
        public static List<Student> _students;
        public static List<Student> students()
        {
            return _students;
        }
    }
}
