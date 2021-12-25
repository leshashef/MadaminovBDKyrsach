using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MadaminovBDKyrsach.Models
{
    public partial class FondAddeds
    {
        public long Id { get; set; }
        public long FondId { get; set; }
        public long WorkerId { get; set; }
        public DateTime DateCreated { get; set; }
        public string NameSource { get; set; }
        public long LiteratureId { get; set; }
        public string PublishingHouse { get; set; }
        public DateTime PublishingDate { get; set; }
        public long CountCopyes { get; set; }

        public virtual FondLibrary Fond { get; set; }
        public virtual Literature Literature { get; set; }
        public virtual Workers Worker { get; set; }
    }
}
