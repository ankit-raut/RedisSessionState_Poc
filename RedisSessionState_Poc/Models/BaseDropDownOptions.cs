namespace RedisSessionState_Poc.Models
{
    public class BaseDropDownOptions : BaseViewModel
    {
        public string Text { get; set; }
        public string Value { get; set; }
        public string Id { get; set; }
        public string Type { get; set; }
        public bool Status { get; set; }
        public bool CustomStatus { get; set; }
        public int PortalPaymentGroupId { get; set; }
        public bool IsSelected { get; set; }
        public string PaymentExternalId { get; set; }
        public bool IsAllowedWithOtherPayment { get; set; }
        public int? PaymentGatewayId { get; set; }
        public string GatewayCode { get; set; }
        public bool IsTaxExempt { get; set; }              
        public decimal? PaymentOrderLimit { get; set; }
    }
}