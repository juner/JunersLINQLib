using System;
using System.Collections.Generic;
using System.Linq;

namespace Juners.Linq
{
    public static class SimultaneousExntensions
    {
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Item1">合成するIEnumerableの一つ目</param>
        /// <param name="NotEnough">列挙数が足りない場合の挙動</param>
        /// <param name="Items">合成するIEnumerableの二つ目以降</param>
        /// <returns></returns>
        public static IEnumerable<T[]> Simultaneous<T>(this IEnumerable<T> Item1, SimultaneousNotEnough NotEnough, params IEnumerable<T>[] Items)
            => new SimpleSimultaneousEnumerable<T>(NotEnough, new[] { Item1 }.Concat(Items));
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
        public static IEnumerable<TResult> Simultaneous<T, TResult>(this IEnumerable<T> Item1, SimultaneousNotEnough NotEnough, Func<T[], TResult> Action, params IEnumerable<T>[] Items)
            => new SimpleSimultaneousEnumerable<T, TResult>(NotEnough, Action, new[] { Item1 }.Concat(Items));
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
        public static IEnumerable<TResult> Simultaneous<T1, T2, TResult>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, Func<T1, T2, TResult> Action, SimultaneousNotEnough NotEnough = default)
            => new SimultaneousEnumerable<T1, T2, TResult>(Item1, Item2, Action, NotEnough);

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
        public static IEnumerable<(T1 Item1, T2 Item2, T3 Item3)> Simultaneous<T1, T2, T3>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, SimultaneousNotEnough NotEnough = default)
            => Simultaneous(Item1, Item2, Item3, (v1, v2, v3) => (v1, v2, v3));
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
        public static IEnumerable<TResult> Simultaneous<T1, T2, T3, TResult>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, Func<T1, T2, T3, TResult> Action, SimultaneousNotEnough NotEnough = default)
            => new SimultaneousEnumerable<T1, T2, T3, TResult>(Item1, Item2, Item3, Action, NotEnough);
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
        public static IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4)> SimultaneousOrBreak<T1, T2, T3, T4>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, SimultaneousNotEnough NotEnough = default)
            => Simultaneous(Item1, Item2, Item3, Item4, (v1, v2, v3, v4) => (v1, v2, v3, v4), NotEnough);
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
        public static IEnumerable<TResult> Simultaneous<T1, T2, T3, T4, TResult>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, Func<T1, T2, T3, T4, TResult> Action, SimultaneousNotEnough NotEnough = default)
            => new SimultaneousEnumerable<T1, T2, T3, T4, TResult>(Item1, Item2, Item3, Item4, Action, NotEnough);
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
        public static IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5)> Simultaneous<T1, T2, T3, T4, T5>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, SimultaneousNotEnough NotEnough = default)
            => Simultaneous(Item1, Item2, Item3, Item4, Item5, (v1, v2, v3, v4, v5) => (v1, v2, v3, v4, v5), NotEnough);
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
        public static IEnumerable<TResult> Simultaneous<T1, T2, T3, T4, T5, TResult>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, Func<T1, T2, T3, T4, T5, TResult> Action, SimultaneousNotEnough NotEnough = default)
            => new SimultaneousEnumerable<T1, T2, T3, T4, T5, TResult>(Item1, Item2, Item3, Item4, Item5, Action, NotEnough);
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
        public static IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5, T6 Item6)> Simultaneous<T1, T2, T3, T4, T5, T6>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, SimultaneousNotEnough NotEnough = default)
            => Simultaneous(Item1, Item2, Item3, Item4, Item5, Item6, (v1, v2, v3, v4, v5, v6) => (v1, v2, v3, v4, v5, v6), NotEnough);
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
        public static IEnumerable<TResult> Simultaneous<T1, T2, T3, T4, T5, T6, TResult>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, Func<T1, T2, T3, T4, T5, T6, TResult> Action, SimultaneousNotEnough NotEnough = default)
            => new SimultaneousEnumerable<T1, T2, T3, T4, T5, T6, TResult>(Item1, Item2, Item3, Item4, Item5, Item6, Action, NotEnough);
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
        public static IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5, T6 Item6, T7 Item7)> Simultaneous<T1, T2, T3, T4, T5, T6, T7>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, IEnumerable<T7> Item7, SimultaneousNotEnough NotEnough = default)
            => Simultaneous(Item1, Item2, Item3, Item4, Item5, Item6, Item7, (v1, v2, v3, v4, v5, v6, v7) => (v1, v2, v3, v4, v5, v6, v7), NotEnough);
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
        public static IEnumerable<TResult> Simultaneous<T1, T2, T3, T4, T5, T6, T7, TResult>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, IEnumerable<T7> Item7, Func<T1, T2, T3, T4, T5, T6, T7, TResult> Action, SimultaneousNotEnough NotEnough = default)
            => new SimultaneousEnumerable<T1, T2, T3, T4, T5, T6, T7, TResult>(Item1, Item2, Item3, Item4, Item5, Item6, Item7, Action, NotEnough);
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
        public static IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5, T6 Item6, T7 Item7, T8 Item8)> Simultaneous<T1, T2, T3, T4, T5, T6, T7, T8>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, IEnumerable<T7> Item7, IEnumerable<T8> Item8, SimultaneousNotEnough NotEnough = default)
            => Simultaneous(Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, (v1, v2, v3, v4, v5, v6, v7, v8) => (v1, v2, v3, v4, v5, v6, v7, v8), NotEnough);
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
        public static IEnumerable<TResult> Simultaneous<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, IEnumerable<T7> Item7, IEnumerable<T8> Item8, Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> Action, SimultaneousNotEnough NotEnough = default)
            => new SimultaneousEnumerable<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Action, NotEnough);
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
        public static IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5, T6 Item6, T7 Item7, T8 Item8, T9 Item9)> Simultaneous<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, IEnumerable<T7> Item7, IEnumerable<T8> Item8, IEnumerable<T9> Item9, SimultaneousNotEnough NotEnough = default)
            => Simultaneous(Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9, (v1, v2, v3, v4, v5, v6, v7, v8, v9) => (v1, v2, v3, v4, v5, v6, v7, v8, v9), NotEnough);
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
        public static IEnumerable<TResult> Simultaneous<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, IEnumerable<T7> Item7, IEnumerable<T8> Item8, IEnumerable<T9> Item9, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> Action, SimultaneousNotEnough NotEnough = default)
            => new SimultaneousEnumerable<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9, Action, NotEnough);
    }
}
