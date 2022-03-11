using Newtonsoft.Json;

using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace Redis.Utilities.SessionConfiguration
{
    public class ApplicationSessionConfiguration
    {
        public string GetSerializedData<T>(T tClass) => JsonConvert.SerializeObject(tClass, Formatting.None, new JsonSerializerSettings
        {
            DefaultValueHandling = DefaultValueHandling.Ignore
        });

        public T GetDeSerializeData<T>(string sessionString)
        {
            if (!string.IsNullOrWhiteSpace(sessionString))
                return JsonConvert.DeserializeObject<T>(sessionString);

            return default(T);
        }

        public List<dynamic> GetDeSerializeExpandoData(string sessionString)
        {
            if (!string.IsNullOrWhiteSpace(sessionString))
            {
                List<ExpandoObject> list = JsonConvert.DeserializeObject<List<ExpandoObject>>(sessionString);
                return list.Select(d => d as dynamic).ToList();
            }
            return default(List<dynamic>);
        }
    }
}
