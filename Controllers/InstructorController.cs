using Microsoft.AspNetCore.Mvc;
using TerrenceDriveHubMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TerrenceDriveHubMVC.Controllers
{
    public class InstructorController : Controller
    {
        // Temporary in-memory lists
        private static List<Instructor> instructors = new List<Instructor>
        {
            new Instructor { Id = 1, Name = "Mr Zondi", AssignedLessons = new List<LessonRecord>() },
            new Instructor { Id = 2, Name = "Mr Zungu", AssignedLessons = new List<LessonRecord>() },
            new Instructor { Id = 3, Name = "Mr Sibiya", AssignedLessons = new List<LessonRecord>() }
        };

        private static List<Student> students = new List<Student>(); // Link to actual student DB in real app

        private static List<LessonPackage> packages = new List<LessonPackage>
        {
            new LessonPackage { Id = 1, Name = "10 Lessons", Price = 1250 },
            new LessonPackage { Id = 2, Name = "20 Lessons", Price = 2000 },
            new LessonPackage { Id = 3, Name = "25 Lessons", Price = 2250 }
        };

        // View assigned students and lessons
        public IActionResult AssignedStudents()
        {
            return View(instructors);
        }

        // Mark lesson completed
        [HttpPost]
        public IActionResult UpdateLessonStatus(int instructorId, int lessonId)
        {
            var instructor = instructors.FirstOrDefault(i => i.Id == instructorId);
            if (instructor != null)
            {
                var lesson = instructor.AssignedLessons.FirstOrDefault(l => l.Id == lessonId);
                if (lesson != null) lesson.Status = "Completed";
            }
            return RedirectToAction("AssignedStudents");
        }
    }
}

