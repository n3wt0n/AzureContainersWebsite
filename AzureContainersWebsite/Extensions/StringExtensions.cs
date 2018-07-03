using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureContainersWebsite.Extensions
{
    public static class StringExtensions
    {
        public static string SeparateCapitals(this string value)
            => string.Concat((value ?? string.Empty)
                .Select(x => Char.IsUpper(x) ? " " + x : x.ToString()))
                .TrimStart('_')
                .TrimStart(' ');
    }
}
