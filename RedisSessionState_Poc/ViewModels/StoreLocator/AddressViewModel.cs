using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;


namespace RedisSessionState_Poc.ViewModels
{
    public class AddressViewModel : BaseViewModel
    {
        public int AddressId { get; set; }
        public int OtherAddressId { get; set; }
        public int AccountId { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string DisplayName { get; set; }


        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address3 { get; set; }

        public string CountryName { get; set; }

        public string StateName { get; set; }

        public string CityName { get; set; }

        public string PostalCode { get; set; }

        public string PhoneNumber { get; set; }

        public string EmailAddress { get; set; }

        
        public string Mobilenumber { get; set; }
        
        public string FaxNumber { get; set; }
        
        public string AlternateMobileNumber { get; set; }

        public bool IsActive { get; set; }

        public List<SelectListItem> Countries { get; set; }

        public bool IsDefaultBilling { get; set; }
        public bool IsShippingBillingDifferent { get; set; }
        public bool IsDefaultShipping { get; set; }

        public bool IsShipping { get; set; }
        public bool IsBilling { get; set; }
        public bool IsBothBillingShipping { get; set; }
        public bool UseSameAsShippingAddress { get; set; }

        public int UserId { get; set; }
        public int AccountAddressId { get; set; }
        
        public string RoleName { get; set; }
        public int AddressCount { get; set; }
        
        public string ExternalId { get; set; }
        public List<SelectListItem> States { get; set; }
        
        public string StateCode { get; set; }
        
        public string CompanyName { get; set; }
        public bool DontAddUpdateAddress { get; set; }
        public AddressViewModel()
        {
            Countries = new List<SelectListItem>();
            States = new List<SelectListItem>();
        }
    }
}