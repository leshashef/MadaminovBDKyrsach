using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MadaminovBDKyrsach.Models
{
    public partial class TheatreRepertoire
    {
        public int Id { get; set; }
        public int PerformanceShowId { get; set; }
        public DateTime PeriodStart { get; set; }
        public DateTime PeriodEnd { get; set; }
        public string WorkDays { get; set; }
        public double PriceTicket { get; set; }

        public virtual PerformanceShow PerformanceShow { get; set; }
    }
}
