using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareSelectModels.Version5.Requests.Sessions
{
    public class Department
    {
        public string PointOfCareId { get; set; }
        public string Name { get; set; }
        public string TypeId { get; set; }
        public string TypeName { get; set; }
    }
}
