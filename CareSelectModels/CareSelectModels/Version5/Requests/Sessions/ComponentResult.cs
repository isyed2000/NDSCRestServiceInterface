using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareSelectModels.Version5.Requests.Sessions
{
    public class ComponentResult
    {
        public IEnumerable<Coding> Codes { get; set; }
        public string ComponentName { get; set; }
        public DateTime? EffectiveDateTime { get; set; }
        public string ResultValue { get; set; }
        public string ResultUnit { get; set; }
        public string ReferenceRange { get; set; }
        public string Status { get; set; }
    }
}
