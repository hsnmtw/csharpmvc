using MVCHIS.Common;

namespace MVCHIS.Tools {


    public class ConfigurationDomainModel : BaseModel {
        public int ConfigurationTypeId { get; set; }
        public string DomainValue { get; set; }
    }
}
