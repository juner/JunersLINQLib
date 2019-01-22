using System;
using System.Collections;
using System.Collections.Generic;

namespace Juners.Linq
{
    internal class SimultaneousEnumerable<T1, T2, TResult> : IEnumerable<TResult>
    {
        readonly IEnumerable<T1> Item1;
        readonly IEnumerable<T2> Item2;
        readonly SimultaneousNotEnough NotEnough;
        readonly Func<T1, T2, TResult> Action;
        public SimultaneousEnumerable(IEnumerable<T1> Item1, IEnumerable<T2> Item2, Func<T1, T2, TResult> Action, SimultaneousNotEnough NotEnough = default)
            => (this.Item1, this.Item2, this.NotEnough, this.Action) = (
            Item1 ?? throw new ArgumentNullException(nameof(Item1))
            , Item2 ?? throw new ArgumentNullException(nameof(Item2))
            , NotEnough
            , Action ?? throw new ArgumentNullException(nameof(Action)));
        public IEnumerator<TResult> GetEnumerator()
        {
            switch (NotEnough)
            {
                case SimultaneousNotEnough.Break:
                    return GetEnumeratorOrBreak();
                case SimultaneousNotEnough.Default:
                    return GetEnumeratorOrDefault();
            }
            throw new NotSupportedException($"{nameof(NotEnough)}({NotEnough}) is NotSupport.");
        }
        IEnumerator<TResult> GetEnumeratorOrBreak()
        {
            using (var Enumerator1 = Item1?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item1)))
            using (var Enumerator2 = Item2?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item2)))
                while (Enumerator1.MoveNext()
                    && Enumerator2.MoveNext())
                    yield return (Action ?? throw new ArgumentNullException(nameof(Action)))
                        .Invoke(Enumerator1.Current
                        , Enumerator2.Current);
        }
        IEnumerator<TResult> GetEnumeratorOrDefault()
        {
            using (var Enumerator1 = Item1?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item1)))
            using (var Enumerator2 = Item2?.GetEnumerator() ?? throw new ArgumentNullException(nameof(Item2)))
            {
                var MoveNext1 = Enumerator1.MoveNext();
                var MoveNext2 = Enumerator2.MoveNext();
                while (MoveNext1 || MoveNext2)
                {
                    yield return (Action ?? throw new ArgumentNullException(nameof(Action)))
                        .Invoke(MoveNext1 ? Enumerator1.Current : default
                        , MoveNext2 ? Enumerator2.Current : default);
                    MoveNext1 = Enumerator1.MoveNext();
                    MoveNext2 = Enumerator2.MoveNext();
                }
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
