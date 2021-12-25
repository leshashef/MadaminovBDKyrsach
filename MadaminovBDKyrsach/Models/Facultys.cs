using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MadaminovBDKyrsach.Models
{
    public partial class Facultys
    {
        public Facultys()
        {
            Chairs = new HashSet<Chairs>();
        }

        public long Id { get; set; }
        public string NameFaculty { get; set; }
        public string DeanFio { get; set; }
        public int NumberRoom { get; set; }
        public int NumberKorpus { get; set; }
        public long Phone { get; set; }

        public virtual ICollection<Chairs> Chairs { get; set; }
    }
}
