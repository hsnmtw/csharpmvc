﻿using MVCHIS.Common;
using System;
using System.Collections.Generic;

namespace MVCHIS.Customers {
    //[ForModel(MODELS.Contact)]
    public class ContactEntity : AbstractDBEntity<ContactModel> {
        public override MetaData MetaData => new MetaData() {
            //  ModelType        = typeof(ContactModel)
              PrimaryKeyField  = "Id" 
            , Fields           = new HashSet<string> {"ReadOnly","Id","CreatedBy","CreatedOn","UpdatedBy","UpdatedOn",
                                                      "MobileNumber","Email","FaxNumber","PhoneNumber","FullName" }
            , RequiredFields   = new HashSet<string> { "Id", "MobileNumber", "FullName" }
            , UniqueKeyFields  = new HashSet<string> { "MobileNumber" }
            , ForeignKeys      = new Dictionary<string, Tuple<string, string>> {
            }
            , Sizes = new Dictionary<string, int> {
                 ["CreatedBy"   ] = 50
                ,["UpdatedBy"   ] = 50
                ,["MobileNumber"] = 15
                ,["Email"       ] = 100
                ,["FaxNumber"   ] = 15
                ,["PhoneNumber" ] = 15
                ,["FullName"    ] = 100
            }
            , Source           = "CustomersContact"            
        };
    }
}