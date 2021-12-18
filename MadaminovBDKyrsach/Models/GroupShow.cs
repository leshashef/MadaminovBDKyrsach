using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MadaminovBDKyrsach.Models
{
    public partial class GroupShow
    {
        public int Id { get; set; }
        public int PerformanceShowId { get; set; }
        public int WorkerId { get; set; }
        public string TypeRole { get; set; }

        public virtual PerformanceShow PerformanceShow { get; set; }
        public virtual Worker Worker { get; set; }
    }
}
