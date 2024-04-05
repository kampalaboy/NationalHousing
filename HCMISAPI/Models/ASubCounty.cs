using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class ASubCounty
    {
        public ASubCounty()
        {
            EmployeePlaceofOriginSubCounty = new HashSet<Employee>();
            EmployeePlaceofResidenceSubCounty = new HashSet<Employee>();
            NonStaffPlaceofOriginSubCounty = new HashSet<NonStaff>();
            NonStaffPlaceofResidenceSubCounty = new HashSet<NonStaff>();
        }

        public int SubCountyId { get; set; }
        public string? SubCountyDescription { get; set; }
        public int? DistrictId { get; set; }

        public virtual ADistrict? District { get; set; }
        public virtual ICollection<Employee> EmployeePlaceofOriginSubCounty { get; set; }
        public virtual ICollection<Employee> EmployeePlaceofResidenceSubCounty { get; set; }
        public virtual ICollection<NonStaff> NonStaffPlaceofOriginSubCounty { get; set; }
        public virtual ICollection<NonStaff> NonStaffPlaceofResidenceSubCounty { get; set; }
    }
}
