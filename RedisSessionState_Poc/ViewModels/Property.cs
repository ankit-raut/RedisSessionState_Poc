using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedisSessionState_Poc.ViewModels
{
    public class Property
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string CSSClass { get; set; }
        public string ControlType { get; set; }
        public string Value { get; set; }
        public string[] Values { get; set; }
        public string ControlLabel { get; set; }
        public bool IsDetailView { get; set; }
        public Dictionary<string, object> htmlAttributes { get; set; } = null;
        public List<SelectListItem> SelectOptions { get; set; } = null;
        public string HelpText { get; set; }
        public Property()
        {
            htmlAttributes = new Dictionary<string, object>();
        }

    }

    public enum ControlTypes
    {
        Date,
        Number,
        MultiSelect,
        Select,
        Text,
        TextArea,
        Label,
        YesNo,
        Image,
        SimpleSelect,
        Video,
        Audio,
        File
    }
}