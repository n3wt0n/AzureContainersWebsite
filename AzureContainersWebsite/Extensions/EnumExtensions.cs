using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace AzureContainersWebsite.Extensions
{
    public static class EnumExtensions
    {
        /// <summary>
        /// Generic extension to retrieve an Attribute from an Enum
        /// </summary>
        /// <typeparam name="TAttribute"></typeparam>
        /// <param name="enumValue"></param>
        /// <returns></returns>
        public static TAttribute GetAttribute<TAttribute>(this Enum enumValue) where TAttribute : Attribute
            => enumValue.GetType()
                            .GetMember(enumValue.ToString())
                            .First()
                            .GetCustomAttribute<TAttribute>();

        /// <summary>
        /// Extension to retrieve the Display Attribute localized value from an Enum
        /// </summary>
        /// <param name="enumValue"></param>
        /// <returns></returns>
        public static string GetDisplayName(this Enum enumValue)
            => enumValue.GetAttribute<DisplayAttribute>()
                            .GetName() ?? enumValue.ToString().SeparateCapitals();

        /// <summary>
        /// Extension to retrieve the Display Attribute localized value from an Enum
        /// </summary>
        /// <param name="enumValue"></param>
        /// <returns></returns>
        public static string GetDisplayName<TEnum>(this TEnum enumValue)
            => (enumValue as Enum)?.GetAttribute<DisplayAttribute>()
                            ?.GetName() ?? enumValue.ToString().SeparateCapitals();
    }
}
