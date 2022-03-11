using System.Web.Mvc;

namespace RedisSessionState_Poc.ViewModels
{
    public class RegisterViewModel : BaseViewModel//, IValidatableObject
    {
        public string Email { get; set; }

        public string UserName { get; set; }

        
        
        public string Password { get; set; }
        
        public string ReTypePassword { get; set; }

        public bool EmailOptIn { get; set; }

        public bool IsWebStoreUser { get; set; }
        
        public string StoreName { get; set; }
        
        public string ExternalId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        [AllowHtml]
        public string Custom1 { get; set; }
        public string Custom2 { get; set; }
        public string Custom3 { get; set; }
        public string Custom4 { get; set; }
        public string Custom5 { get; set; }
        public UserVerificationTypeEnum UserVerificationTypeCode { get; set; }
        public string BaseUrl { get; set; }
        public int ErrorCode { get; set; }
    }
}