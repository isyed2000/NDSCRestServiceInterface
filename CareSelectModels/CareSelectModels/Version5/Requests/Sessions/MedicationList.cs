using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareSelectModels.Version5.Requests.Sessions
{
    public class MedicationList
    {
        public IEnumerable<Medication> PriorMedications { get; set; }
        public IEnumerable<Medication> AdmissionMedicationOrders { get; set; }
    }
}
