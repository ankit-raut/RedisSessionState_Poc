namespace RedisSessionState_Poc.ViewModels
{
    public class TemplateCartItemViewModel : CartItemViewModel
    {        
        public int OmsTemplateLineItemId { get; set; }
        public int? ParentOmsTemplateLineItemId { get; set; }
        public int OmsTemplateId { get; set; }
        public bool IsQuickOrderPad { get; set; }
        
        public string TemplateName { get; set; }
        
        public string SEODescription { get; set; }
        
        public string SEOKeywords { get; set; }
        
        public string SEOTitle { get; set; }
        public string SEOUrl { get; set; }
    }
}