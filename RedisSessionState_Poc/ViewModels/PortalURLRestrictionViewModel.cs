using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using RedisSessionState_Poc;

using RedisSessionState_Poc;

namespace Znode.Engine.Admin.ViewModels
{

    public class PortalURLRestrictionViewModel : BaseViewModel
    {
        public int PortalURLRestrcitionID { get; set; }

        public int PortalId { get; set; }

        public string PortalName { get; set; }

        public bool EnableURLRestriction { get; set; }

        public List<URLorIPRestrictionViewModel> uRLorIPRestrictionList { get; set; }
    }
}
