using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareSelectModels.Version5.Requests.Sessions
{
    public class Note
    {
        public string NoteType { get; set; }
        public string NoteText { get; set; }
        public DateTime EnteredDate { get; set; }
        public string UserName { get; set; }
    }
}
