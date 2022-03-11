using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedisSessionState_Poc.Models;

namespace RedisSessionState_Poc.ViewModels
{
    public class ECertificateListViewModel : BaseViewModel
    {
        public List<ECertificateViewModel> List { get; set; }
        public ECertificateListViewModel()
        {
            List = new List<ECertificateViewModel>();
            GridModel = new GridModel();
        }

        public GridModel GridModel { get; set; }
    }
}
