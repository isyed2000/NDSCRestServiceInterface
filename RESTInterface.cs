using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace NDSCRestServiceInterface
{
    public partial class RESTInterface : Form
    {
        private GroupBox grpPatientDetails;
        private Panel btnStartSession;
        private Label lblDSN;
        private Label lblDSNNumber;
        private Label lblCurrentSessionID;
        private Button btnNewSession;
        private Label lblSessionId;
        private TextBox txtDOB;
        private Label label2;
        private ComboBox cboGender;
        private Label label1;
    
        public RESTInterface()
        {
            InitializeComponent();
        }

        private void RESTInterface_Load(object sender, EventArgs e)
        {
            Person p = new Person();
            p.FluentMethod(x => x.FirstName);
            ConnectWebClient();
        }

        private byte[] GetRequestData()
        {
            // System.IO.FileStream fs = new FileStream(@"C:\Users\siahmed\Documents\Documentation\projects\Lab Radiology CDS integration\NDSCRestServiceInterface\json1.json", FileMode.Open);
           // StreamReader sr = new StreamReader(fs);
           // string s = GetJson();
           //s = sr.ReadToEnd();
          //  sr.Close();
           // return System.Text.ASCIIEncoding.ASCII.GetBytes(s);
            return null;
        }

        private string GetJson(object data)
        {
            /*  CreateSession session = new CreateSession();
              session.Patient = new Patient() { AgeInYears = 45, Gender = "Female" };
              session.RequestedOrders = new RequestedOrder[1];
              session.RequestedOrders[0] = new RequestedOrder()
              {

                  ExamId = "70542",//"114053",
                  FreeTextReasonForExam = "Abnormal gait (ataxia)",
                  OrderDiagnosis = new OrdereDiagnosis[1]
              };

              session.RequestedOrders[0].OrderDiagnosis[0] = new OrdereDiagnosis();
              session.RequestedOrders[0].OrderDiagnosis[0].Codes = new DiagnosisCode[1];
              session.RequestedOrders[0].OrderDiagnosis[0].Codes[0] = new DiagnosisCode();
              session.RequestedOrders[0].OrderDiagnosis[0].Codes[0].Code = "R26.0";
              session.RequestedOrders[0].OrderDiagnosis[0].Codes[0].CodeSystem = "ICD 10";*/

            return Newtonsoft.Json.JsonConvert.SerializeObject(data, new Newtonsoft.Json.JsonSerializerSettings()
            {
                ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver()
            });
        }

        private void ConnectWebClient()
        {
            try
            {
                // Create a request for the URL. 	
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("https://testapi.careselect.org/v5/sessions");
                request.Method = "POST";
                 request.ContentType = "application/json";
                 request.Headers.Add("Authentication", GetUserNamePwd());
            
                 byte[] data = GetRequestData();

                 request.ContentLength = data.Length;
                Stream stream = request.GetRequestStream();
            
                stream.Write(data, 0, data.Length);
                // If required by the server, set the credentials.
                //request.Credentials = CredentialCache.DefaultCredentials;
               // Get the response.
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                // Display the status.
                Console.WriteLine(response.StatusDescription);
                // Get the stream containing content returned by the server.
                Stream dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                // Display the content.
                Console.WriteLine(responseFromServer);
                // Cleanup the streams and the response.
                reader.Close();
                dataStream.Close();
                response.Close();

              
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString()); ;
            }
            
        }

        private string GetUserNamePwd()
        {
            return System.Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes("userName:pwd"));
           

         
        }

        private void InitializeComponent()
        {
            this.grpPatientDetails = new System.Windows.Forms.GroupBox();
            this.btnStartSession = new System.Windows.Forms.Panel();
            this.lblDSN = new System.Windows.Forms.Label();
            this.lblDSNNumber = new System.Windows.Forms.Label();
            this.lblCurrentSessionID = new System.Windows.Forms.Label();
            this.btnNewSession = new System.Windows.Forms.Button();
            this.lblSessionId = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpPatientDetails.SuspendLayout();
            this.btnStartSession.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPatientDetails
            // 
            this.grpPatientDetails.BackColor = System.Drawing.Color.White;
            this.grpPatientDetails.Controls.Add(this.btnStartSession);
            this.grpPatientDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPatientDetails.Location = new System.Drawing.Point(12, 12);
            this.grpPatientDetails.Name = "grpPatientDetails";
            this.grpPatientDetails.Size = new System.Drawing.Size(998, 111);
            this.grpPatientDetails.TabIndex = 15;
            this.grpPatientDetails.TabStop = false;
            this.grpPatientDetails.Text = "General Details";
            // 
            // btnStartSession
            // 
            this.btnStartSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnStartSession.Controls.Add(this.lblDSN);
            this.btnStartSession.Controls.Add(this.lblDSNNumber);
            this.btnStartSession.Controls.Add(this.lblCurrentSessionID);
            this.btnStartSession.Controls.Add(this.btnNewSession);
            this.btnStartSession.Controls.Add(this.lblSessionId);
            this.btnStartSession.Controls.Add(this.txtDOB);
            this.btnStartSession.Controls.Add(this.label2);
            this.btnStartSession.Controls.Add(this.cboGender);
            this.btnStartSession.Controls.Add(this.label1);
            this.btnStartSession.Location = new System.Drawing.Point(11, 33);
            this.btnStartSession.Name = "btnStartSession";
            this.btnStartSession.Size = new System.Drawing.Size(972, 72);
            this.btnStartSession.TabIndex = 0;
            // 
            // lblDSN
            // 
            this.lblDSN.AutoSize = true;
            this.lblDSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSN.Location = new System.Drawing.Point(342, 49);
            this.lblDSN.Name = "lblDSN";
            this.lblDSN.Size = new System.Drawing.Size(29, 13);
            this.lblDSN.TabIndex = 24;
            this.lblDSN.Text = "TBD";
            // 
            // lblDSNNumber
            // 
            this.lblDSNNumber.AutoSize = true;
            this.lblDSNNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSNNumber.Location = new System.Drawing.Point(257, 49);
            this.lblDSNNumber.Name = "lblDSNNumber";
            this.lblDSNNumber.Size = new System.Drawing.Size(45, 13);
            this.lblDSNNumber.TabIndex = 23;
            this.lblDSNNumber.Text = "DSN#:";
            // 
            // lblCurrentSessionID
            // 
            this.lblCurrentSessionID.AutoSize = true;
            this.lblCurrentSessionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentSessionID.Location = new System.Drawing.Point(97, 49);
            this.lblCurrentSessionID.Name = "lblCurrentSessionID";
            this.lblCurrentSessionID.Size = new System.Drawing.Size(29, 13);
            this.lblCurrentSessionID.TabIndex = 22;
            this.lblCurrentSessionID.Text = "TBD";
            // 
            // btnNewSession
            // 
            this.btnNewSession.Location = new System.Drawing.Point(643, 14);
            this.btnNewSession.Name = "btnNewSession";
            this.btnNewSession.Size = new System.Drawing.Size(170, 29);
            this.btnNewSession.TabIndex = 18;
            this.btnNewSession.Text = "New Session";
            this.btnNewSession.UseVisualStyleBackColor = true;
            this.btnNewSession.Click += new System.EventHandler(this.btnNewSession_Click);
            // 
            // lblSessionId
            // 
            this.lblSessionId.AutoSize = true;
            this.lblSessionId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSessionId.Location = new System.Drawing.Point(12, 49);
            this.lblSessionId.Name = "lblSessionId";
            this.lblSessionId.Size = new System.Drawing.Size(72, 13);
            this.lblSessionId.TabIndex = 21;
            this.lblSessionId.Text = "Session ID:";
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(293, 14);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(166, 22);
            this.txtDOB.TabIndex = 17;
            this.txtDOB.Text = "1/1/1970";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(257, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "DOB:";
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Unknown"});
            this.cboGender.Location = new System.Drawing.Point(63, 10);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(146, 24);
            this.cboGender.TabIndex = 15;
            this.cboGender.Text = "Male";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Gender:";
            // 
            // RESTInterface
            // 
            this.ClientSize = new System.Drawing.Size(1208, 242);
            this.Controls.Add(this.grpPatientDetails);
            this.Name = "RESTInterface";
            this.Text = "Care Select REST Interface";
            this.Load += new System.EventHandler(this.RESTInterface_Load_1);
            this.grpPatientDetails.ResumeLayout(false);
            this.btnStartSession.ResumeLayout(false);
            this.btnStartSession.PerformLayout();
            this.ResumeLayout(false);

        }

        private void RESTInterface_Load_1(object sender, EventArgs e)
        {

        }

        private void btnNewSession_Click(object sender, EventArgs e)
        {
          CreateNewSession(cboGender.Items[cboGender.SelectedIndex].ToString(), DateTime.Parse(txtDOB.Text));
        }


        private void CreateNewSession(string gender, DateTime dob)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("https://testapi.careselect.org/v5/sessions");
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Headers.Add("Authentication", GetUserNamePwd());

            CareSelectModels.Version5.Requests.Sessions.CareSelectSessionCreationRequest newSession = new CareSelectModels.Version5.Requests.Sessions.CareSelectSessionCreationRequest();
            
            //set patient information.
            newSession.Patient = new CareSelectModels.Version5.Requests.Sessions.Patient() { Gender = "male", AgeInYears = (DateTime.Now.Year - dob.Year), Class = "InPatient" };

           //just wants to create the session.  No ordering information.
           /* var orders = new List<CareSelectModels.Version5.Requests.Orders.Order>();
            var order = new CareSelectModels.Version5.Requests.Orders.Order();
            order.ExamId = "70542";
            order.FreeTextReasonForExam = "Abnormal gait (ataxia)";
            order.OrderInformation = new CareSelectModels.Version5.Requests.Orders.OrderInformation();
            order.OrderInformation.OrderDiagnoses = new List<CareSelectModels.Version5.Requests.Sessions.Problem>();

            var problems = new List<CareSelectModels.Version5.Requests.Sessions.Problem>();
            var problem = new CareSelectModels.Version5.Requests.Sessions.Problem();

            var codes = new List<CareSelectModels.Version5.Requests.Sessions.Coding>();
            codes.Add(new CareSelectModels.Version5.Requests.Sessions.Coding() { Code = "R26.0", CodeSystem = "ICD 10" });
            problem.Codes = codes;
            
            problems.Add(problem);
            order.OrderInformation.OrderDiagnoses = problems;
            orders.Add(order);
            newSession.RequestedOrders = orders;
           */
            string jsonData = GetJson(newSession);
            byte[] data = System.Text.ASCIIEncoding.ASCII.GetBytes(jsonData);
            request.ContentLength = data.Length;
            Stream stream = request.GetRequestStream();
            stream.Write(data, 0, data.Length);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader sr = new StreamReader(dataStream);
            string jsonResponse = sr.ReadToEnd();
            
            dataStream.Close();
            response.Close();

            if (jsonResponse == "null")
            {
                throw new Exception("'null' was returned from the Rest Service");
            }
           
           /* var obj = GetObject<CareSelectModels.Version5.Response.Sessions.CareSelectSessionCreationResponse>(dataStream);*/
          
           /* m_SessionID = obj.CareSelectSession.SessionId;
            m_DSN = m_SessionID;
            */
        }

        private T GetObject<T>(Stream stream)
        {
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(T));
            return (T)jsonSerializer.ReadObject(stream);
        }

    }

    public class Person
    {
        public string FirstName;
        public string LastName;
        public Person FluentMethod< TProp>(System.Linq.Expressions.Expression<Func<Person, TProp>> propertyExpression)
        {
            return new Person();
        }
    }
}
