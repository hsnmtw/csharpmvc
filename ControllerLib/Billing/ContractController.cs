using System;
using MVCHIS.Common;

namespace MVCHIS.Billing {
    //[ForModel(MODELS.Contract, Enabled = true)]
    public class ContractController : AbstractDBController<ContractModel> {
        private ServiceController CntrlSR;
        public ContractController() : base() {
            CntrlSR = DBControllersFactory.Service();
        }

        public int DeleteService(int serviceId) {
            return CntrlSR.Delete(new ServiceModel { Id = serviceId });
        }
    }
}
