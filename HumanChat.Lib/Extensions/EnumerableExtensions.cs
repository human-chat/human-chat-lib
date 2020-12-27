using System.Collections.Generic;
using System.Linq;

namespace HumanChat.Lib.Extensions
{
    public static class EnumerableExtensions
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> values)
        {
            return values == null || !values.Any();
        }

        /// <summary>
        /// Check that values is not null and has any element.
        /// </summary>
        public static bool HasAny<T>(this IEnumerable<T> values)
        {
            return !values.IsNullOrEmpty();
        }
    }
}
