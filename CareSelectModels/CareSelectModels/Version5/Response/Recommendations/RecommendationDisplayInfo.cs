using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareSelectModels.Version5.Response.Recommendations
{
    public class RecommendationDisplayInfo
    {
        public bool ShowFeedback { get; set; }
        public string FeedbackUrl { get; set; }
        public string FeedbackHTML { get; set; }
    }
}
