using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedisSessionState_Poc;

namespace RedisSessionState_Poc.ViewModels
{
    public class WidgetMediaViewModel : BaseViewModel
    {
        public int ContentPageId { get; set; }
        public string WidgetsKey { get; set; }
        public string TypeOFMapping { get; set; }
        public int MappingId { get; set; }
        public string MediaPath { get; set; }
        public string DisplayName { get; set; }
    }
}
