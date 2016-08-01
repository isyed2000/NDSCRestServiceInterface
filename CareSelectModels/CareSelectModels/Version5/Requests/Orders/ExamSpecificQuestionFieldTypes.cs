using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareSelectModels.Version5.Requests.Orders
{
    public enum ExamSpecificQuestionFieldTypes
    {
        Text = 0,
        MultiSelect = 1,
        SingleSelect = 2,
        Numeric = 3,
        DateTime = 4,
        DateOnly = 5,
        Boolean = 6,
        Decimal = 7
    }
}
