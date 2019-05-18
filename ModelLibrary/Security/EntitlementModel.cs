﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary.Common;

namespace ModelLibrary.Security
{
    public class EntitlementModel : BaseModel
    {
        public String Entitlement_Name { get; set; }

        public override string[] GetFields() => new string[]{
            "Entitlement_Name",
            "Id","Created_By","Created_On","Updated_By","Updated_On" };
        public override string[] GetPrimaryKeyFields() => "Id".Split(',');
        public override string[] GetRequiredFields() => "Id,Entitlement_Name".Split(',');
        public override string GetSource() => "Security_Entitlements";
        public override string[] GetUniqueKeyFields() => "Entitlement_Name".Split(',');
    }
}
