using System.Collections.Generic;

namespace TerrenceDriveHubMVC.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<LessonRecord> AssignedLessons { get; set; }
    }
}


