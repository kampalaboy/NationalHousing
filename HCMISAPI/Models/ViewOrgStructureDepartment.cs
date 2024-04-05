using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class ViewOrgStructureDepartment
    {
        public int DepartmentId { get; set; }
        public string? DepartmentDescription { get; set; }
        public int? ReportsTo { get; set; }
    }
}
