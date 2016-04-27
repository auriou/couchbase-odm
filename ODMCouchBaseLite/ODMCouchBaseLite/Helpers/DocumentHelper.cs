using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ODMCouchBaseLite.Helpers
{
    public static class DocumentHelper
    {

        private static T GetTypedObject<T>(object obj)
        {
            return obj is T ? (T)obj : JsonConvert.DeserializeObject<T>(obj.ToString());
        }

        public static T GetObject<T>(IDictionary<string, object> dict)
        {
            return (T)GetObject(dict, typeof(T));
        }

        public static object GetObject(IDictionary<string, object> dict, Type type)
        {
            var obj = Activator.CreateInstance(type);

            foreach (var kv in dict)
            {
                var prop = type.GetProperty(kv.Key);
                if (prop == null) continue;

                object value = kv.Value;
                if (value is Dictionary<string, object>)
                {
                    value = GetObject((Dictionary<string, object>)value, prop.PropertyType);
                }

                prop.SetValue(obj, value, null);
            }
            return obj;
        }
    }
}