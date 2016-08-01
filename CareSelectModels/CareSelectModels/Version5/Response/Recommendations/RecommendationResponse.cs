using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareSelectModels.Version5.Response.Recommendations
{
    public class RecommendationResponse
    {
        public CareSelectRecommendation Recommendation { get; set; }
        public BasicPatientInfo Patient { get; set; }
    }
}
