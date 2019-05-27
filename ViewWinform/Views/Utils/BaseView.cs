using MVCWinform.Common;

namespace MVCWinform {
    interface BaseView<M> where M: BaseModel
    {
        M Model { get; set; }
    }
}
