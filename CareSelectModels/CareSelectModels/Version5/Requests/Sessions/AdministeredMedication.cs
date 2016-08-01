using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareSelectModels.Version5.Requests.Sessions
{
    public class AdministeredMedication
    {
        public bool Active { get; set; }
        public IEnumerable<Coding> Codes { get; set; }
        public DateTime EffectiveDateTime { get; set; }
        public string Value { get; set; }
        public string Unit { get; set; }
    }
}
