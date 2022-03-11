using System.ComponentModel.DataAnnotations;


namespace RedisSessionState_Poc.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public string Username { get; set; }

        
        public string Password { get; set; }

        public bool RememberMe { get; set; }

        public bool IsResetPassword { get; set; }

        public string PasswordResetToken { get; set; }

        public int? PortalId { get; set; }

        public bool IsWebStoreUser { get; set; }

        public string ReturnUrl { get; set; }

        public bool IsSinglePageCheckout { get; set; }

        public bool IsFromSocialMedia { get; set; }

        public int? ErrorCode { get; set; }
    }
}