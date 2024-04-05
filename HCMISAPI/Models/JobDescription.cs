using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class JobDescription
    {
        public JobDescription()
        {
            Employee = new HashSet<Employee>();
            JobDescriptionBenefit = new HashSet<JobDescriptionBenefit>();
            JobDescriptionKnowledge = new HashSet<JobDescriptionKnowledge>();
            JobDescriptionResponsibility = new HashSet<JobDescriptionResponsibility>();
            JobDescriptionWorkExperienceRequirement = new HashSet<JobDescriptionWorkExperienceRequirement>();
        }

        public int JobDescriptionId { get; set; }
        public int? JibTitleId { get; set; }
        public int? DepartmentId { get; set; }
        public int? SalaryScaleId { get; set; }
        /// <summary>
        /// This column will contain extra description of the given job description
        /// </summary>
        public string? JobDescription1 { get; set; }
        /// <summary>
        /// This Column is the primary key for the job types and it will be auto incremented whenever a new job type is added
        /// </summary>
        public int? JobTypeId { get; set; }
        public int? ContractLength { get; set; }
        public int? ContractLengthTypeId { get; set; }
        public DateTime? ContractStartDate { get; set; }
        public DateTime? ContractEnddate { get; set; }
        /// <summary>
        /// This column will store the minimum Years of experience Required for the specific job description
        /// </summary>
        public double? MinimumYearsofExperience { get; set; }
        public int? Vacancies { get; set; }
        public int? MinimumLevelOfEducationId { get; set; }
        /// <summary>
        /// This column will store the Jobstatusid of the Jobstatus that will be mapped to this job description and it will reference the A_JobStatus Table
        /// </summary>
        public int? JobStatusId { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }

        public virtual AContractLengthType? ContractLengthType { get; set; }
        public virtual ADepartment? Department { get; set; }
        public virtual AJobTitle? JibTitle { get; set; }
        public virtual AJobStatus? JobStatus { get; set; }
        public virtual AJobType? JobType { get; set; }
        public virtual ALevelofEducation? MinimumLevelOfEducation { get; set; }
        public virtual ASalaryScale? SalaryScale { get; set; }
        public virtual ICollection<Employee> Employee { get; set; }
        public virtual ICollection<JobDescriptionBenefit> JobDescriptionBenefit { get; set; }
        public virtual ICollection<JobDescriptionKnowledge> JobDescriptionKnowledge { get; set; }
        public virtual ICollection<JobDescriptionResponsibility> JobDescriptionResponsibility { get; set; }
        public virtual ICollection<JobDescriptionWorkExperienceRequirement> JobDescriptionWorkExperienceRequirement { get; set; }
    }
}
