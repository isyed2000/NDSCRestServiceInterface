using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareSelectModels.Version5.Requests.Orders
{
    public class Provider
    {
        public string ProviderId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Degree { get; set; }
        public string NPI { get; set; }
        public string SpecialtyCode { get; set; }
        public string SpecialtyName { get; set; }
    }
}
