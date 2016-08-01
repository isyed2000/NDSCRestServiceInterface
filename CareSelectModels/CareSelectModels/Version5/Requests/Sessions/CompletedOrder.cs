using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareSelectModels.Version5.Requests.Sessions
{
    public class CompletedOrder
    {
        public IEnumerable<Coding> Codes { get; set; }
        public string Name { get; set; }
        public DateTime? EffectiveDateTime { get; set; }
        public IEnumerable<ComponentResult> ComponentResults { get; set; }
        public string OrderType { get; set; }
        public string ReferenceId { get; set; }
        public string Narrative { get; set; }
        public string Impression { get; set; }
    }
}
