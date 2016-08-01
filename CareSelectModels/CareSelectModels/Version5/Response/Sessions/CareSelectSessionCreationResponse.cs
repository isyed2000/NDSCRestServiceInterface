using CareSelectModels.Version5.Response.Recommendations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareSelectModels.Version5.Response.Sessions
{
    public class CareSelectSessionCreationResponse
    {
        public CareSelectSession CareSelectSession { get; set; }
        public CareSelectRecommendation Recommendation { get; set; }
    }
}
