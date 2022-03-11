using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;


namespace RedisSessionState_Poc.ViewModels
{
    public class PromotionViewModel : BaseViewModel
    {
        public int PromotionId { get; set; }
        public string PromoCode { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int? PromotionTypeId { get; set; }

        public string PromotionTypeName { get; set; }
        
        public decimal? Discount { get; set; }

        public DateTime? TodaysDate { get; set; } = DateTime.Today;

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

      
        public decimal? OrderMinimum { get; set; }

        
        public decimal? QuantityMinimum { get; set; }

        public bool IsCouponRequired { get; set; }

        public int DisplayOrder { get; set; } = 99;

        public List<SelectListItem> PromotionTypeList { get; set; }

        public int PortalId { get; set; }

        public int ProfileId { get; set; }
        public string AssociatedShippingIds { get; set; }
    }
}