using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareSelectModels.Version5.Requests.Sessions
{
    public class Problem
    {
        public IEnumerable<Coding> Codes { get; set; }
        public string ProblemName { get; set; }
        public DateTime? EnteredDateTime { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public string Status { get; set; }
    }
}
