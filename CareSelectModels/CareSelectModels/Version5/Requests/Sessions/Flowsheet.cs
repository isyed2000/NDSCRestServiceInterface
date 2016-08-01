using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareSelectModels.Version5.Requests.Sessions
{
    public class Flowsheet
    {
        public IEnumerable<Coding> Codes { get; set; }
        public string Name { get; set; }
        public DateTime TakenDateTime { get; set; }
        public DateTime EnteredDateTime { get; set; }
        public string ReadingValue { get; set; }
        public string ReadingUnit { get; set; }
    }
}
