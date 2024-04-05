using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class AVillage
    {
        public AVillage()
        {
            EmployeePlaceofOriginVillage = new HashSet<Employee>();
            EmployeePlaceofResidenceVillage = new HashSet<Employee>();
            NonStaffPlaceofOriginVillage = new HashSet<NonStaff>();
            NonStaffPlaceofResidenceVillage = new HashSet<NonStaff>();
        }

        public int VillageId { get; set; }
        public string? ViallgeDescription { get; set; }
        public int? ParishId { get; set; }

        public virtual AParish? Parish { get; set; }
        public virtual ICollection<Employee> EmployeePlaceofOriginVillage { get; set; }
        public virtual ICollection<Employee> EmployeePlaceofResidenceVillage { get; set; }
        public virtual ICollection<NonStaff> NonStaffPlaceofOriginVillage { get; set; }
        public virtual ICollection<NonStaff> NonStaffPlaceofResidenceVillage { get; set; }
    }
}
