using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Common {
    [Serializable]
    [Flags]
    public enum Entities {
          AccomCategory
        , AccomClass
        , Audit                 
        , Building
        , BuildingType
        , Client
        , ClientType
        , Compound              
        , Entitlement     
        , FoodClass
        , Nationality           
        , Profile               
        , ProfileEntitlement  
        , Project
        , Room                  
        , User          
        
    }
}
