using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MadaminovBDKyrsach.Models
{
    public partial class TourSchedule
    {
        public int Id { get; set; }
        public string NameTourSchedule { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string Locations { get; set; }
        public int PerformanceShowId { get; set; }

        public virtual PerformanceShow PerformanceShow { get; set; }
    }
}
