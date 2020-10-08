using System.Collections.Generic;
using System.Linq;

namespace EfCoreAutomapperOdata.Server.Extensions
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<T> OrEmptyIfNull<T>(this IEnumerable<T> source)
        {
            return source ?? Enumerable.Empty<T>();
        }
    }
}
