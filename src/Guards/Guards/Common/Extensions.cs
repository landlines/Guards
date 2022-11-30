using System.Linq;
using System.Collections.Generic;

namespace Guards.Common
{
    internal static class CommonExtensions 
    {
        public static string Join<T>(this T[] items, string delimeter = "") 
        {
            return !items.Any() 
                ? string.Empty 
                : items.Select(x => x.ToString()).Aggregate((a, i) => string.Format("{0}{1}{2}", a, delimeter, i));
        }

        public static IEnumerable<int> To(this int start, int end) 
        {
            return end >= start ? Enumerable.Range(start, end - start + 1) : Enumerable.Empty<int>();
        }
    }
}
