using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MadaminovBDKyrsach.Models
{
    public partial class StudyGroup
    {
        public StudyGroup()
        {
            CardReport = new HashSet<CardReport>();
            Students = new HashSet<Students>();
        }

        public long Id { get; set; }
        public string NameGroup { get; set; }
        public DateTime YearOfBeginStudy { get; set; }
        public string CoursStudy { get; set; }
        public long CountStydends { get; set; }
        public long ChairId { get; set; }

        public virtual Chairs Chair { get; set; }
        public virtual ICollection<CardReport> CardReport { get; set; }
        public virtual ICollection<Students> Students { get; set; }
    }
}
