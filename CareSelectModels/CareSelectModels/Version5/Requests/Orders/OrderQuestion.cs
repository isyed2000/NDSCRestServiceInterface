using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareSelectModels.Version5.Requests.Orders
{
    public class OrderQuestion
    {
        public string QuestionId { get; set; }
        public string Description { get; set; }
        public OrderAnswer Answer { get; set; }
        public ExamSpecificQuestionFieldTypes FieldType { get; set; }
    }
}
