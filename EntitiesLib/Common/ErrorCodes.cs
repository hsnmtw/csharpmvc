using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatorLib.Common {
    public enum ErrorCodes {
        V_7001_NULL_OR_EMPTY_VALUE_IS_NOT_ACCEPTED    ,
        V_7002_DATE_MUST_BE_OF_TODAYS_DATE            ,
        V_7003_SPECIAL_CHARACTERS_AND_NUMERICS_IN_NAME,
        V_7004_FIELD_DOES_NOT_ACCEPT_ZERO_VALUES      ,
    }
}
