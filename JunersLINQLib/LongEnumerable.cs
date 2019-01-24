using System;
using System.Collections.Generic;

namespace Juners.Linq {
    public static class LongEnumerable {
        public static IEnumerable<long> Range(long start, long count)
        {
            var max = start + count - 1;
            if (count < 0 || max > long.MaxValue)
                throw new ArgumentOutOfRangeException(nameof(count));
            return LongRangeIterator(start, count);
        }
        static IEnumerable<long> LongRangeIterator(long start, long count)
        {
            for (var i = 0L; i < count; i++)
                yield return start + i;
        }
        public static IEnumerable<TResult> Repeat<TResult>(TResult element, long count)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            return LongRepeatIterator(element, count);
        }
        static IEnumerable<TResult> LongRepeatIterator<TResult>(TResult element, long count)
        {
            for (var i = 0L; i < count; i++)
                yield return element;
        }
        public static IEnumerable<TSource> Take<TSource>(this IEnumerable<TSource> source, long count)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            return TakeIterator(source, count);
        }
        static IEnumerable<TSource> TakeIterator<TSource>(IEnumerable<TSource> source, long count)
        {
            if (count > 0) {
                foreach (var element in source) {
                    yield return element;
                    if (--count == 0)
                        break;
                }
            }
        }
        public static IEnumerable<TSource> Skip<TSource>(this IEnumerable<TSource> source, long count)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            return SkipIterator(source, count);
        }
        static IEnumerable<TSource> SkipIterator<TSource>(IEnumerable<TSource> source, long count)
        {
            using (var e = source.GetEnumerator()) {
                while (count > 0 && e.MoveNext())
                    count--;
                if (count <= 0) {
                    while (e.MoveNext())
                        yield return e.Current;
                }
            }
        }
    }
}
