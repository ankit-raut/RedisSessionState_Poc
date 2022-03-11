using System.Collections.Generic;
using RedisSessionState_Poc.Models;

namespace RedisSessionState_Poc.ViewModels
{
    public class TemplateListViewModel : BaseViewModel
    {
        public List<TemplateViewModel> List { get; set; }
        public GridModel GridModel { get; set; }
        public string RoleName { get; set; }
    }
}