using System;
namespace AdmissionSystem.Models
{
    public class Documents
    {
        public string DocumentsID { get; set; }
        public string DocumentPath { get; set; }
        public int StudentID { get; set; }

        public Student Student { get; set; }
    }
}
