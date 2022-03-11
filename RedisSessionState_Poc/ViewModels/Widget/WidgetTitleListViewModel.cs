using System;
using System.Collections.Generic;

namespace RedisSessionState_Poc.ViewModels
{
    public class WidgetTitleListViewModel : BaseViewModel
    {
        public List<WidgetTitleViewModel> TitleList { set; get; }
        public bool IsImageRequired { get; set; } = false;

        public bool IsNewTab { get; set; }

        public bool IsEmpty
        {
            get
            {
                return TitleList?.Count > 0 ? false : true;

            }
        }
    }
}