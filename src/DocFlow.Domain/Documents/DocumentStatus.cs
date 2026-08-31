using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocFlow.Domain.Documents
{
    public enum DocumentStatus
    {
        Draft = 1,
        InApproval = 2,
        Approved = 3,
        Rejected = 4,
        Archived = 5
    }
}
