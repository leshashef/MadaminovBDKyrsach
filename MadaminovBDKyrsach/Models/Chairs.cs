using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MadaminovBDKyrsach.Models
{
    public partial class Chairs
    {
        public Chairs()
        {
            StudyGroup = new HashSet<StudyGroup>();
        }

        public long Id { get; set; }
        public string NameChair { get; set; }
        public string ZamDeanFio { get; set; }
        public int NumberRoom { get; set; }
        public int NumberKorpus { get; set; }
        public long Phone { get; set; }
        public int CountTeacher { get; set; }
        public long FacultyId { get; set; }

        public virtual Facultys Faculty { get; set; }
        public virtual ICollection<StudyGroup> StudyGroup { get; set; }
    }
}
