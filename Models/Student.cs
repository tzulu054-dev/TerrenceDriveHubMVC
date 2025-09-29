using System;
using System.Collections.Generic;

namespace TerrenceDriveHubMVC.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IDNumber { get; set; }
        public string BankDetails { get; set; }
        public bool HasLearners { get; set; }
        public bool HasPaid { get; set; }
        public string SelectedPackage { get; set; }
        public string LicenseCode { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime StartDate { get; set; }
        public ICollection<Feedback> Feedbacks { get; set; }
    }
}
