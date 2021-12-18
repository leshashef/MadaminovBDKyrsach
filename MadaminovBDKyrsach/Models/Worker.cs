using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MadaminovBDKyrsach.Models
{
    public partial class Worker
    {
        public Worker()
        {
            GroupShow = new HashSet<GroupShow>();
            PerformanceShowConductorDirector = new HashSet<PerformanceShow>();
            PerformanceShowDirectorProducer = new HashSet<PerformanceShow>();
            PerformanceShowProductionDesigner = new HashSet<PerformanceShow>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public DateTime YearBirthDay { get; set; }
        public string JobPost { get; set; }
        public int Experience { get; set; }
        public DateTime YearOfStartWork { get; set; }
        public string Gender { get; set; }
        public string AddressWorker { get; set; }
        public long NumberPhone { get; set; }
        public string CityWorker { get; set; }

        public virtual ICollection<GroupShow> GroupShow { get; set; }
        public virtual ICollection<PerformanceShow> PerformanceShowConductorDirector { get; set; }
        public virtual ICollection<PerformanceShow> PerformanceShowDirectorProducer { get; set; }
        public virtual ICollection<PerformanceShow> PerformanceShowProductionDesigner { get; set; }
    }
}
