using MVCHIS.Common;
using System;
using System.Collections.Generic;

namespace MVCHIS.Tools {
    //[ForModel(MODELS.DateConversion)]
    public class DateConversionEntity : AbstractDBEntity<DateConversionModel> {

        public override MetaData MetaData => new MetaData() {
              PrimaryKeyField = "Id" 
            , Fields          = new HashSet<string> { "CreatedBy", "CreatedOn", "Id", "ReadOnly", "UpdatedBy", "UpdatedOn",
                                                      "GregorianDate", "GregorianYear", "HijriYear", "HijriMonth","HijriDay" }
            , RequiredFields  = new HashSet<string> { "Id", "GregorianDate", "GregorianYear", "HijriYear", "HijriMonth", "HijriDay" }
            , UniqueKeyFields = new HashSet<HashSet<string>> { new HashSet<string> { "GregorianDate" } }
            , ForeignKeys     = new Dictionary<string, Tuple<MODELS, string>> {
            }
            , Sizes = new Dictionary<string, int> {
                ["CreatedBy"]  = 10,
                ["UpdatedBy"]  = 10,
            }
            , Source = ENTITIES.DateConversion
            };
    }
}