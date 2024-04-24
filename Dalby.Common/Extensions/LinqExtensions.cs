namespace Dalby.Common.Extensions
{
    public static class LinqExtensions
    {
        public static IEnumerable<T?> Concat<T>(this IEnumerable<T?> items, T? extraItem)
        {
            foreach (T? item in items) yield return item;
            yield return extraItem;
        }
        public static IEnumerable<T> WhereNotNull<T>(this IEnumerable<T?> items)
        {
            foreach (T? item in items)
            {
                if (item is not null) yield return item;
            }
        }
        public static IEnumerable<T> Join<T>(this IEnumerable<T> self, T fill)
        {
            if (!self.Any()) yield break;
            yield return self.First();
            foreach (T t in self.Skip(1))
            {
                yield return fill;
                yield return t;
            }
        }
        public static IEnumerable<T[]> Split<T>(this IEnumerable<T> self, Predicate<T> split)
        {
            if (!self.Any()) yield break;
            List<T> items = [];
            foreach (T item in self)
            {
                if (split(item))
                {
                    yield return items.ToArray();
                    items.Clear();
                }
                else items.Add(item);
            }
            yield return items.ToArray();
        }
    }
}