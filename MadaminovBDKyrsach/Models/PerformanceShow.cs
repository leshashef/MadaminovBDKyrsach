using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MadaminovBDKyrsach.Models
{
    public partial class PerformanceShow
    {
        public PerformanceShow()
        {
            GroupShow = new HashSet<GroupShow>();
            TheatreRepertoire = new HashSet<TheatreRepertoire>();
            TourSchedule = new HashSet<TourSchedule>();
        }

        public int Id { get; set; }
        public string NameShow { get; set; }
        public int DirectorProducerId { get; set; }
        public int ProductionDesignerId { get; set; }
        public int ConductorDirectorId { get; set; }
        public string Author { get; set; }
        public string Style { get; set; }
        public string TypeShow { get; set; }

        public virtual Worker ConductorDirector { get; set; }
        public virtual Worker DirectorProducer { get; set; }
        public virtual Worker ProductionDesigner { get; set; }
        public virtual ICollection<GroupShow> GroupShow { get; set; }
        public virtual ICollection<TheatreRepertoire> TheatreRepertoire { get; set; }
        public virtual ICollection<TourSchedule> TourSchedule { get; set; }
    }
}
