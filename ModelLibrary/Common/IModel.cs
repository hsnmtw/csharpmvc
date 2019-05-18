using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Common {

    public interface IModel {
        /// <summary>
        /// converts model to object array populating its properties 
        /// in the same order of the fields selected
        /// </summary>
        /// <param name="fields">list of fields to be populated in the object array</param>
        /// <returns>object array containing object's properties</returns>
        object[] ToObjectArray(string[] fields);
    }
}
