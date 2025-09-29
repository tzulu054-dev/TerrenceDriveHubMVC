using Microsoft.AspNetCore.Mvc;
using TerrenceDriveHubMVC.Models;
using System;
using System.Collections.Generic;

namespace TerrenceDriveHubMVC.Controllers
{
    public class StudentController : Controller
    {
        private static List<LessonPackage> packages = new List<LessonPackage>
        {
            new LessonPackage { Id = 1, Name = "Learner's License", Price = 300 },
            new LessonPackage { Id = 2, Name = "10 Driving Lessons", Price = 1250 },
            new LessonPackage { Id = 3, Name = "20 Driving Lessons", Price = 2000 },
            new LessonPackage { Id = 4, Name = "25 Driving Lessons", Price = 2250 }
        };

        private static List<string> codes = new List<string> { "Code 8", "Code 10" };

        public IActionResult Index()
        {
            ViewBag.Packages = packages;
            ViewBag.Codes = codes;
            return View();
        }

        [HttpPost]
        public IActionResult Register(Student student)
        {
            if (student.HasPaid)
            {
                student.PaymentDate = DateTime.Now;
                student.StartDate = student.PaymentDate.AddDays(7);
            }
            return View("Result", student);
        }

        public IActionResult Feedback()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Feedback(Feedback feedback)
        {
            feedback.CreatedAt = DateTime.Now;
            return View("FeedbackResult", feedback);
        }
    }
}

