﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareSelectModels.Version5.Response.Indications
{
    public class Indication
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<string> ICD10Codes { get; set; }
    }
}
