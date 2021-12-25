using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MadaminovBDKyrsach.Models
{
    public partial class Library
    {
        public Library()
        {
            FondLibrary = new HashSet<FondLibrary>();
            Workers = new HashSet<Workers>();
        }

        public long Id { get; set; }
        public string NameLibrary { get; set; }
        public string Adres { get; set; }
        public string City { get; set; }

        public virtual ICollection<FondLibrary> FondLibrary { get; set; }
        public virtual ICollection<Workers> Workers { get; set; }
    }
}
