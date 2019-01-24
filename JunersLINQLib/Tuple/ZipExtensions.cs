using System;
using System.Collections.Generic;
using Juners.Enumerable;

namespace Juners.Linq.Tuple {
    public static class ZipExtensions {
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="Items"></param>
        /// <param name="Action"></param>
        /// <param name="NotEnough"></param>
        /// <returns></returns>
        public static IEnumerable<TResult> Zip<T1, T2, TResult>(this (IEnumerable<T1> Item1, IEnumerable<T2> Item2) Items, Func<T1, T2, TResult> Action, ZipNotEnough NotEnough = default)
            => new ZipEnumerable<T1, T2, TResult>(Items.Item1, Items.Item2, Action, NotEnough);
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="Items"></param>
        /// <param name="NotEnough"></param>
        /// <returns></returns>
        public static IEnumerable<(T1 Item1, T2 Item2)> Zip<T1, T2>(this (IEnumerable<T1> Item1, IEnumerable<T2> Item2) Items, ZipNotEnough NotEnough = default)
            => Zip(Items, (Item1, Item2) => (Item1, Item2), NotEnough);
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="Items"></param>
        /// <param name="Action"></param>
        /// <param name="NotEnough"></param>
        /// <returns></returns>
        public static IEnumerable<TResult> Zip<T1, T2, T3, TResult>(this (IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3) Items, Func<T1, T2, T3, TResult> Action, ZipNotEnough NotEnough = default)
            => new ZipEnumerable<T1, T2, T3, TResult>(Items.Item1, Items.Item2, Items.Item3, Action, NotEnough);
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <param name="Items"></param>
        /// <param name="NotEnough"></param>
        /// <returns></returns>
        public static IEnumerable<(T1 Item1, T2 Item2, T3 Item3)> Zip<T1, T2, T3>(this (IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3) Items, ZipNotEnough NotEnough = default)
            => Zip(Items, (Item1, Item2, Item3) => (Item1, Item2, Item3), NotEnough);
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="Items"></param>
        /// <param name="Action"></param>
        /// <param name="NotEnough"></param>
        /// <returns></returns>
        public static IEnumerable<TResult> Zip<T1, T2, T3, T4, TResult>(this (IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4) Items, Func<T1, T2, T3, T4, TResult> Action, ZipNotEnough NotEnough = default)
            => new ZipEnumerable<T1, T2, T3, T4, TResult>(Items.Item1, Items.Item2, Items.Item3, Items.Item4, Action, NotEnough);
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="Items"></param>
        /// <param name="NotEnough"></param>
        /// <returns></returns>
        public static IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4)> Zip<T1, T2, T3, T4, TResult>(this (IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4) Items, ZipNotEnough NotEnough = default)
            => Zip(Items, (Item1, Item2, Item3, Item4) => (Item1, Item2, Item3, Item4), NotEnough);

    }
}
