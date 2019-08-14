using System;
using System.Collections.Generic;

namespace ArkhaLime.Utilities.Extensions
{
    public static class ListExtensions
    {

        public static string Join<T>(this List<T> list, string separator)
        {
            if (list == null) return "";
            return string.Join<T>(separator, list);
        }

    }
}
