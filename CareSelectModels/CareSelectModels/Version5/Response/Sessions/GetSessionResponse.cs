using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareSelectModels.Version5.Response.Sessions
{
    public class GetSessionResponse
    {
        public OrderStatuses OrderStatus { get; set; }
        public Exam SelectedExam { get; set; }
    }

    public class Exam
    {
        public string Id { get; set; }
        public string Score { get; set; }
    }
}
