using CareSelectModels.Version5.Requests.Sessions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareSelectModels.Version5.Requests.Orders
{
    public class OrderInformation
    {
        public string OrderId { get; set; }
        public OrderEntryMode? OrderEntryMode { get; set; }

        public IEnumerable<Problem> OrderDiagnoses { get; set; }

        public IEnumerable<OrderQuestion> OrderSpecificQuestions { get; set; }

        public User OrderingUser { get; set; }
        public Provider OrderingProvider { get; set; }
        public Provider AuthorizingProvider { get; set; }
    }
}
