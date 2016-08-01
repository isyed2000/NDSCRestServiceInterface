using CareSelectModels.Version5.Response.Recommendations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareSelectModels.Version5.Response.Sessions
{
    public class CareSelectSessionsCreationResponse
    {
        public IEnumerable<CareSelectSessionCreationResponse> Responses { get; set; }
        public RecommendationDisplayInfo DisplayInfo { get; set; }
    }
}
