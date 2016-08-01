using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareSelectModels.Version5.Response.Recommendations
{
    public class CareSelectAcknowledgementReason
    {
        public string AcknowledgementReasonId { get; set; }
        public string Reason { get; set; }
        public bool IsCommentRequired { get; set; }
    }
}
