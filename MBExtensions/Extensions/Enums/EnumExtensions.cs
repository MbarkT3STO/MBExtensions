using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MBExtensions.Extensions.Enums
{
    public static class EnumExtensions
    {
        /// <summary>
        /// Get a <see cref="DisplayAttribute"/> Name's for an <see cref="Enum"/>
        /// </summary>
        /// <param name="enumValue">The enum value to get Display Name for</param>
        /// <returns><see cref="string"/></returns>
        public static string GetDisplayName(this Enum enumValue)
        {
            return enumValue.GetType().GetMember(enumValue.ToString()).First().GetCustomAttribute<DisplayAttribute>()?.GetName();
        }
    }
}
