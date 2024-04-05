using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class AContractLengthType
    {
        public AContractLengthType()
        {
            JobDescription = new HashSet<JobDescription>();
        }

        public int ContractLengthTypeId { get; set; }
        public string? ContractLengthTypeDesc { get; set; }

        public virtual ICollection<JobDescription> JobDescription { get; set; }
    }
}
