using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class AParish
    {
        public AParish()
        {
            AVillage = new HashSet<AVillage>();
            EmployeePlaceofOriginParish = new HashSet<Employee>();
            EmployeePlaceofResidenceParish = new HashSet<Employee>();
            NonStaffPlaceofOriginParish = new HashSet<NonStaff>();
            NonStaffPlaceofResidenceParish = new HashSet<NonStaff>();
        }

        public int ParishId { get; set; }
        public int? SubCountyId { get; set; }
        public string? ParishDesc { get; set; }

        public virtual ICollection<AVillage> AVillage { get; set; }
        public virtual ICollection<Employee> EmployeePlaceofOriginParish { get; set; }
        public virtual ICollection<Employee> EmployeePlaceofResidenceParish { get; set; }
        public virtual ICollection<NonStaff> NonStaffPlaceofOriginParish { get; set; }
        public virtual ICollection<NonStaff> NonStaffPlaceofResidenceParish { get; set; }
    }
}
