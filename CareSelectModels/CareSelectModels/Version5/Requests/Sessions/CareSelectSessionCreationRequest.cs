using CareSelectModels.Version5.Requests.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareSelectModels.Version5.Requests.Sessions
{
    public class CareSelectSessionCreationRequest 
    {
        public Patient Patient { get; set; }

        public Insurance Insurance { get; set; }

        public IEnumerable<Problem> EncounterDiagnoses { get; set; }
        public IEnumerable<Problem> ProblemList { get; set; }
        public IEnumerable<CompletedOrder> OrderHistory { get; set; }
        public IEnumerable<Flowsheet> Flowsheets { get; set; }
        public MedicationList Medications { get; set; }
        public IEnumerable<Allergy> Allergies { get; set; }
        public IEnumerable<Note> Notes { get; set; }

        public PointOfCare PointOfCare { get; set; }

        public IEnumerable<Order> RequestedOrders { get; set; }
        public DateTime? EffectiveTime { get; set; }
    }
}
