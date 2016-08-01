using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareSelectModels.Version5.Requests.Sessions
{
    public class PointOfCare
    {
        public Department Department { get; set; }
        public PointOfCareEntity Location { get; set; }
        public PointOfCareEntity ServiceArea { get; set; }
        public PointOfCareEntity Organization { get; set; }
    }
}
