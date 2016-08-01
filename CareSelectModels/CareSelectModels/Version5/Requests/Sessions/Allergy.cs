using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareSelectModels.Version5.Requests.Sessions
{
    public class Allergy
    {
        public IEnumerable<Coding> Codes { get; set; }
        public string AllergenName { get; set; }
        public DateTime? EnteredDateTime { get; set; }
        public string Severity { get; set; }
        public string Reactions { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
    }
}
