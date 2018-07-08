using System;
using System.ComponentModel;

namespace WebScraping.Extensions
{
    public static class EnumExtension
    {
        public static string GetDescription<T>(this T value) where T : struct, IConvertible
        {
            var type = typeof(T);
            var memInfo = type.GetMember(value.ToString());
            var attributes = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
            return ((DescriptionAttribute)attributes[0]).Description;
        }
    }
}
