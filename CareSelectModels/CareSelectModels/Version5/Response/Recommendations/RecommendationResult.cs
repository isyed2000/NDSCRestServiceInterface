using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareSelectModels.Version5.Response.Recommendations
{
    public class RecommendationResult
    {
        public string ResultId { get; set; }
        public string ProcedureId { get; set; }
        public string ProcedureName { get; set; }
        public bool IsRequested { get; set; }

        public int Recommendation { get; set; }
        public string RecommendationText { get; set; }
        public string RecommendationSource { get; set; }
        public IEnumerable<string> RecommendationMessages { get; set; }
        public IEnumerable<KeyValue> RecommendationMetadata { get; set; }

        public bool AcknowledgeReasonRequiredToProceed { get; set; }
        public IEnumerable<CareSelectAcknowledgementReason> AcknowledgementReasons { get; set; }

        public IEnumerable<string> Warnings { get; set; }
    }
}
