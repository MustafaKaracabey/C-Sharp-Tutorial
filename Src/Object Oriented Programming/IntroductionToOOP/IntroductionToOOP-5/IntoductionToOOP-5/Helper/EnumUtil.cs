using System;

namespace IntoductionToOOP_5.Helper
{
    public static class EnumUtil
    {
        public static T ParseEnum<T>(string value)
        {
            return (T) Enum.Parse(typeof(T), value, true);
        }
    }
}