using System.Data;

namespace MVCHIS.Common {
    public interface IController {
        MetaData GetMetaData();
        DataTable GetData();
    }
}
