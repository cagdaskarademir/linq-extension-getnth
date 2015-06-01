using System.Collections.Generic;
using System.Linq;

namespace AspNet.Solutions.LinqExtensionConsole
{
    public static class LinqExtension
    {
        public static T GetNth<T>(this IEnumerable<T> list, int n)
        {
            return list.Where((data, i) => i == n).FirstOrDefault();
        }

        public static T GetNth<T>(this IList<T> list, int n)
        {
            return list.Where((data, i) => i == n).FirstOrDefault();
        }
    }
}