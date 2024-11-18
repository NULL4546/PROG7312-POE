using System;

namespace PROG7312Lopes
{
    public class UserInput
    {
        public int ID { get; set; } // Unique identifier for the request
        public string Location { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string FilePath { get; set; }
        public string Status { get; set; } = "Pending"; // Default status
        public string Notes { get; set; } = "N/A";     // Admin notes
    }
}
