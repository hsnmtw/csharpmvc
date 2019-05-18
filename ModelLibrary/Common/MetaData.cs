using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Common {
    /// <summary>
    /// meta data of collection of models
    /// </summary>
    public struct MetaData {
        /// <summary>
        /// the list of fields that make up the model
        /// </summary>
        /// <returns></returns>
        public string[] GetFields => (from propinfo in GetModelType.GetProperties() orderby propinfo.Name select propinfo.Name).ToArray();
        /// <summary>
        /// the source of data to populate the model
        /// </summary>
        /// <returns>eg. Database table from/to which data is stored</returns>
        public string GetSource { get; set; }
        /// <summary>
        /// get list of fields that collectively make the primary key.
        /// this should be used to verify uniqueness
        /// </summary>
        /// <returns>list of fields names that are part of the primary key</returns>
        public string[] GetPrimaryKeyFields { get; set; }
        /// <summary>
        /// get list of fields that are marked UNIQUE.
        /// this should be used to verify uniqueness
        /// </summary>
        /// <returns>list of fields names that are marked UNIQUE</returns>
        public string[] GetUniqueKeyFields { get; set; }
        /// <summary>
        /// gets the list of properties/fields that are mandatory
        /// this should be used for validation before saving a model
        /// to the source, e.g. <pre>GetSource()</pre>, that such fields
        /// contain data in them, i.e. NOT NULL
        /// </summary>
        /// <returns>list of fields names that are marked REQUIRED</returns>
        public string[] GetRequiredFields { get; set; }
        /// <summary>
        /// the type of the model for this collection
        /// </summary>
        public Type GetModelType { get; set; }
    }
}
