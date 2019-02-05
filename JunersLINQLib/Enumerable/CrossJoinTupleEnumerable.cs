using System;
using System.Collections;
using System.Collections.Generic;

namespace Juners.Enumerable {
    /// <summary>
    /// CROSS JOIN する
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    internal class CrossJoinTupleEnumerable<T1, T2> : IEnumerable<(T1 Item1, T2 Item2)> {
        readonly IEnumerable<T1> Item1;
        readonly IEnumerable<T2> Item2;
        public CrossJoinTupleEnumerable(IEnumerable<T1> Item1, IEnumerable<T2> Item2)
            => (this.Item1
            , this.Item2) = (Item1 ?? throw new ArgumentNullException(nameof(Item1))
            , Item2 ?? throw new ArgumentNullException(nameof(Item2)));
        public IEnumerator<(T1 Item1, T2 Item2)> GetEnumerator()
        {
            foreach (var item1 in Item1)
                foreach (var item2 in Item2)
                    yield return (item1, item2);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    /// <summary>
    /// CROSS JOIN する
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    internal class CrossJoinTupleEnumerable<T1, T2, T3> : IEnumerable<(T1 Item1, T2 Item2, T3 Item3)> {
        readonly IEnumerable<T1> Item1;
        readonly IEnumerable<T2> Item2;
        readonly IEnumerable<T3> Item3;
        public CrossJoinTupleEnumerable(IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3)
            => (this.Item1
            , this.Item2
            , this.Item3) = (Item1 ?? throw new ArgumentNullException(nameof(Item1))
            , Item2 ?? throw new ArgumentNullException(nameof(Item2))
            , Item3 ?? throw new ArgumentNullException(nameof(Item3)));
        public IEnumerator<(T1 Item1, T2 Item2, T3 Item3)> GetEnumerator()
        {
            foreach (var item1 in Item1)
                foreach (var item2 in Item2)
                    foreach (var item3 in Item3)
                        yield return (item1, item2, item3);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
