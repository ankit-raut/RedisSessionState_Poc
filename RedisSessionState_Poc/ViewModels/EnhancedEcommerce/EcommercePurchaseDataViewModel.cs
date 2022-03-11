﻿using System.Collections.Generic;

namespace RedisSessionState_Poc.ViewModels
{
    public class EcommercePurchaseDataViewModel
    {
        public string OrderNumber { get; set; }
        public decimal? Total { get; set; }
        public decimal TaxCost { get; set; }
        public decimal ShippingCost { get; set; }
        public string CouponCode { get; set; }
        public List<EcommercePurchasedProductsViewModel> PurchasedProducts { get; set; }
    }
}