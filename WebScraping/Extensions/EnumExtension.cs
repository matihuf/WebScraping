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

        public static int GetIntEnumFromDescription(this string description, Type enumType)
        {
            return (int)GetEnumFromDescription(description, enumType);
        }

        public static byte GetByteEnumFromDescription(this string description, Type enumType)
        {
            return (byte)GetEnumFromDescription(description, enumType);
        }

        private static object GetEnumFromDescription(string description, Type enumType)
        {
            foreach (var field in enumType.GetFields())
            {
                DescriptionAttribute attribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
                if (attribute != null && attribute.Description.Equals(description))
                {
                    return field.GetValue(null);
                }
            }
            return 0;
        }
    }
}
