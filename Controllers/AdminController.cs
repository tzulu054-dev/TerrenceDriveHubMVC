using Microsoft.AspNetCore.Mvc;
using TerrenceDriveHubMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace TerrenceDriveHubMVC.Controllers
{
    public class AdminController : Controller
    {
        private static List<Student> students = new List<Student>();
        private static List<Instructor> instructors = new List<Instructor>();
        private static List<LessonPackage> packages = new List<LessonPackage>
        {
            new LessonPackage { Id = 1, Name = "10 Lessons", Price = 1250 },
            new LessonPackage { Id = 2, Name = "20 Lessons", Price = 2000 },
            new LessonPackage { Id = 3, Name = "25 Lessons", Price = 2250 }
        };

        // View all students
        public IActionResult Students()
        {
            return View(students);
        }

        // Assign lessons to instructors
        public IActionResult AssignLesson()
        {
            ViewBag.Students = students;
            ViewBag.Instructors = instructors;
            ViewBag.Packages = packages;
            return View();
        }

        [HttpPost]
        public IActionResult AssignLesson(int studentId, int instructorId, int packageId)
        {
            var instructor = instructors.FirstOrDefault(i => i.Id == instructorId);
            if (instructor != null)
            {
                instructor.AssignedLessons.Add(new LessonRecord
                {
                    Id = new System.Random().Next(1000, 9999), // Random lesson ID
                    StudentId = studentId,
                    InstructorId = instructorId,
                    PackageId = packageId,
                    LessonDate = System.DateTime.Now.AddDays(7), // Schedule one week later
                    Status = "Scheduled"
                });
            }
            return RedirectToAction("AssignLesson");
        }
    }
}

