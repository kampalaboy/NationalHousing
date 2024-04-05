using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class ARelationship
    {
        public ARelationship()
        {
            EmployeeNextOfKin = new HashSet<EmployeeNextOfKin>();
            NonStaffNextOfKin = new HashSet<NonStaffNextOfKin>();
        }

        public int RelationshipId { get; set; }
        public string? RelationshipName { get; set; }

        public virtual ICollection<EmployeeNextOfKin> EmployeeNextOfKin { get; set; }
        public virtual ICollection<NonStaffNextOfKin> NonStaffNextOfKin { get; set; }
    }
}
