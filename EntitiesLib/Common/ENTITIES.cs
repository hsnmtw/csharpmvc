using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCHIS.Common {
    public class ENTITIES {

        // Billing
        //---------------------------------------------------------------------------------		 
        public static string AccommClass              => "BillingAccommClass";
        public static string BillingCategory          => "BillingCategory";
        public static string BillingCycle             => "BillingCycle";
        public static string Contract                 => "BillingContract";
        public static string Currency                 => "BillingCurrency";
        public static string CurrencyFXRate           => "BillingCurrencyFXRate";
        public static string FoodClass                => "BillingFoodClass";
        public static string FoodType                 => "BillingFoodType";
        public static string Reservation              => "BillingReservation";
        public static string Service                  => "BillingService";
        public static string VAT                      => "BillingVAT";

        // Housing
        //---------------------------------------------------------------------------------		 
        public static string Building                 => "HousingBuilding";
        public static string BuildingType             => "HousingBuildingType";
        public static string Compound                 => "HousingCompound";
        public static string Room                     => "HousingRoom" ;

        // Customers
        //---------------------------------------------------------------------------------		 
        public static string City                     => "CustomersCity";
        public static string Client                   => "CustomersClient";
        public static string ClientContact            => "CustomersClientContact";
        public static string ClientIdentification     => "CustomersClientIdentification";
        public static string ClientType               => "CustomersClientType";
        public static string Identification           => "CustomersIdentification";
        public static string IdentificationType       => "CustomersIdentificationType";
        public static string Project                  => "CustomersProject";
        public static string Contact                  => "CustomersContact";
        public static string Country                  => "CustomersCountry";

        // Security
        //---------------------------------------------------------------------------------		 
        public static string Audit                    => "SecurityAudit";
        public static string Entitlement              => "SecurityEntitlement";
        public static string EntitlementGroup         => "SecurityEntitlementGroup";
        public static string Profile                  => "SecurityProfile";
        public static string ProfileEntitlement       => "SecurityProfileEntitlement";
        public static string User                     => "SecurityUser";

        // Tools
        //---------------------------------------------------------------------------------
        public static string Entity                   => "ToolsEntity";
        public static string DateConversion           => "ToolsDateConversion";
        public static string Word                     => "ToolsWord";
        public static string Language                 => "ToolsLanguage";
        public static string WordLanguage             => "ToolsWordLanguage";
    }
}