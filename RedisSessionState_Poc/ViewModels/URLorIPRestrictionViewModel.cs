using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using RedisSessionState_Poc;


namespace Znode.Engine.Admin.ViewModels
{

    public class URLorIPRestrictionViewModel : BaseViewModel
    {
        public int URLRestrictionId { get; set; }

        public string RestrictedURLorIP { get; set; }

        public bool IsGlobalURLorIP { get; set; }
    }
}
