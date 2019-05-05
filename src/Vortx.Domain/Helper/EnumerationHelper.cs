using System;
using System.ComponentModel;
using System.Reflection;

namespace Vortx.Domain.Helper
{
    public static class EnumerationHelper
    {
        public static string GetDescriptionName(Enum anyEnum)
        {
            FieldInfo fi = anyEnum.GetType().GetField(anyEnum.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute),
                false);

            if (attributes != null &&
                attributes.Length > 0)
                return attributes[0].Description;
            else
                return anyEnum.ToString();
        }
    }
}
