using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MadaminovBDKyrsach.Models
{
    public partial class Literature
    {
        public Literature()
        {
            FondAddeds = new HashSet<FondAddeds>();
        }

        public long Id { get; set; }
        public string NameType { get; set; }

        public virtual ICollection<FondAddeds> FondAddeds { get; set; }
    }
}
