using System.Collections.Generic;
using RedisSessionState_Poc.Models;

namespace RedisSessionState_Poc.ViewModels
{

    public class VoucherListViewModel : BaseViewModel
    {
        public List<VoucherViewModel> List { get; set; }
        public VoucherListViewModel()
        {
            List = new List<VoucherViewModel>();
            GridModel = new GridModel();
        }

        public GridModel GridModel { get; set; }
    }
}