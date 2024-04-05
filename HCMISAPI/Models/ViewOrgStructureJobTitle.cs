using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class ViewOrgStructureJobTitle
    {
        public int JobTitleId { get; set; }
        public int? DepartmentId { get; set; }
        public string? DepartmentDescription { get; set; }
        public string? JobTitleDescription { get; set; }
        public int? ReportsTo { get; set; }
    }
}
