using System;
using System.Collections.Generic;
using System.Linq;

namespace Juners.Linq {
    public static class EnumerableExtensions {
        /// <summary>
        /// IEnumerableを <see cref="string.Join{T}(string, IEnumerable{T})"/>する。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Self"></param>
        /// <param name="Splitter"></param>
        /// <param name="Converter"></param>
        /// <returns></returns>
        public static string ToJoinString<T>(this IEnumerable<T> Self, string Splitter, Func<T, string> Converter)
            => string.Join(Splitter, (Self ?? throw new ArgumentNullException(nameof(Self))).Select(Converter));
        /// <summary>
        /// IEnumerableを <see cref="string.Join{T}(string, IEnumerable{T})"/>する。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Self"></param>
        /// <param name="Splitter"></param>
        /// <returns></returns>
        public static string ToJoinString<T>(this IEnumerable<T> Self, string Splitter)
            => string.Join(Splitter, (Self ?? throw new ArgumentNullException(nameof(Self))));
    }
}
