using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class AJobStatus
    {
        public AJobStatus()
        {
            JobDescription = new HashSet<JobDescription>();
        }

        public int JobStatusId { get; set; }
        public string? JobStatusDesc { get; set; }

        public virtual ICollection<JobDescription> JobDescription { get; set; }
    }
}
