using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareSelectModels.Version5.Requests.Sessions
{
    public class InsuranceCoverage
    {
        public string CompanyName { get; set; }
        public string CompanyIdentifier { get; set; }
        public string PlanName { get; set; }
        public string PlanIdentifier { get; set; }
    }
}
