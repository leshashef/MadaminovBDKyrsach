using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MadaminovBDKyrsach.Models
{
    public partial class Students
    {
        public Students()
        {
            CardReport = new HashSet<CardReport>();
        }

        public long Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public long GroupId { get; set; }
        public DateTime BirthDay { get; set; }
        public string Gender { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public long Phone { get; set; }

        public virtual StudyGroup Group { get; set; }
        public virtual ICollection<CardReport> CardReport { get; set; }
    }
}
