using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class JobDescriptionBenefit
    {
        /// <summary>
        /// This will be the unique identifier for each job Benefit
        /// </summary>
        public double BenefitId { get; set; }
        /// <summary>
        /// This column will store the JobDescriptionId from the JobDescription that will be mapped to this specific benefit
        /// </summary>
        public int? JobDescriptionId { get; set; }
        /// <summary>
        /// This will Store the description of each benefit
        /// </summary>
        public string? BenefitDescription { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }

        public virtual JobDescription? JobDescription { get; set; }
    }
}
