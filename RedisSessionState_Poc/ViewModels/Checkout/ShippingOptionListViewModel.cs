using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace RedisSessionState_Poc.ViewModels
{
    public class ShippingOptionListViewModel : BaseViewModel
    {
        public List<ShippingOptionViewModel> ShippingOptions { get; set; }
        public bool IsB2BUser { get; set; }
        public int OmsQuoteId { get; set; }
        public string AccountNumber { get; set; }
        public string ShippingMethod { get; set; }
        public string CustomerServicePhone { get; set; }
        public DateTime? InHandDate { get; set; }
        public ShippingOptionListViewModel()
        {
            ShippingOptions = new List<ShippingOptionViewModel>();
        }
    }
}