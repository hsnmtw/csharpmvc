using System.Data;

namespace ModelLibrary.Common {
    public struct ResultSet {
        public DataTable Table { get; set; }
        public int RowsCount { get; set; }
        public int Page { get; set; }
        public int Pages { get; set; }
        public int PageSize { get; set; }
        public bool Status { get; set; }
        public string ResponseMessage { get; set; }
    }
}