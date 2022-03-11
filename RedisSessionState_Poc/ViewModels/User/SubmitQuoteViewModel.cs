namespace RedisSessionState_Poc.ViewModels
{
    public class SubmitQuoteViewModel : SubmitPaymentViewModel
    {
        
        public string OmsOrderState { get; set; }
        
        public string OldOrderStatus { get; set; }
        public int QuoteId { get; set; }
        public int ShippingId { get; set; }
        
        public string AdditionalNotes { get; set; }
        public int? PaymentSettingId { get; set; }
        public bool IsPendingPayment { get; set; }
        public int UserId { get; set; }
        public int ShippingAddressId { get; set; }
        public int BillingAddressId { get; set; }
        public int ShippingOptionId { get; set; }
        
        public string ShippingOptionCode { get; set; }
        
        public string AdditionalInstruction { get; set; }
        public string PayPalToken { get; internal set; }
        public bool IsFromPayPalExpress { get; set; }
        
        public string PurchaseOrderNumber { get; set; }
        
        public string PODocumentName { get; set; }
        
        public string CreditCardNumber { get; set; }
        public decimal Total { get; set; }
        public decimal SubTotal { get; set; }
        
        public string AccountNumber { get; set; }
        
        public string ShippingMethod { get; set; }
        public bool IsFromAmazonPay { get; set; }
        
        public string CardType { get; set; }
        public int? CreditCardExpMonth { get; set; }
        public int? CreditCardExpYear { get; set; }
        public bool IsSendForApproval { get; set; }
        
        public string CardDetails { get; set; }
        public int PortalPaymentGroupId { get; set; }
        public bool IsTaxExempt { get; set; }
        
        public string BillingPostalCode { get; set; }
        public bool IsDisableStaplesPayAuthInPreview { get; set; }
        
        public string WebstorePublishState { get; set; }
    }
}