using System;
using System.Collections.Generic;
using Juners.Enumerable;

namespace Juners.Linq {
    public static class CrossJoinExtensions {
        /// <summary>
        /// CROSS JOIN して 取得する
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="Item1"></param>
        /// <param name="Item2"></param>
        /// <returns></returns>
        public static IEnumerable<(T1 Item1, T2 Item2)> CrossJoin<T1, T2>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2)
            => new CrossJoinTupleEnumerable<T1, T2>(Item1, Item2);
        /// <summary>
        /// CROSS JOIN して任意の型に変換する
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="Item1"></param>
        /// <param name="Item2"></param>
        /// <param name="Action"></param>
        /// <returns></returns>
        public static IEnumerable<TResult> CrossJoin<T1, T2, TResult>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, Func<T1, T2, TResult> Action)
            => new CrossJoinEnumerable<T1, T2, TResult>(Item1, Item2, Action);
        /// <summary>
        /// CROSS JOIN して 取得する
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <param name="Item1"></param>
        /// <param name="Item2"></param>
        /// <param name="Item3"></param>
        /// <returns></returns>
        public static IEnumerable<(T1 Item1, T2 Item2, T3 Item3)> CrossJoin<T1, T2, T3>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3)
            => new CrossJoinTupleEnumerable<T1, T2, T3>(Item1, Item2, Item3);
        /// <summary>
        /// CROSS JOIN して任意の型に変換する
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="Item1"></param>
        /// <param name="Item2"></param>
        /// <param name="Item3"></param>
        /// <param name="Action"></param>
        /// <returns></returns>
        public static IEnumerable<TResult> CrossJoin<T1, T2, T3, TResult>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, Func<T1, T2, T3, TResult> Action)
            => new CrossJoinEnumerable<T1, T2, T3, TResult>(Item1, Item2, Item3, Action);
    }
}
