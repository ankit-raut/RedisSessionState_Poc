using System.ComponentModel.DataAnnotations;


namespace RedisSessionState_Poc.ViewModels
{
    public class AccountDepartmentViewModel : BaseViewModel
    {
        public int DepartmentId { get; set; }

        public string DepartmentName { get; set; }
        public int AccountId { get; set; }
        public AccountViewModel CompanyAccount { get; set; }
        public int AccountIdToRedirect { get; set; }
    }
}