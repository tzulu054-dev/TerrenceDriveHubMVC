using System;

namespace TerrenceDriveHubMVC.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaidOn { get; set; }
        public string Status { get; set; } // Paid / Refund Requested
    }
}

