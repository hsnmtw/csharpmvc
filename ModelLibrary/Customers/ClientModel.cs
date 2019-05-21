using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Customers {
    public class ClientModel : BaseModel {
        public string Client_Type { get; set; }
        public string Short_Name   { get; set; }
        public string Long_Name   { get; set; }
        public string Email { get; set; }
        public string Fax_Number { get; set; }
        public string Billing_Address { get; set; }
        public string Phone_Number { get; set; }
        public string Contact_Person { get; set; }
    }
}
