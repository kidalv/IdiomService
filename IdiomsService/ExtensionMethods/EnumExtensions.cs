using System;
using System.Collections.Generic;
using System.Linq;

namespace IdiomsService.ExtensionMethods
{
    public static class EnumExtensions
    {
        public static IEnumerable<T> GetEnumList<T, K, L>(this L type) where L : Type where K : Enum
        {
            var properties = typeof(T).GetProperties();
            return Enum.GetValues(type).Cast<K>()
            .Select(x =>
            {
                var obj = (T)Activator.CreateInstance(typeof(T));
                properties[0].SetValue(obj, Convert.ToInt32(x), null);
                properties[1].SetValue(obj, x.ToString(), null);
                return obj;
            });
        }
    }
}
