using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MadaminovBDKyrsach.Models
{
    public partial class Workers
    {
        public Workers()
        {
            FondAddeds = new HashSet<FondAddeds>();
        }

        public long Id { get; set; }
        public string LastName { get; set; }
        public long LibraryId { get; set; }
        public DateTime BirthDay { get; set; }
        public string Post { get; set; }
        public DateTime StartWork { get; set; }
        public string Education { get; set; }
        public decimal Salary { get; set; }

        public virtual Library Library { get; set; }
        public virtual ICollection<FondAddeds> FondAddeds { get; set; }
    }
}
