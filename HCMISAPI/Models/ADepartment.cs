using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class ADepartment
    {
        public ADepartment()
        {
            AJobTitle = new HashSet<AJobTitle>();
            Employee = new HashSet<Employee>();
            JobDescription = new HashSet<JobDescription>();
        }

        public int DepartmentId { get; set; }
        public string? DepartmentDescription { get; set; }
        public string? ReportsTo { get; set; }

        public virtual ICollection<AJobTitle> AJobTitle { get; set; }
        public virtual ICollection<Employee> Employee { get; set; }
        public virtual ICollection<JobDescription> JobDescription { get; set; }
    }
}
