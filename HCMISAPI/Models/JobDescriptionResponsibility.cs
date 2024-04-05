using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class JobDescriptionResponsibility
    {
        /// <summary>
        /// This will be the unique identifier for each job responsibility
        /// </summary>
        public double ResponsibiltyId { get; set; }
        /// <summary>
        /// This column will store the JobDescriptionId from the JobDescription that will be mapped to this specific responsibility
        /// </summary>
        public int? JobDescriptionId { get; set; }
        /// <summary>
        /// This will Store the description of each responsibility
        /// </summary>
        public string? ResponsibilityDesc { get; set; }
        public string? AddedBy { get; set; }
        public DateTime? AddedDate { get; set; }

        public virtual JobDescription? JobDescription { get; set; }
    }
}
