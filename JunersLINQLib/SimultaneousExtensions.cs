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
            => new SimpleSimultaneousEnumerable<T,TResult>(NotEnough, Action, new[] { Item1 }.Concat(Items));
        /// <summary>
        /// IEnumerableを並行に合成する。
        /// </summary>
        /// <typeparam name="T1">入力型1</typeparam>
        /// <typeparam name="T2">入力型2</typeparam>
        /// <typeparam name="TResult">出力型</typeparam>
        /// <param name="Item1">一つ目のIEnumerable</param>
        /// <param name="Item2">二つ目のIEnumerable</param>
        /// <param name="NotEnough"></param>
        /// <param name="Action"></param>
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
        /// <returns></returns>
        public static IEnumerable<(T1 Item1, T2 Item2, T3 Item3)> SimultaneousOrBreak<T1, T2, T3>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3)
            => SimultaneousOrBreak(Item1, Item2, Item3, (v1, v2, v3) => (v1, v2, v3));
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
        /// <returns></returns>
        public static IEnumerable<TResult> SimultaneousOrBreak<T1, T2, T3, TResult>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, Func<T1, T2, T3, TResult> Action)
        {
            using (var Enumerator1 = Item1?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item1)))
            using (var Enumerator2 = Item2?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item2)))
            using (var Enumerator3 = Item3?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item3)))
                while (Enumerator1.MoveNext()
                    && Enumerator2.MoveNext()
                    && Enumerator3.MoveNext())
                    yield return (Action ?? throw new ArgumentNullException(nameof(Action)))
                        .Invoke(Enumerator1.Current
                        , Enumerator2.Current
                        , Enumerator3.Current);
        }
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
        /// <returns></returns>
        public static IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4)> SimultaneousOrBreak<T1, T2, T3, T4>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4)
            => SimultaneousOrBreak(Item1, Item2, Item3, Item4, (v1, v2, v3, v4) => (v1, v2, v3, v4));
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
        /// <returns></returns>
        public static IEnumerable<TResult> SimultaneousOrBreak<T1, T2, T3, T4, TResult>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, Func<T1, T2, T3, T4, TResult> Action)
        {
            using (var Enumerator1 = Item1?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item1)))
            using (var Enumerator2 = Item2?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item2)))
            using (var Enumerator3 = Item3?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item3)))
            using (var Enumerator4 = Item4?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item4)))
                while (Enumerator1.MoveNext()
                    && Enumerator2.MoveNext()
                    && Enumerator3.MoveNext()
                    && Enumerator4.MoveNext())
                    yield return (Action ?? throw new ArgumentNullException(nameof(Action)))
                        .Invoke(Enumerator1.Current
                        , Enumerator2.Current
                        , Enumerator3.Current
                        , Enumerator4.Current);
        }
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
        /// <returns></returns>
        public static IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5)> SimultaneousOrBreak<T1, T2, T3, T4, T5>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5)
            => SimultaneousOrBreak(Item1, Item2, Item3, Item4, Item5, (v1, v2, v3, v4, v5) => (v1, v2, v3, v4, v5));
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
        /// <returns></returns>
        public static IEnumerable<TResult> SimultaneousOrBreak<T1, T2, T3, T4, T5, TResult>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, Func<T1, T2, T3, T4, T5, TResult> Action)
        {
            using (var Enumerator1 = Item1?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item1)))
            using (var Enumerator2 = Item2?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item2)))
            using (var Enumerator3 = Item3?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item3)))
            using (var Enumerator4 = Item4?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item4)))
            using (var Enumerator5 = Item5?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item5)))
                while (Enumerator1.MoveNext()
                    && Enumerator2.MoveNext()
                    && Enumerator3.MoveNext()
                    && Enumerator4.MoveNext()
                    && Enumerator5.MoveNext())
                    yield return (Action ?? throw new ArgumentNullException(nameof(Action)))
                        .Invoke(Enumerator1.Current
                        , Enumerator2.Current
                        , Enumerator3.Current
                        , Enumerator4.Current
                        , Enumerator5.Current);
        }
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
        /// <returns></returns>
        public static IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5, T6 Item6)> SimultaneousOrBreak<T1, T2, T3, T4, T5, T6>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6)
            => SimultaneousOrBreak(Item1, Item2, Item3, Item4, Item5, Item6, (v1, v2, v3, v4, v5, v6) => (v1, v2, v3, v4, v5, v6));
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
        /// <returns></returns>
        public static IEnumerable<TResult> SimultaneousOrBreak<T1, T2, T3, T4, T5, T6, TResult>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, Func<T1, T2, T3, T4, T5, T6, TResult> Action)
        {
            using (var Enumerator1 = Item1?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item1)))
            using (var Enumerator2 = Item2?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item2)))
            using (var Enumerator3 = Item3?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item3)))
            using (var Enumerator4 = Item4?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item4)))
            using (var Enumerator5 = Item5?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item5)))
            using (var Enumerator6 = Item6?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item6)))
                while (Enumerator1.MoveNext()
                    && Enumerator2.MoveNext()
                    && Enumerator3.MoveNext()
                    && Enumerator4.MoveNext()
                    && Enumerator5.MoveNext()
                    && Enumerator6.MoveNext())
                    yield return (Action ?? throw new ArgumentNullException(nameof(Action)))
                        .Invoke(Enumerator1.Current
                        , Enumerator2.Current
                        , Enumerator3.Current
                        , Enumerator4.Current
                        , Enumerator5.Current
                        , Enumerator6.Current);
        }
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
        public static IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5, T6 Item6, T7 Item7)> SimultaneousOrBreak<T1, T2, T3, T4, T5, T6, T7>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, IEnumerable<T7> Item7)
            => SimultaneousOrBreak(Item1, Item2, Item3, Item4, Item5, Item6, Item7, (v1, v2, v3, v4, v5, v6, v7) => (v1, v2, v3, v4, v5, v6, v7));
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
        /// <returns></returns>
        public static IEnumerable<TResult> SimultaneousOrBreak<T1, T2, T3, T4, T5, T6, T7, TResult>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, IEnumerable<T7> Item7, Func<T1, T2, T3, T4, T5, T6, T7, TResult> Action)
        {
            using (var Enumerator1 = Item1?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item1)))
            using (var Enumerator2 = Item2?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item2)))
            using (var Enumerator3 = Item3?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item3)))
            using (var Enumerator4 = Item4?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item4)))
            using (var Enumerator5 = Item5?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item5)))
            using (var Enumerator6 = Item6?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item6)))
            using (var Enumerator7 = Item7?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item7)))
                while (Enumerator1.MoveNext()
                    && Enumerator2.MoveNext()
                    && Enumerator3.MoveNext()
                    && Enumerator4.MoveNext()
                    && Enumerator5.MoveNext()
                    && Enumerator6.MoveNext()
                    && Enumerator7.MoveNext())
                    yield return (Action ?? throw new ArgumentNullException(nameof(Action)))
                        .Invoke(Enumerator1.Current
                        , Enumerator2.Current
                        , Enumerator3.Current
                        , Enumerator4.Current
                        , Enumerator5.Current
                        , Enumerator6.Current
                        , Enumerator7.Current);
        }
        public static IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5, T6 Item6, T7 Item7, T8 Item8)> SimultaneousOrBreak<T1, T2, T3, T4, T5, T6, T7, T8>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, IEnumerable<T7> Item7, IEnumerable<T8> Item8)
            => Simultaneous(Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, (v1, v2, v3, v4, v5, v6, v7, v8) => (v1, v2, v3, v4, v5, v6, v7, v8));
        public static IEnumerable<TResult> Simultaneous<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, IEnumerable<T7> Item7, IEnumerable<T8> Item8, Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> Action)
        {
            using (var Enumerator1 = Item1?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item1)))
            using (var Enumerator2 = Item2?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item2)))
            using (var Enumerator3 = Item3?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item3)))
            using (var Enumerator4 = Item4?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item4)))
            using (var Enumerator5 = Item5?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item5)))
            using (var Enumerator6 = Item6?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item6)))
            using (var Enumerator7 = Item7?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item7)))
            using (var Enumerator8 = Item8?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item8)))
                while (Enumerator1.MoveNext()
                    && Enumerator2.MoveNext()
                    && Enumerator3.MoveNext()
                    && Enumerator4.MoveNext()
                    && Enumerator5.MoveNext()
                    && Enumerator6.MoveNext()
                    && Enumerator7.MoveNext())
                    yield return (Action ?? throw new ArgumentNullException(nameof(Action)))
                        .Invoke(Enumerator1.Current
                        , Enumerator2.Current
                        , Enumerator3.Current
                        , Enumerator4.Current
                        , Enumerator5.Current
                        , Enumerator6.Current
                        , Enumerator7.Current
                        , Enumerator8.Current);
        }
        public static IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5, T6 Item6, T7 Item7, T8 Item8, T9 Item9)> SimultaneousOrBreak<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, IEnumerable<T7> Item7, IEnumerable<T8> Item8, IEnumerable<T9> Item9)
            => SimultaneousOrBreak(Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9, (v1, v2, v3, v4, v5, v6, v7, v8, v9) => (v1, v2, v3, v4, v5, v6, v7, v8, v9));
        public static IEnumerable<TResult> SimultaneousOrBreak<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, IEnumerable<T7> Item7, IEnumerable<T8> Item8, IEnumerable<T9> Item9, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> Action)
        {
            using (var Enumerator1 = Item1?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item1)))
            using (var Enumerator2 = Item2?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item2)))
            using (var Enumerator3 = Item3?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item3)))
            using (var Enumerator4 = Item4?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item4)))
            using (var Enumerator5 = Item5?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item5)))
            using (var Enumerator6 = Item6?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item6)))
            using (var Enumerator7 = Item7?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item7)))
            using (var Enumerator8 = Item8?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item8)))
            using (var Enumerator9 = Item9?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item9)))
                while (Enumerator1.MoveNext()
                    && Enumerator2.MoveNext()
                    && Enumerator3.MoveNext()
                    && Enumerator4.MoveNext()
                    && Enumerator5.MoveNext()
                    && Enumerator6.MoveNext()
                    && Enumerator7.MoveNext())
                    yield return (Action ?? throw new ArgumentNullException(nameof(Action)))
                        .Invoke(Enumerator1.Current
                        , Enumerator2.Current
                        , Enumerator3.Current
                        , Enumerator4.Current
                        , Enumerator5.Current
                        , Enumerator6.Current
                        , Enumerator7.Current
                        , Enumerator8.Current
                        , Enumerator9.Current);
        }
    }
}
