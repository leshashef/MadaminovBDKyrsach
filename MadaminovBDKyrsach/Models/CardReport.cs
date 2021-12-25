using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MadaminovBDKyrsach.Models
{
    public partial class CardReport
    {
        public long Id { get; set; }
        public long GroupId { get; set; }
        public long StudentId { get; set; }
        public string Subjects { get; set; }
        public int Grades { get; set; }

        public virtual StudyGroup Group { get; set; }
        public virtual Students Student { get; set; }
    }
}
