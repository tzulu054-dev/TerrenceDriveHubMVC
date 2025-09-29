using System;

namespace TerrenceDriveHubMVC.Models
{
    public class LessonRecord
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int InstructorId { get; set; }
        public int PackageId { get; set; }
        public DateTime LessonDate { get; set; }
        public string Status { get; set; } // Scheduled / Completed
    }
}

