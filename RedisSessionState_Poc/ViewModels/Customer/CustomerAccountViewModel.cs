using System.Collections.Generic;
using System.Web.Mvc;

namespace RedisSessionState_Poc.ViewModels
{
    public class CustomerAccountViewModel : CustomerViewModel
    {
        public List<SelectListItem> AccountDepartmentList { get; set; }
        
    }
}