using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class JobDescriptionKnowledge
    {
        public double KnowledgeId { get; set; }
        /// <summary>
        /// This column will store the JobDescriptionId from the JobDescription that will be mapped to this specific work experience
        /// </summary>
        public int? JobDescriptionId { get; set; }
        public int? LevelofEducationId { get; set; }
        public int? FieldofStudyId { get; set; }
        public bool IsRequired { get; set; }
        /// <summary>
        /// This will Store the description of each Skill or Knowledge
        /// </summary>
        public string? Notes { get; set; }
        public string? AddedBy { get; set; }
        public DateTime? AddedDate { get; set; }

        public virtual AFieldOfStudy? FieldofStudy { get; set; }
        public virtual JobDescription? JobDescription { get; set; }
        public virtual ALevelofEducation? LevelofEducation { get; set; }
    }
}
