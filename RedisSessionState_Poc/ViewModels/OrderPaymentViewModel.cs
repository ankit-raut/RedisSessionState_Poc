
namespace RedisSessionState_Poc.ViewModels
{
    public class OrderPaymentViewModel: BaseViewModel
    {
        public int? PaymentTypeId { get; set; }
        public int? PaymentSettingId { get; set; }
        public string PaymentDisplayName { get; set; }
        public decimal Amount { get; set; }
        public string PaymentCode { get; set; }
        public string PaymentType { get; set; }
        public string CustomerProfileId { get; set; }
        public string CustomerPaymentId { get; set; }
        public string CustomerShippingAddressId { get; set; }
        public string CustomerGuid { get; set; }
        public string CreditCardNumber { get; set; }
        public string PaymentToken { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public string PoDocument { get; set; }
    }
}
