using System;
using System.Collections.Generic;
using System.Text;

namespace DataForge.Extensions
{
    public static class ForgeEnumExtensions
    {
        public static T GetRandomEnumValue<T>(this T enumeration) where T : struct, Enum
        {
            var values = Enum.GetValues(typeof(T));
            var random = new Random();
            var randomEnumValue = (T)values.GetValue(random.Next(values.Length));
            return randomEnumValue;
        }
    }
}
