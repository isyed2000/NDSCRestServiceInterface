using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareSelectModels.Version5.Requests.Orders
{
    public class Order
    {
        public OrderInformation OrderInformation { get; set; }
        public IEnumerable<ReasonForExam> ReasonsForExam { get; set; }
        public string FreeTextReasonForExam { get; set; }

        public string ExamId { get; set; }
    }
}
