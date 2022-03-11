using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using RedisSessionState_Poc.Models;


namespace RedisSessionState_Poc.ViewModels
{
    public class AccountQuoteListViewModel : BaseViewModel
    {
        public int AccountId { get; set; }
        public int UserId { get; set; }

        public int OmsOrderStateId { get; set; }

        public List<AccountQuoteViewModel> AccountQuotes { get; set; }
        public List<SelectListItem> OrderStatusList { get; set; }
        public GridModel GridModel { get; set; }

        public bool HasParentAccounts { get; set; }
        public string AccountName { get; set; }
        public string PermissionCode { get; set; }

        public bool IsPendingApprovalHistory { get; set; }
    }
}