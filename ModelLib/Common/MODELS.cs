using System;

namespace MVCHIS.Common {
    [Serializable]
    [Flags]
    public enum MODELS {
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
        , Contact
        , ClientContact
        , ClientIdentification
        , BillingCycle
        , Contract
        , Service
        , Currency
        , VAT
        , City
        , DateConversion
    }
}
