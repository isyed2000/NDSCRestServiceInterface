using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareSelectModels.Version5.Response.Indications
{
    public class IndicationListResponse 
    {
        public int ResultSize { get; set; }
        public List<Indication> Indications { get; set; }
    }
}
