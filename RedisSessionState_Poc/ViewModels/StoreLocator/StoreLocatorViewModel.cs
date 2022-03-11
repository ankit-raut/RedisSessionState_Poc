using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;



namespace RedisSessionState_Poc.ViewModels
{
    public class StoreLocatorViewModel : BaseViewModel
    {
        public int AddressId { get; set; }
        public int PortalID { get; set; }

        public int Radius { get; set; }

        [Required]
        public string StoreName { get; set; }
        public int PortalAddressId { get; set; }
        public string MapQuestURL { get; set; }

        public List<SelectListItem> RadiusList { get; set; }
        public List<StoreLocatorViewModel> PortalList { get; set; }

        public string StateName { get; set; }

        public string CityName { get; set; }

        public string PostalCode { get; set; }
        
        public string Address1 { get; set; }
        
        public string Address2 { get; set; }
        
        public string Address3 { get; set; }
        
        public string PhoneNumber { get; set; }
        public decimal? Longitude { get; set; }
        public decimal? Latitude { get; set; }
    }
}