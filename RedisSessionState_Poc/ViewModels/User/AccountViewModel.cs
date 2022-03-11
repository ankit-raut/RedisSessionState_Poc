using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;


namespace RedisSessionState_Poc.ViewModels
{
    public class AccountViewModel : BaseViewModel
    {
        public int AccountId { get; set; }

        public string Name { get; set; }
        
        public string PhoneNumber { get; set; }

        public string ExternalId { get; set; }
        
        public string UserExternalId { get; set; }

        public int ParentAccountId { get; set; }
        
        public string ParentAccountName { get; set; }

        public List<SelectListItem> ParentAccountList { get; set; }
        public List<SelectListItem> CountryList { get; set; }
        
        public string AccountAddress { get; set; }
        public AddressViewModel Address { get; set; }
        public List<SelectListItem> Portals { get; set; }
        public int? PortalId { get; set; }
        
        public string RoleName { get; set; }
    }
}