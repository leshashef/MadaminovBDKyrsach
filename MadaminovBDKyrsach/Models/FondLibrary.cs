using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MadaminovBDKyrsach.Models
{
    public partial class FondLibrary
    {
        public FondLibrary()
        {
            FondAddeds = new HashSet<FondAddeds>();
        }

        public long Id { get; set; }
        public string NameFond { get; set; }
        public long LibraryId { get; set; }
        public long CountBook { get; set; }
        public long CountJournal { get; set; }
        public long CountNewspaper { get; set; }
        public long CountCollection { get; set; }
        public long CountDissertation { get; set; }
        public long CountReport { get; set; }

        public virtual Library Library { get; set; }
        public virtual ICollection<FondAddeds> FondAddeds { get; set; }
    }
}
