using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Housing {
    public class BuildingModel : BaseModel {
        public string BuildingName { get; set; }
        public string BuildingType { get; set; }
        public string CompoundName { get; set; }
    }
}
