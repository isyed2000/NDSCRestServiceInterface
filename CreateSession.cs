using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
namespace NDSCRestServiceInterface
{
    [DataContract()]
    class CreateSession
    {
        [DataMember(Name="patient")]
        public Patient Patient { get; set; }
        [DataMember(Name="requestedOrders")]
        public RequestedOrder[] RequestedOrders { get; set; }
        [DataMember()]
        public PointOfCare PointOfCare = new PointOfCare();
    }

    [DataContract()]
    class Patient
    {
        [DataMember(Name="gender")]
        public string Gender{get;set;}
        [DataMember(Name="ageInYears")]
        public int AgeInYears{get;set;}

      
    }

    [DataContract()]
    public class RequestedOrder
    {
        [DataMember(Name="freeTextReasonForExam")]
        public string FreeTextReasonForExam{get;set;}
        [DataMember(Name="examId")]
        public string ExamId{get;set;}
        [DataMember(Name="orderDiagnosis")]
        public OrdereDiagnosis[] OrderDiagnosis;
    }

    public class OrdereDiagnosis
    {
        [DataMember(Name="codes")]
        public DiagnosisCode[] Codes{get;set;}

        }

    [DataContract()]
    public class DiagnosisCode
    {
        [DataMember(Name="codeSystem")]
        public string CodeSystem{get;set;}

        [DataMember(Name="code")]
        public string Code{get;set;}
    }

    [DataContract()]
    public class PointOfCare
    {
        [DataMember()]
        public Location Location = new Location();
    }

    [DataContract()]
    public class Location
    {

    }
       
}
