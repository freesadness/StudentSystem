using Microsoft.AspNetCore.Mvc;
using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSystem.Controllers
{
    public class HomeController: Controller
    {
        public ViewResult Index() {
            return View(new Student {
                StudentId = 313254,
                FirstName = "Nasus",
                LastName = "Saki",
            });
        }
        public ViewResult ListStudents() {

            return View(StudentSystem.Models.ListStudents.students());
        }
    }
}
