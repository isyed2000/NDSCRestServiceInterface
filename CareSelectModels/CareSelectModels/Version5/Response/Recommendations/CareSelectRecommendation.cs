using CareSelectModels.Version5.Response.Indications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareSelectModels.Version5.Response.Recommendations
{
    public class CareSelectRecommendation
    {
        public RecommendationDisplayInfo DisplayInfo { get; set; }
        public IEnumerable<Indication> Indications { get; set; }
        public IEnumerable<RecommendationResult> Results { get; set; }
        public IEnumerable<RecommendationSupportingContent> SupportingContent { get; set; }
        public IEnumerable<OrderSpecificWarning> OrderSpecificWarnings { get; set; }
    }
}
