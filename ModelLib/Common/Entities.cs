using System;

namespace MVCHIS.Common {
    [Serializable]
    [Flags]
    public enum Entities {
          BillingCategory
        , AccommClass
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
        , Contact,
        ClientContact,
        ClientIdentification
    }
}
