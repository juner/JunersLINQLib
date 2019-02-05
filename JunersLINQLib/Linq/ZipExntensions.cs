using System;
using System.Collections.Generic;
using System.Linq;
using Juners.Enumerable;

namespace Juners.Linq
{
    public static class ZipExntensions
    {
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Item1">合成するIEnumerableの一つ目</param>
        /// <param name="NotEnough">列挙数が足りない場合の挙動</param>
        /// <param name="Items">合成するIEnumerableの二つ目以降</param>
        /// <returns></returns>
        public static IEnumerable<T[]> Zip<T>(this IEnumerable<T> Item1, ZipNotEnough NotEnough, params IEnumerable<T>[] Items)
            => new SimpleZipEnumerable<T>(NotEnough, new[] { Item1 }.Concat(Items));
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T">入力型</typeparam>
        /// <typeparam name="TResult">出力型</typeparam>
        /// <param name="Item1">一つ目のIEnumerable</param>
        /// <param name="NotEnough">列挙数が足りない時の挙動設定</param>
        /// <param name="Action">出力型への変換用関数</param>
        /// <param name="Items">二つ目以降のIEnumerable</param>
        /// <returns></returns>
        public static IEnumerable<TResult> Zip<T, TResult>(this IEnumerable<T> Item1, ZipNotEnough NotEnough, Func<T[], TResult> Action, params IEnumerable<T>[] Items)
            => new SimpleZipEnumerable<T, TResult>(NotEnough, Action, new[] { Item1 }.Concat(Items));
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="Item1"></param>
        /// <param name="Item2"></param>
        /// <param name="NotEnough"></param>
        /// <returns></returns>
        public static IEnumerable<(T1 Item1, T2 Item2)> Zip<T1, T2>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, ZipNotEnough NotEnough = default)
            => new ZipTupleEnumerable<T1, T2>(Item1, Item2, NotEnough);
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T1">入力型1</typeparam>
        /// <typeparam name="T2">入力型2</typeparam>
        /// <typeparam name="TResult">出力型</typeparam>
        /// <param name="Item1">一つ目のIEnumerable</param>
        /// <param name="Item2">二つ目のIEnumerable</param>
        /// <param name="Action"></param>
        /// <param name="NotEnough"></param>
        /// <returns></returns>
        public static IEnumerable<TResult> Zip<T1, T2, TResult>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, Func<T1, T2, TResult> Action, ZipNotEnough NotEnough = default)
            => new ZipEnumerable<T1, T2, TResult>(Item1, Item2, Action, NotEnough);
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <param name="Item1"></param>
        /// <param name="Item2"></param>
        /// <param name="Item3"></param>
        /// <param name="NotEnough"></param>
        /// <returns></returns>
        public static IEnumerable<(T1 Item1, T2 Item2, T3 Item3)> Zip<T1, T2, T3>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, ZipNotEnough NotEnough = default)
            => new ZipTupleEnumerable<T1, T2, T3>(Item1, Item2, Item3, NotEnough);
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="Item1"></param>
        /// <param name="Item2"></param>
        /// <param name="Item3"></param>
        /// <param name="Action"></param>
        /// <param name="NotEnough"></param>
        /// <returns></returns>
        public static IEnumerable<TResult> Zip<T1, T2, T3, TResult>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, Func<T1, T2, T3, TResult> Action, ZipNotEnough NotEnough = default)
            => new ZipEnumerable<T1, T2, T3, TResult>(Item1, Item2, Item3, Action, NotEnough);
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <param name="Item1"></param>
        /// <param name="Item2"></param>
        /// <param name="Item3"></param>
        /// <param name="Item4"></param>
        /// <param name="NotEnough"></param>
        /// <returns></returns>
        public static IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4)> Zip<T1, T2, T3, T4>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, ZipNotEnough NotEnough = default)
            => new ZipTupleEnumerable<T1, T2, T3, T4>(Item1, Item2, Item3, Item4, NotEnough);
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="Item1"></param>
        /// <param name="Item2"></param>
        /// <param name="Item3"></param>
        /// <param name="Item4"></param>
        /// <param name="Action"></param>
        /// <param name="NotEnough"></param>
        /// <returns></returns>
        public static IEnumerable<TResult> Zip<T1, T2, T3, T4, TResult>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, Func<T1, T2, T3, T4, TResult> Action, ZipNotEnough NotEnough = default)
            => new ZipEnumerable<T1, T2, T3, T4, TResult>(Item1, Item2, Item3, Item4, Action, NotEnough);
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <param name="Item1"></param>
        /// <param name="Item2"></param>
        /// <param name="Item3"></param>
        /// <param name="Item4"></param>
        /// <param name="Item5"></param>
        /// <param name="NotEnough"></param>
        /// <returns></returns>
        public static IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5)> Zip<T1, T2, T3, T4, T5>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, ZipNotEnough NotEnough = default)
            => new ZipTupleEnumerable<T1, T2, T3, T4, T5>(Item1, Item2, Item3, Item4, Item5, NotEnough);
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="Item1"></param>
        /// <param name="Item2"></param>
        /// <param name="Item3"></param>
        /// <param name="Item4"></param>
        /// <param name="Item5"></param>
        /// <param name="Action"></param>
        /// <param name="NotEnough"></param>
        /// <returns></returns>
        public static IEnumerable<TResult> Zip<T1, T2, T3, T4, T5, TResult>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, Func<T1, T2, T3, T4, T5, TResult> Action, ZipNotEnough NotEnough = default)
            => new ZipEnumerable<T1, T2, T3, T4, T5, TResult>(Item1, Item2, Item3, Item4, Item5, Action, NotEnough);
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <param name="Item1"></param>
        /// <param name="Item2"></param>
        /// <param name="Item3"></param>
        /// <param name="Item4"></param>
        /// <param name="Item5"></param>
        /// <param name="Item6"></param>
        /// <param name="NotEnough"></param>
        /// <returns></returns>
        public static IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5, T6 Item6)> Zip<T1, T2, T3, T4, T5, T6>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, ZipNotEnough NotEnough = default)
            => Zip(Item1, Item2, Item3, Item4, Item5, Item6, (v1, v2, v3, v4, v5, v6) => (v1, v2, v3, v4, v5, v6), NotEnough);
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="Item1"></param>
        /// <param name="Item2"></param>
        /// <param name="Item3"></param>
        /// <param name="Item4"></param>
        /// <param name="Item5"></param>
        /// <param name="Item6"></param>
        /// <param name="Action"></param>
        /// <param name="NotEnough"></param>
        /// <returns></returns>
        public static IEnumerable<TResult> Zip<T1, T2, T3, T4, T5, T6, TResult>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, Func<T1, T2, T3, T4, T5, T6, TResult> Action, ZipNotEnough NotEnough = default)
            => new ZipEnumerable<T1, T2, T3, T4, T5, T6, TResult>(Item1, Item2, Item3, Item4, Item5, Item6, Action, NotEnough);
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <param name="Item1"></param>
        /// <param name="Item2"></param>
        /// <param name="Item3"></param>
        /// <param name="Item4"></param>
        /// <param name="Item5"></param>
        /// <param name="Item6"></param>
        /// <param name="Item7"></param>
        /// <returns></returns>
        public static IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5, T6 Item6, T7 Item7)> Zip<T1, T2, T3, T4, T5, T6, T7>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, IEnumerable<T7> Item7, ZipNotEnough NotEnough = default)
            => Zip(Item1, Item2, Item3, Item4, Item5, Item6, Item7, (v1, v2, v3, v4, v5, v6, v7) => (v1, v2, v3, v4, v5, v6, v7), NotEnough);
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="Item1"></param>
        /// <param name="Item2"></param>
        /// <param name="Item3"></param>
        /// <param name="Item4"></param>
        /// <param name="Item5"></param>
        /// <param name="Item6"></param>
        /// <param name="Item7"></param>
        /// <param name="Action"></param>
        /// <param name="NotEnough"></param>
        /// <returns></returns>
        public static IEnumerable<TResult> Zip<T1, T2, T3, T4, T5, T6, T7, TResult>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, IEnumerable<T7> Item7, Func<T1, T2, T3, T4, T5, T6, T7, TResult> Action, ZipNotEnough NotEnough = default)
            => new ZipEnumerable<T1, T2, T3, T4, T5, T6, T7, TResult>(Item1, Item2, Item3, Item4, Item5, Item6, Item7, Action, NotEnough);
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <param name="Item1"></param>
        /// <param name="Item2"></param>
        /// <param name="Item3"></param>
        /// <param name="Item4"></param>
        /// <param name="Item5"></param>
        /// <param name="Item6"></param>
        /// <param name="Item7"></param>
        /// <param name="Item8"></param>
        /// <param name="NotEnough"></param>
        /// <returns></returns>
        public static IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5, T6 Item6, T7 Item7, T8 Item8)> Zip<T1, T2, T3, T4, T5, T6, T7, T8>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, IEnumerable<T7> Item7, IEnumerable<T8> Item8, ZipNotEnough NotEnough = default)
            => Zip(Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, (v1, v2, v3, v4, v5, v6, v7, v8) => (v1, v2, v3, v4, v5, v6, v7, v8), NotEnough);
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="Item1"></param>
        /// <param name="Item2"></param>
        /// <param name="Item3"></param>
        /// <param name="Item4"></param>
        /// <param name="Item5"></param>
        /// <param name="Item6"></param>
        /// <param name="Item7"></param>
        /// <param name="Item8"></param>
        /// <param name="Action"></param>
        /// <param name="NotEnough"></param>
        /// <returns></returns>
        public static IEnumerable<TResult> Zip<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, IEnumerable<T7> Item7, IEnumerable<T8> Item8, Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> Action, ZipNotEnough NotEnough = default)
            => new ZipEnumerable<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Action, NotEnough);
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <param name="Item1"></param>
        /// <param name="Item2"></param>
        /// <param name="Item3"></param>
        /// <param name="Item4"></param>
        /// <param name="Item5"></param>
        /// <param name="Item6"></param>
        /// <param name="Item7"></param>
        /// <param name="Item8"></param>
        /// <param name="Item9"></param>
        /// <param name="NotEnough"></param>
        /// <returns></returns>
        public static IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5, T6 Item6, T7 Item7, T8 Item8, T9 Item9)> Zip<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, IEnumerable<T7> Item7, IEnumerable<T8> Item8, IEnumerable<T9> Item9, ZipNotEnough NotEnough = default)
            => Zip(Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9, (v1, v2, v3, v4, v5, v6, v7, v8, v9) => (v1, v2, v3, v4, v5, v6, v7, v8, v9), NotEnough);
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="Item1"></param>
        /// <param name="Item2"></param>
        /// <param name="Item3"></param>
        /// <param name="Item4"></param>
        /// <param name="Item5"></param>
        /// <param name="Item6"></param>
        /// <param name="Item7"></param>
        /// <param name="Item8"></param>
        /// <param name="Item9"></param>
        /// <param name="Action"></param>
        /// <param name="NotEnough"></param>
        /// <returns></returns>
        public static IEnumerable<TResult> Zip<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, IEnumerable<T7> Item7, IEnumerable<T8> Item8, IEnumerable<T9> Item9, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> Action, ZipNotEnough NotEnough = default)
            => new ZipEnumerable<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9, Action, NotEnough);
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <param name="Item1"></param>
        /// <param name="Item2"></param>
        /// <param name="Item3"></param>
        /// <param name="Item4"></param>
        /// <param name="Item5"></param>
        /// <param name="Item6"></param>
        /// <param name="Item7"></param>
        /// <param name="Item8"></param>
        /// <param name="Item9"></param>
        /// <param name="Item10"></param>
        /// <param name="NotEnough"></param>
        /// <returns></returns>
        public static IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5, T6 Item6, T7 Item7, T8 Item8, T9 Item9, T10 Item10)> Zip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, IEnumerable<T7> Item7, IEnumerable<T8> Item8, IEnumerable<T9> Item9, IEnumerable<T10> Item10, ZipNotEnough NotEnough = default)
            => Zip(Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9, Item10, (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10) => (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10), NotEnough);
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="Item1"></param>
        /// <param name="Item2"></param>
        /// <param name="Item3"></param>
        /// <param name="Item4"></param>
        /// <param name="Item5"></param>
        /// <param name="Item6"></param>
        /// <param name="Item7"></param>
        /// <param name="Item8"></param>
        /// <param name="Item9"></param>
        /// <param name="Item10"></param>
        /// <param name="Action"></param>
        /// <param name="NotEnough"></param>
        /// <returns></returns>
        public static IEnumerable<TResult> Zip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, IEnumerable<T7> Item7, IEnumerable<T8> Item8, IEnumerable<T9> Item9, IEnumerable<T10> Item10, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> Action, ZipNotEnough NotEnough = default)
            => new ZipEnumerable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9, Item10, Action, NotEnough);
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <param name="Item1"></param>
        /// <param name="Item2"></param>
        /// <param name="Item3"></param>
        /// <param name="Item4"></param>
        /// <param name="Item5"></param>
        /// <param name="Item6"></param>
        /// <param name="Item7"></param>
        /// <param name="Item8"></param>
        /// <param name="Item9"></param>
        /// <param name="Item10"></param>
        /// <param name="Item11"></param>
        /// <param name="NotEnough"></param>
        /// <returns></returns>
        public static IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5, T6 Item6, T7 Item7, T8 Item8, T9 Item9, T10 Item10, T11 Item11)> Zip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, IEnumerable<T7> Item7, IEnumerable<T8> Item8, IEnumerable<T9> Item9, IEnumerable<T10> Item10, IEnumerable<T11> Item11, ZipNotEnough NotEnough = default)
            => Zip(Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9, Item10, Item11, (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11) => (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11), NotEnough);
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="Item1"></param>
        /// <param name="Item2"></param>
        /// <param name="Item3"></param>
        /// <param name="Item4"></param>
        /// <param name="Item5"></param>
        /// <param name="Item6"></param>
        /// <param name="Item7"></param>
        /// <param name="Item8"></param>
        /// <param name="Item9"></param>
        /// <param name="Item10"></param>
        /// <param name="Item11"></param>
        /// <param name="Action"></param>
        /// <param name="NotEnough"></param>
        /// <returns></returns>
        public static IEnumerable<TResult> Zip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, IEnumerable<T7> Item7, IEnumerable<T8> Item8, IEnumerable<T9> Item9, IEnumerable<T10> Item10, IEnumerable<T11> Item11, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Action, ZipNotEnough NotEnough = default)
            => new ZipEnumerable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9, Item10, Item11, Action, NotEnough);
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <param name="Item1"></param>
        /// <param name="Item2"></param>
        /// <param name="Item3"></param>
        /// <param name="Item4"></param>
        /// <param name="Item5"></param>
        /// <param name="Item6"></param>
        /// <param name="Item7"></param>
        /// <param name="Item8"></param>
        /// <param name="Item9"></param>
        /// <param name="Item10"></param>
        /// <param name="Item11"></param>
        /// <param name="Item12"></param>
        /// <param name="NotEnough"></param>
        /// <returns></returns>
        public static IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5, T6 Item6, T7 Item7, T8 Item8, T9 Item9, T10 Item10, T11 Item11, T12 Item12)> Zip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, IEnumerable<T7> Item7, IEnumerable<T8> Item8, IEnumerable<T9> Item9, IEnumerable<T10> Item10, IEnumerable<T11> Item11, IEnumerable<T12> Item12, ZipNotEnough NotEnough = default)
            => Zip(Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9, Item10, Item11, Item12, (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12) => (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12), NotEnough);
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="Item1"></param>
        /// <param name="Item2"></param>
        /// <param name="Item3"></param>
        /// <param name="Item4"></param>
        /// <param name="Item5"></param>
        /// <param name="Item6"></param>
        /// <param name="Item7"></param>
        /// <param name="Item8"></param>
        /// <param name="Item9"></param>
        /// <param name="Item10"></param>
        /// <param name="Item11"></param>
        /// <param name="Item12"></param>
        /// <param name="Action"></param>
        /// <param name="NotEnough"></param>
        /// <returns></returns>
        public static IEnumerable<TResult> Zip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, IEnumerable<T7> Item7, IEnumerable<T8> Item8, IEnumerable<T9> Item9, IEnumerable<T10> Item10, IEnumerable<T11> Item11, IEnumerable<T12> Item12, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Action, ZipNotEnough NotEnough = default)
            => new ZipEnumerable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9, Item10, Item11, Item12, Action, NotEnough);
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T13"></typeparam>
        /// <param name="Item1"></param>
        /// <param name="Item2"></param>
        /// <param name="Item3"></param>
        /// <param name="Item4"></param>
        /// <param name="Item5"></param>
        /// <param name="Item6"></param>
        /// <param name="Item7"></param>
        /// <param name="Item8"></param>
        /// <param name="Item9"></param>
        /// <param name="Item10"></param>
        /// <param name="Item11"></param>
        /// <param name="Item12"></param>
        /// <param name="Item13"></param>
        /// <param name="NotEnough"></param>
        /// <returns></returns>
        public static IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5, T6 Item6, T7 Item7, T8 Item8, T9 Item9, T10 Item10, T11 Item11, T12 Item12, T13 Item13)> Zip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, IEnumerable<T7> Item7, IEnumerable<T8> Item8, IEnumerable<T9> Item9, IEnumerable<T10> Item10, IEnumerable<T11> Item11, IEnumerable<T12> Item12, IEnumerable<T13> Item13, ZipNotEnough NotEnough = default)
            => Zip(Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9, Item10, Item11, Item12, Item13, (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13) => (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13), NotEnough);
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T13"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="Item1"></param>
        /// <param name="Item2"></param>
        /// <param name="Item3"></param>
        /// <param name="Item4"></param>
        /// <param name="Item5"></param>
        /// <param name="Item6"></param>
        /// <param name="Item7"></param>
        /// <param name="Item8"></param>
        /// <param name="Item9"></param>
        /// <param name="Item10"></param>
        /// <param name="Item11"></param>
        /// <param name="Item12"></param>
        /// <param name="Item13"></param>
        /// <param name="Action"></param>
        /// <param name="NotEnough"></param>
        /// <returns></returns>
        public static IEnumerable<TResult> Zip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, IEnumerable<T7> Item7, IEnumerable<T8> Item8, IEnumerable<T9> Item9, IEnumerable<T10> Item10, IEnumerable<T11> Item11, IEnumerable<T12> Item12, IEnumerable<T13> Item13, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Action, ZipNotEnough NotEnough = default)
            => new ZipEnumerable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9, Item10, Item11, Item12, Item13, Action, NotEnough);
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T13"></typeparam>
        /// <typeparam name="T14"></typeparam>
        /// <param name="Item1"></param>
        /// <param name="Item2"></param>
        /// <param name="Item3"></param>
        /// <param name="Item4"></param>
        /// <param name="Item5"></param>
        /// <param name="Item6"></param>
        /// <param name="Item7"></param>
        /// <param name="Item8"></param>
        /// <param name="Item9"></param>
        /// <param name="Item10"></param>
        /// <param name="Item11"></param>
        /// <param name="Item12"></param>
        /// <param name="Item13"></param>
        /// <param name="Item14"></param>
        /// <param name="NotEnough"></param>
        /// <returns></returns>
        public static IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5, T6 Item6, T7 Item7, T8 Item8, T9 Item9, T10 Item10, T11 Item11, T12 Item12, T13 Item13, T14 Item14)> Zip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, IEnumerable<T7> Item7, IEnumerable<T8> Item8, IEnumerable<T9> Item9, IEnumerable<T10> Item10, IEnumerable<T11> Item11, IEnumerable<T12> Item12, IEnumerable<T13> Item13, IEnumerable<T14> Item14, ZipNotEnough NotEnough = default)
            => Zip(Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9, Item10, Item11, Item12, Item13, Item14, (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14) => (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14), NotEnough);
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T13"></typeparam>
        /// <typeparam name="T14"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="Item1"></param>
        /// <param name="Item2"></param>
        /// <param name="Item3"></param>
        /// <param name="Item4"></param>
        /// <param name="Item5"></param>
        /// <param name="Item6"></param>
        /// <param name="Item7"></param>
        /// <param name="Item8"></param>
        /// <param name="Item9"></param>
        /// <param name="Item10"></param>
        /// <param name="Item11"></param>
        /// <param name="Item12"></param>
        /// <param name="Item13"></param>
        /// <param name="Item14"></param>
        /// <param name="Action"></param>
        /// <param name="NotEnough"></param>
        /// <returns></returns>
        public static IEnumerable<TResult> Zip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, IEnumerable<T7> Item7, IEnumerable<T8> Item8, IEnumerable<T9> Item9, IEnumerable<T10> Item10, IEnumerable<T11> Item11, IEnumerable<T12> Item12, IEnumerable<T13> Item13, IEnumerable<T14> Item14, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Action, ZipNotEnough NotEnough = default)
            => new ZipEnumerable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9, Item10, Item11, Item12, Item13, Item14, Action, NotEnough);
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T13"></typeparam>
        /// <typeparam name="T14"></typeparam>
        /// <typeparam name="T15"></typeparam>
        /// <param name="Item1"></param>
        /// <param name="Item2"></param>
        /// <param name="Item3"></param>
        /// <param name="Item4"></param>
        /// <param name="Item5"></param>
        /// <param name="Item6"></param>
        /// <param name="Item7"></param>
        /// <param name="Item8"></param>
        /// <param name="Item9"></param>
        /// <param name="Item10"></param>
        /// <param name="Item11"></param>
        /// <param name="Item12"></param>
        /// <param name="Item13"></param>
        /// <param name="Item14"></param>
        /// <param name="Item15"></param>
        /// <param name="NotEnough"></param>
        /// <returns></returns>
        public static IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5, T6 Item6, T7 Item7, T8 Item8, T9 Item9, T10 Item10, T11 Item11, T12 Item12, T13 Item13, T14 Item14, T15 Item15)> Zip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, IEnumerable<T7> Item7, IEnumerable<T8> Item8, IEnumerable<T9> Item9, IEnumerable<T10> Item10, IEnumerable<T11> Item11, IEnumerable<T12> Item12, IEnumerable<T13> Item13, IEnumerable<T14> Item14, IEnumerable<T15> Item15, ZipNotEnough NotEnough = default)
                    => Zip(Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9, Item10, Item11, Item12, Item13, Item14, Item15, (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15) => (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15), NotEnough);
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T13"></typeparam>
        /// <typeparam name="T14"></typeparam>
        /// <typeparam name="T15"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="Item1"></param>
        /// <param name="Item2"></param>
        /// <param name="Item3"></param>
        /// <param name="Item4"></param>
        /// <param name="Item5"></param>
        /// <param name="Item6"></param>
        /// <param name="Item7"></param>
        /// <param name="Item8"></param>
        /// <param name="Item9"></param>
        /// <param name="Item10"></param>
        /// <param name="Item11"></param>
        /// <param name="Item12"></param>
        /// <param name="Item13"></param>
        /// <param name="Item14"></param>
        /// <param name="Item15"></param>
        /// <param name="Action"></param>
        /// <param name="NotEnough"></param>
        /// <returns></returns>
        public static IEnumerable<TResult> Zip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, IEnumerable<T7> Item7, IEnumerable<T8> Item8, IEnumerable<T9> Item9, IEnumerable<T10> Item10, IEnumerable<T11> Item11, IEnumerable<T12> Item12, IEnumerable<T13> Item13, IEnumerable<T14> Item14, IEnumerable<T15> Item15, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Action, ZipNotEnough NotEnough = default)
            => new ZipEnumerable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9, Item10, Item11, Item12, Item13, Item14, Item15, Action, NotEnough);
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T13"></typeparam>
        /// <typeparam name="T14"></typeparam>
        /// <typeparam name="T15"></typeparam>
        /// <typeparam name="T16"></typeparam>
        /// <param name="Item1"></param>
        /// <param name="Item2"></param>
        /// <param name="Item3"></param>
        /// <param name="Item4"></param>
        /// <param name="Item5"></param>
        /// <param name="Item6"></param>
        /// <param name="Item7"></param>
        /// <param name="Item8"></param>
        /// <param name="Item9"></param>
        /// <param name="Item10"></param>
        /// <param name="Item11"></param>
        /// <param name="Item12"></param>
        /// <param name="Item13"></param>
        /// <param name="Item14"></param>
        /// <param name="Item15"></param>
        /// <param name="Item16"></param>
        /// <param name="NotEnough"></param>
        /// <returns></returns>
        public static IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5, T6 Item6, T7 Item7, T8 Item8, T9 Item9, T10 Item10, T11 Item11, T12 Item12, T13 Item13, T14 Item14, T15 Item15, T16 Item16)> Zip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, IEnumerable<T7> Item7, IEnumerable<T8> Item8, IEnumerable<T9> Item9, IEnumerable<T10> Item10, IEnumerable<T11> Item11, IEnumerable<T12> Item12, IEnumerable<T13> Item13, IEnumerable<T14> Item14, IEnumerable<T15> Item15, IEnumerable<T16> Item16, ZipNotEnough NotEnough = default)
                            => Zip(Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9, Item10, Item11, Item12, Item13, Item14, Item15, Item16, (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16) => (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16), NotEnough);
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T13"></typeparam>
        /// <typeparam name="T14"></typeparam>
        /// <typeparam name="T15"></typeparam>
        /// <typeparam name="T16"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="Item1"></param>
        /// <param name="Item2"></param>
        /// <param name="Item3"></param>
        /// <param name="Item4"></param>
        /// <param name="Item5"></param>
        /// <param name="Item6"></param>
        /// <param name="Item7"></param>
        /// <param name="Item8"></param>
        /// <param name="Item9"></param>
        /// <param name="Item10"></param>
        /// <param name="Item11"></param>
        /// <param name="Item12"></param>
        /// <param name="Item13"></param>
        /// <param name="Item14"></param>
        /// <param name="Item15"></param>
        /// <param name="Item16"></param>
        /// <param name="Action"></param>
        /// <param name="NotEnough"></param>
        /// <returns></returns>
        public static IEnumerable<TResult> Zip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, IEnumerable<T7> Item7, IEnumerable<T8> Item8, IEnumerable<T9> Item9, IEnumerable<T10> Item10, IEnumerable<T11> Item11, IEnumerable<T12> Item12, IEnumerable<T13> Item13, IEnumerable<T14> Item14, IEnumerable<T15> Item15, IEnumerable<T16> Item16, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Action, ZipNotEnough NotEnough = default)
            => new ZipEnumerable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9, Item10, Item11, Item12, Item13, Item14, Item15, Item16, Action, NotEnough);
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T13"></typeparam>
        /// <typeparam name="T14"></typeparam>
        /// <typeparam name="T15"></typeparam>
        /// <typeparam name="T16"></typeparam>
        /// <typeparam name="T17"></typeparam>
        /// <param name="Item1"></param>
        /// <param name="Item2"></param>
        /// <param name="Item3"></param>
        /// <param name="Item4"></param>
        /// <param name="Item5"></param>
        /// <param name="Item6"></param>
        /// <param name="Item7"></param>
        /// <param name="Item8"></param>
        /// <param name="Item9"></param>
        /// <param name="Item10"></param>
        /// <param name="Item11"></param>
        /// <param name="Item12"></param>
        /// <param name="Item13"></param>
        /// <param name="Item14"></param>
        /// <param name="Item15"></param>
        /// <param name="Item16"></param>
        /// <param name="Item17"></param>
        /// <param name="NotEnough"></param>
        /// <returns></returns>
        public static IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5, T6 Item6, T7 Item7, T8 Item8, T9 Item9, T10 Item10, T11 Item11, T12 Item12, T13 Item13, T14 Item14, T15 Item15, T16 Item16, T17 Item17)> Zip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, IEnumerable<T7> Item7, IEnumerable<T8> Item8, IEnumerable<T9> Item9, IEnumerable<T10> Item10, IEnumerable<T11> Item11, IEnumerable<T12> Item12, IEnumerable<T13> Item13, IEnumerable<T14> Item14, IEnumerable<T15> Item15, IEnumerable<T16> Item16, IEnumerable<T17> Item17, ZipNotEnough NotEnough = default)
            => new ZipTupleEnumerable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9, Item10, Item11, Item12, Item13, Item14, Item15, Item16, Item17, NotEnough);
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T13"></typeparam>
        /// <typeparam name="T14"></typeparam>
        /// <typeparam name="T15"></typeparam>
        /// <typeparam name="T16"></typeparam>
        /// <typeparam name="T17"></typeparam>
        /// <typeparam name="T18"></typeparam>
        /// <param name="Item1"></param>
        /// <param name="Item2"></param>
        /// <param name="Item3"></param>
        /// <param name="Item4"></param>
        /// <param name="Item5"></param>
        /// <param name="Item6"></param>
        /// <param name="Item7"></param>
        /// <param name="Item8"></param>
        /// <param name="Item9"></param>
        /// <param name="Item10"></param>
        /// <param name="Item11"></param>
        /// <param name="Item12"></param>
        /// <param name="Item13"></param>
        /// <param name="Item14"></param>
        /// <param name="Item15"></param>
        /// <param name="Item16"></param>
        /// <param name="Item17"></param>
        /// <param name="Item18"></param>
        /// <param name="NotEnough"></param>
        /// <returns></returns>
        public static IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5, T6 Item6, T7 Item7, T8 Item8, T9 Item9, T10 Item10, T11 Item11, T12 Item12, T13 Item13, T14 Item14, T15 Item15, T16 Item16, T17 Item17, T18 Item18)> Zip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, IEnumerable<T7> Item7, IEnumerable<T8> Item8, IEnumerable<T9> Item9, IEnumerable<T10> Item10, IEnumerable<T11> Item11, IEnumerable<T12> Item12, IEnumerable<T13> Item13, IEnumerable<T14> Item14, IEnumerable<T15> Item15, IEnumerable<T16> Item16, IEnumerable<T17> Item17, IEnumerable<T18> Item18, ZipNotEnough NotEnough = default)
            => new ZipTupleEnumerable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9, Item10, Item11, Item12, Item13, Item14, Item15, Item16, Item17, Item18, NotEnough);
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T13"></typeparam>
        /// <typeparam name="T14"></typeparam>
        /// <typeparam name="T15"></typeparam>
        /// <typeparam name="T16"></typeparam>
        /// <typeparam name="T17"></typeparam>
        /// <typeparam name="T18"></typeparam>
        /// <typeparam name="T19"></typeparam>
        /// <param name="Item1"></param>
        /// <param name="Item2"></param>
        /// <param name="Item3"></param>
        /// <param name="Item4"></param>
        /// <param name="Item5"></param>
        /// <param name="Item6"></param>
        /// <param name="Item7"></param>
        /// <param name="Item8"></param>
        /// <param name="Item9"></param>
        /// <param name="Item10"></param>
        /// <param name="Item11"></param>
        /// <param name="Item12"></param>
        /// <param name="Item13"></param>
        /// <param name="Item14"></param>
        /// <param name="Item15"></param>
        /// <param name="Item16"></param>
        /// <param name="Item17"></param>
        /// <param name="Item18"></param>
        /// <param name="Item19"></param>
        /// <param name="NotEnough"></param>
        /// <returns></returns>
        public static IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5, T6 Item6, T7 Item7, T8 Item8, T9 Item9, T10 Item10, T11 Item11, T12 Item12, T13 Item13, T14 Item14, T15 Item15, T16 Item16, T17 Item17, T18 Item18, T19 Item19)> Zip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, IEnumerable<T7> Item7, IEnumerable<T8> Item8, IEnumerable<T9> Item9, IEnumerable<T10> Item10, IEnumerable<T11> Item11, IEnumerable<T12> Item12, IEnumerable<T13> Item13, IEnumerable<T14> Item14, IEnumerable<T15> Item15, IEnumerable<T16> Item16, IEnumerable<T17> Item17, IEnumerable<T18> Item18, IEnumerable<T19> Item19, ZipNotEnough NotEnough = default)
                    => new ZipTupleEnumerable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9, Item10, Item11, Item12, Item13, Item14, Item15, Item16, Item17, Item18, Item19, NotEnough);
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T13"></typeparam>
        /// <typeparam name="T14"></typeparam>
        /// <typeparam name="T15"></typeparam>
        /// <typeparam name="T16"></typeparam>
        /// <typeparam name="T17"></typeparam>
        /// <typeparam name="T18"></typeparam>
        /// <typeparam name="T19"></typeparam>
        /// <typeparam name="T20"></typeparam>
        /// <param name="Item1"></param>
        /// <param name="Item2"></param>
        /// <param name="Item3"></param>
        /// <param name="Item4"></param>
        /// <param name="Item5"></param>
        /// <param name="Item6"></param>
        /// <param name="Item7"></param>
        /// <param name="Item8"></param>
        /// <param name="Item9"></param>
        /// <param name="Item10"></param>
        /// <param name="Item11"></param>
        /// <param name="Item12"></param>
        /// <param name="Item13"></param>
        /// <param name="Item14"></param>
        /// <param name="Item15"></param>
        /// <param name="Item16"></param>
        /// <param name="Item17"></param>
        /// <param name="Item18"></param>
        /// <param name="Item19"></param>
        /// <param name="Item20"></param>
        /// <param name="NotEnough"></param>
        /// <returns></returns>
        public static IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5, T6 Item6, T7 Item7, T8 Item8, T9 Item9, T10 Item10, T11 Item11, T12 Item12, T13 Item13, T14 Item14, T15 Item15, T16 Item16, T17 Item17, T18 Item18, T19 Item19, T20 Item20)> Zip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, IEnumerable<T7> Item7, IEnumerable<T8> Item8, IEnumerable<T9> Item9, IEnumerable<T10> Item10, IEnumerable<T11> Item11, IEnumerable<T12> Item12, IEnumerable<T13> Item13, IEnumerable<T14> Item14, IEnumerable<T15> Item15, IEnumerable<T16> Item16, IEnumerable<T17> Item17, IEnumerable<T18> Item18, IEnumerable<T19> Item19, IEnumerable<T20> Item20, ZipNotEnough NotEnough = default)
                    => new ZipTupleEnumerable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9, Item10, Item11, Item12, Item13, Item14, Item15, Item16, Item17, Item18, Item19, Item20, NotEnough);
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T13"></typeparam>
        /// <typeparam name="T14"></typeparam>
        /// <typeparam name="T15"></typeparam>
        /// <typeparam name="T16"></typeparam>
        /// <typeparam name="T17"></typeparam>
        /// <typeparam name="T18"></typeparam>
        /// <typeparam name="T19"></typeparam>
        /// <typeparam name="T20"></typeparam>
        /// <typeparam name="T21"></typeparam>
        /// <param name="Item1"></param>
        /// <param name="Item2"></param>
        /// <param name="Item3"></param>
        /// <param name="Item4"></param>
        /// <param name="Item5"></param>
        /// <param name="Item6"></param>
        /// <param name="Item7"></param>
        /// <param name="Item8"></param>
        /// <param name="Item9"></param>
        /// <param name="Item10"></param>
        /// <param name="Item11"></param>
        /// <param name="Item12"></param>
        /// <param name="Item13"></param>
        /// <param name="Item14"></param>
        /// <param name="Item15"></param>
        /// <param name="Item16"></param>
        /// <param name="Item17"></param>
        /// <param name="Item18"></param>
        /// <param name="Item19"></param>
        /// <param name="Item20"></param>
        /// <param name="Item21"></param>
        /// <param name="NotEnough"></param>
        /// <returns></returns>
        public static IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5, T6 Item6, T7 Item7, T8 Item8, T9 Item9, T10 Item10, T11 Item11, T12 Item12, T13 Item13, T14 Item14, T15 Item15, T16 Item16, T17 Item17, T18 Item18, T19 Item19, T20 Item20, T21 Item21)> Zip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, IEnumerable<T7> Item7, IEnumerable<T8> Item8, IEnumerable<T9> Item9, IEnumerable<T10> Item10, IEnumerable<T11> Item11, IEnumerable<T12> Item12, IEnumerable<T13> Item13, IEnumerable<T14> Item14, IEnumerable<T15> Item15, IEnumerable<T16> Item16, IEnumerable<T17> Item17, IEnumerable<T18> Item18, IEnumerable<T19> Item19, IEnumerable<T20> Item20, IEnumerable<T21> Item21, ZipNotEnough NotEnough = default)
                    => new ZipTupleEnumerable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9, Item10, Item11, Item12, Item13, Item14, Item15, Item16, Item17, Item18, Item19, Item20, Item21, NotEnough);

    }
}
