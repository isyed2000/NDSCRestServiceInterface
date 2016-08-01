using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareSelectModels.Version5.Response.Recommendations
{
    public class OrderSpecificWarning
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
        public string Source { get; set; }
        public int Severity { get; set; }
    }
}
