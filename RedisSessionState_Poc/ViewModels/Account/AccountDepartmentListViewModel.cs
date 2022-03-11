using System.Collections.Generic;
using RedisSessionState_Poc.Models;

namespace RedisSessionState_Poc.ViewModels
{
    public class AccountDepartmentListViewModel : BaseViewModel
    {
        public List<AccountDepartmentViewModel> Departments { get; set; }
        public int AccountId { get; set; }
        public string AccountName { get; set; }
        public bool HasParentAccounts { get; set; }
        public GridModel GridModel { get; set; }
    }
}