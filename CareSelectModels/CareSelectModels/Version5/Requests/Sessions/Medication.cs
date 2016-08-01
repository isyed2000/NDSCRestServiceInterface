using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareSelectModels.Version5.Requests.Sessions
{
    public class Medication
    {
        public bool Active { get; set; }
        public IEnumerable<Coding> Codes { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string OrderedDose { get; set; }
        public string Route { get; set; }
        public string Frequency { get; set; }
        public IEnumerable<AdministeredMedication> AdministeredMedications { get; set; }
    }
}
