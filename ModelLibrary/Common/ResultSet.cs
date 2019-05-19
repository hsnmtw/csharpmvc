using System.Data;

namespace ModelLibrary.Common {
    public class ResultSet {
        public DataTable Table { get; set; }
        public int AffectedRows { get; set; }
        public bool Status { get; set; }
        public string ResponseMessage { get; set; }
    }
}