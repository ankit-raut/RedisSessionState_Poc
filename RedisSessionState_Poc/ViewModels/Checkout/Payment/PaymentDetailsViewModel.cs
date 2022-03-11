using System.ComponentModel.DataAnnotations;
using System.Web;


namespace RedisSessionState_Poc.ViewModels
{
    public class PaymentDetailsViewModel : BaseViewModel
    {
        public string GatewayName { get; set; }
        public int? PaymentProfileId { get; set; }
        public string Total { get; set; }
        public int PaymentApplicationSettingId { get; set; }
        public int IsCreditCardEnabled { get; internal set; }

        //These properties will use only for 'Purchase Order(PO)' Payemt Type.
        public bool IsPoDocUploadEnable { get; set; }
        public bool IsPoDocRequire { get; set; }
        public bool IsBillingAddressOptional { get; set; }

        public string PurchaseOrderNumber { get; set; }

        public HttpPostedFileBase PODocument { get; set; }
        public string GatewayCode { get; set; }
        public string PaymentCode { get; set; }
    }
}