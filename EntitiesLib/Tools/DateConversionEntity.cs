using MVCHIS.Common;
using System;
using System.Collections.Generic;

namespace MVCHIS.Tools {
    //[ForModel(MODELS.DateConversion)]
    public class DateConversionEntity : AbstractDBEntity<DateConversionModel> {

        public override MetaData MetaData => new MetaData() {
            //  ModelType       = typeof(DateConversionModel)
              PrimaryKeyField = "Id" 
            , Fields          = new HashSet<string> { "CreatedBy", "CreatedOn", "Id", "ReadOnly", "UpdatedBy", "UpdatedOn",
                                                      "GregorianDate", "GregorianYear", "HijriYear", "HijriMonth","HijriDay" }
            , RequiredFields  = new HashSet<string> { "Id", "GregorianDate", "GregorianYear", "HijriYear", "HijriMonth", "HijriDay" }
            , UniqueKeyFields = new HashSet<HashSet<string>> { new HashSet<string> { "GregorianDate" } }
            , ForeignKeys     = new Dictionary<string, Tuple<string, string>> {
            }
            , Sizes = new Dictionary<string, int> {
                ["CreatedBy"]  = 10,
                ["UpdatedBy"]  = 10,
            }
            , Source = "ToolsDateConversion"
            };
    }
}
//CREATE TABLE ToolsDateConversion(CreatedBy VARCHAR(10) ,CreatedOn DATETIME, ReadOnly CHAR(1) ,UpdatedBy VARCHAR(10) ,UpdatedOn DATETIME, GregorianDate DATETIME NOT NULL,GregorianYear INTEGER NOT NULL, HijriYear INTEGER NOT NULL,HijriMonth INTEGER NOT NULL, HijriDay INTEGER NOT NULL,Id INTEGER IDENTITY(1,1) NOT NULL);
