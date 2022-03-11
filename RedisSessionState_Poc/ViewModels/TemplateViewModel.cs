using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace RedisSessionState_Poc.ViewModels
{
    public class TemplateViewModel : BaseViewModel
    {
        public string TemplateName { get; set; }
        public int UserId { get; set; }
        public List<TemplateCartItemViewModel> TemplateCartItems { get; set; }
        public int OmsTemplateId { get; set; }
        public int PortalId { get; set; }
        public int LocaleId { get; set; }
        public int PublishedCatalogId { get; set; }
        
        public string OmsTemplateLineItemId { get; set; }
        public string CurrencyCode { get; set; }
        public int? Items { get; set; }
        public bool IsQuickOrderPad { get; set; }
        public bool IsViewMode { get; set; }
        
        public string CultureCode { get; set; }
    }
}