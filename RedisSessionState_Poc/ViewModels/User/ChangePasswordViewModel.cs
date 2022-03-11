namespace RedisSessionState_Poc.ViewModels
{
    public class ChangePasswordViewModel : BaseViewModel
    {
        public string OldPassword { get; set; }

        
        public string NewPassword { get; set; }

        public string ReTypeNewPassword { get; set; }
        
        public string UserName { get; set; }
        public bool IsResetPassword { get; set; }
        public string PasswordToken { get; set; }
        //Getter setter to set for user is from webstore or from admin
        public bool IsWebStoreUser { get; set; }
    }
}