using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class ADistrict
    {
        public ADistrict()
        {
            ASubCounty = new HashSet<ASubCounty>();
            EmployeePlaceofOriginDistrict = new HashSet<Employee>();
            EmployeePlaceofResidenceDistrict = new HashSet<Employee>();
            NonStaffPlaceofOriginDistrict = new HashSet<NonStaff>();
            NonStaffPlaceofResidenceDistrict = new HashSet<NonStaff>();
        }

        public int DistrictId { get; set; }
        public string? DistrictDescription { get; set; }
        public int? CountryId { get; set; }

        public virtual ICollection<ASubCounty> ASubCounty { get; set; }
        public virtual ICollection<Employee> EmployeePlaceofOriginDistrict { get; set; }
        public virtual ICollection<Employee> EmployeePlaceofResidenceDistrict { get; set; }
        public virtual ICollection<NonStaff> NonStaffPlaceofOriginDistrict { get; set; }
        public virtual ICollection<NonStaff> NonStaffPlaceofResidenceDistrict { get; set; }
    }
}
