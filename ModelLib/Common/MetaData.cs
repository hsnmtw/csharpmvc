using System;
using System.Collections.Generic;
using System.Linq;

namespace MVCHIS.Common {
    /// <summary>
    /// meta data of collection of models
    /// </summary>
    public struct MetaData {
        /// <summary>
        /// the list of fields that make up the model
        /// </summary>
        /// <returns></returns>
        public HashSet<string> Fields { get; set; }//=> (from propinfo in ModelType.GetProperties() orderby propinfo.Name select propinfo.Name).ToArray();
        public Dictionary<string, Tuple<MODELS,string>> ForeignKeys { get; set; }

        public Dictionary<string, int> Sizes  {get;set;}
        /// <summary>
        /// the source of data to populate the model
        /// </summary>
        /// <returns>eg. Database table from/to which data is stored</returns>
        public string Source { get; set; }
        /// <summary>
        /// gets the name of the primary key field.
        /// this should be used to verify uniqueness
        /// </summary>
        /// <returns>list of fields names that are part of the primary key</returns>
        public string PrimaryKeyField { get; set; }
        /// <summary>
        /// get list of fields that are marked UNIQUE.
        /// this should be used to verify uniqueness
        /// </summary>
        /// <returns>list of fields names that are marked UNIQUE</returns>
        public HashSet<HashSet<string>> UniqueKeyFields { get; set; }
        /// <summary>
        /// gets the list of properties/fields that are mandatory
        /// this should be used for validation before saving a model
        /// to the source, e.g. <pre>GetSource()</pre>, that such fields
        /// contain data in them, i.e. NOT NULL
        /// </summary>
        /// <returns>list of fields names that are marked REQUIRED</returns>
        public HashSet<string> RequiredFields { get; set; }
    }
}
