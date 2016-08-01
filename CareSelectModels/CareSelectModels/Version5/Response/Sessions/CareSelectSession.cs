using CareSelectModels.Version5.Requests.Sessions;
using CareSelectModels.Version5.Response.Indications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareSelectModels.Version5.Response.Sessions
{
    public class CareSelectSession
    {
        public string SessionId { get; set; }
        public List<Indication> Indications { get; set; }
        public string FreeTextIndication { get; set; }
        public string ExamId { get; set; }
        public string ExamName { get; set; }
        public int OriginalScore { get; set; }
        public string CustomerOrderId { get; set; }
        public Patient Patient { get; set; }
    }
}
