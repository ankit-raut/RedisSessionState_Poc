using Redis.Utilities.SessionConfiguration;

using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace Redis.Utilities.Helper
{
    public static class SessionHelper
    {
        public static bool IsNotNull(object value)
          => !Equals(value, null);
        public static bool IsNull(object value)
          => Equals(value, null);

        public static void SaveDataInSession<T>(string key, T value)
        {
            switch (GetSessionStateMode())
            {
                case SessionStateMode.Custom:
                case SessionStateMode.SQLServer:
                    SaveInSessionByDataType(key, value);
                    break;

                default:
                    if (IsNotNull(HttpContext.Current.Session))
                        HttpContext.Current.Session[key] = value;
                    break;
            }
        }

        public static T GetDataFromSession<T>(string key)
        {
            switch (GetSessionStateMode())
            {
                case SessionStateMode.Custom:
                case SessionStateMode.SQLServer:
                    // for other modes(SQL or State server or any custom) and generic data type is list of dynamic ,conditional deserialization would be required.
                    if (typeof(T) == typeof(List<dynamic>))
                    {
                        ApplicationSessionConfiguration applicationSessionConfiguration = new ApplicationSessionConfiguration();
                        return (T)(object)applicationSessionConfiguration.GetDeSerializeExpandoData(Convert.ToString(HttpContext.Current.Session[key]));
                    }
                    else
                    {
                        ApplicationSessionConfiguration applicationSessionConfiguration = new ApplicationSessionConfiguration();
                        return applicationSessionConfiguration.GetDeSerializeData<T>(Convert.ToString(HttpContext.Current.Session[key]));
                    }

                default:
                    var o = HttpContext.Current?.Session?[key];
                    if (o is T)
                        return (T)o;
                    break;
            }

            return default(T);
        }

        public static void RemoveDataFromSession(string key)
        {
            var obj = GetDataFromSession<object>(key);
            if (IsNull(obj)) return;

            HttpContext.Current.Session.Remove(key);
        }

        //This method handle grid filter related issue, due to list of dynamic type unable to deserialize from saved data in session, when session state is sql server.
        private static void SaveInSessionByDataType<T>(string key, T value)
        {
            ApplicationSessionConfiguration applicationSessionConfiguration = new ApplicationSessionConfiguration();
            string sessionValue = string.Empty;
            //Only in other mode(SQL or State server or any custom) and generic type is list of dynamic.
            if (typeof(T) == typeof(List<dynamic>))
            {
                List<ExpandoObject> listExpObj = ((List<dynamic>)(object)value).Select(d => d as ExpandoObject).ToList();
                sessionValue = applicationSessionConfiguration.GetSerializedData<List<ExpandoObject>>(listExpObj);
            }
            else
            {
                sessionValue = applicationSessionConfiguration.GetSerializedData<T>(value);
            }
            HttpContext.Current.Session[key] = sessionValue;
        }

        public static SessionStateMode GetSessionStateMode() => IsNull(HttpContext.Current?.Session) ? SessionStateMode.InProc : HttpContext.Current.Session.Mode;
    }
}
