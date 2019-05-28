using System;

namespace MVCWinform.Common {
    [Serializable]
    [Flags]
    public enum Entities {
          BillingCategory
        , AccomClass
        , Audit                 
        , Building
        , BuildingType
        , Client
        , ClientType
        , Compound    
        , Dictionary
        , Entitlement
        , EntitlementGroup
        , FoodClass
        , FoodType
        , Identification
        , IdentificationType
        , Country           
        , Profile               
        , ProfileEntitlement  
        , Project
        , Room                  
        , User
        , Entity
        , Contact
    }
}
