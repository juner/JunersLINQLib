using System;
using System.Collections;
using System.Collections.Generic;

namespace Juners.Enumerable {
    /// <summary>
    /// CROSS JOIN する
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    internal class CrossJoinEnumerable<T1, T2, TResult> : IEnumerable<TResult> {
        readonly IEnumerable<T1> Item1;
        readonly IEnumerable<T2> Item2;
        readonly Func<T1, T2, TResult> Action;
        public CrossJoinEnumerable(IEnumerable<T1> Item1, IEnumerable<T2> Item2, Func<T1, T2, TResult> Action)
            => (this.Item1
            , this.Item2
            , this.Action) = (Item1 ?? throw new ArgumentNullException(nameof(Item1))
            , Item2 ?? throw new ArgumentNullException(nameof(Item2))
            , Action ?? throw new ArgumentNullException(nameof(Action)));
        public IEnumerator<TResult> GetEnumerator()
        {
            foreach (var item1 in Item1)
                foreach (var item2 in Item2)
                    yield return Action(item1, item2);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    /// <summary>
    /// CROSS JOIN する
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    internal class CrossJoinEnumerable<T1, T2, T3, TResult> : IEnumerable<TResult> {
        readonly IEnumerable<T1> Item1;
        readonly IEnumerable<T2> Item2;
        readonly IEnumerable<T3> Item3;
        readonly Func<T1, T2, T3, TResult> Action;
        public CrossJoinEnumerable(IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, Func<T1, T2, T3, TResult> Action)
            => (this.Item1
            , this.Item2
            , this.Item3
            , this.Action) = (Item1 ?? throw new ArgumentNullException(nameof(Item1))
            , Item2 ?? throw new ArgumentNullException(nameof(Item2))
            , Item3 ?? throw new ArgumentNullException(nameof(Item3))
            , Action ?? throw new ArgumentNullException(nameof(Action)));
        public IEnumerator<TResult> GetEnumerator()
        {
            foreach (var item1 in Item1)
                foreach (var item2 in Item2)
                    foreach (var item3 in Item3)
                        yield return Action(item1, item2, item3);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
