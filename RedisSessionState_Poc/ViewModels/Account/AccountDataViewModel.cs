using RedisSessionState_Poc;

using RedisSessionState_Poc.Models;

namespace RedisSessionState_Poc.ViewModels
{
    public class AccountDataViewModel : BaseViewModel
    {
        public AccountViewModel CompanyAccount { get; set; }

        public GridModel GridModel { get; set; }

        public int AccountId { get; set; }
        public bool HasParentAccounts { get; set; }
    }
}