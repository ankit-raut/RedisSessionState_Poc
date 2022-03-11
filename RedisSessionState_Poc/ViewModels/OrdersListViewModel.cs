using System.Collections.Generic;
using RedisSessionState_Poc.Models;

namespace RedisSessionState_Poc.ViewModels
{
    //ToDo
    public class OrdersListViewModel : BaseViewModel
    {
        public List<OrdersViewModel> List { get; set; }
        public OrdersListViewModel()
        {
            List = new List<OrdersViewModel>();
            GridModel = new GridModel();
        }
       
        public GridModel GridModel { get; set; }
    }
}