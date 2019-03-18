using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics.Contracts;

namespace Juners.Enumerable
{
    /// <summary>
    /// IEnumerableの合成を行う為のインナークラス
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class SimpleZipEnumerable<T> : IEnumerable<T[]>
    {
        readonly ZipNotEnough NotEnough;
        readonly IEnumerable<IEnumerable<T>> Items;
        public SimpleZipEnumerable(params IEnumerable<T>[] Items) : this((IEnumerable<IEnumerable<T>>)Items) { }
        public SimpleZipEnumerable(ZipNotEnough NotEnough, params IEnumerable<T>[] Items) : this(NotEnough, (IEnumerable<IEnumerable<T>>)Items) { }
        public SimpleZipEnumerable(IEnumerable<IEnumerable<T>> Items) : this(ZipNotEnough.Break, Items) { }
        public SimpleZipEnumerable(ZipNotEnough NotEnough, IEnumerable<IEnumerable<T>> Items)
        {
            Contract.Requires<ArgumentOutOfRangeException>(NotEnough == ZipNotEnough.Break || NotEnough == ZipNotEnough.Default);
            Contract.Requires<ArgumentNullException>(Items != null);
            Contract.Requires<ArgumentException>(Items.All(v => v is IEnumerable<T>));
            (this.NotEnough, this.Items) = (NotEnough, Items);
        }

        public IEnumerator<T[]> GetEnumerator()
        {
            switch (NotEnough)
            {
                case ZipNotEnough.Break:
                    return GetEnumeratorOrBreak();
                case ZipNotEnough.Default:
                    return GetEnumeratorOrDefault();
            }
            throw new NotSupportedException($"{nameof(NotEnough)}({NotEnough}) is NotSupport");
        }
        IEnumerator<T[]> GetEnumeratorOrBreak()
        {
            var Enumerators = Items.Select(v => v.GetEnumerator()).ToArray();
            try
            {
                while (Enumerators.All(v => v.MoveNext()))
                    yield return Enumerators.Select(v => v.Current).ToArray();
            }
            finally
            {
                foreach (var Enumerator in Enumerators)
                    Enumerator.Dispose();
            }
        }
        IEnumerator<T[]> GetEnumeratorOrDefault()
        {

            var Enumerators = Items.Select(v => v.GetEnumerator()).ToArray();
            try
            {
                var defaultValue = default(T);
                var MoveNext = new bool[Enumerators.Length];
                while (Enumerators.Where((v, i) => MoveNext[i] = v.MoveNext()).Count() > 0)
                    yield return Enumerators.Select((v, i) => MoveNext[i] ? v.Current : defaultValue).ToArray();
            }
            finally
            {
                foreach (var Enumerator in Enumerators)
                    Enumerator.Dispose();
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    /// <summary>
    /// IEnumerableの合成を行う為のインナークラス
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    internal class SimpleZipEnumerable<T, TResult> : IEnumerable<TResult>
    {
        readonly Func<T[], TResult> Action;
        readonly ZipNotEnough NotEnough;
        readonly IEnumerable<IEnumerable<T>> Items;
        public SimpleZipEnumerable(ZipNotEnough NotEnough, Func<T[], TResult> Action, IEnumerable<IEnumerable<T>> Items)
        {
            Contract.Requires<ArgumentOutOfRangeException>(NotEnough == ZipNotEnough.Break || NotEnough == ZipNotEnough.Default);
            Contract.Requires<ArgumentNullException>(Action != null);
            Contract.Requires<ArgumentException>(Items.All(v => v is IEnumerable<T>));
            (this.NotEnough, this.Action, this.Items) = (NotEnough, Action, Items);

        }

        public IEnumerator<TResult> GetEnumerator()
        {
            switch (NotEnough)
            {
                case ZipNotEnough.Break:
                    return GetEnumeratorOrBreak();
                case ZipNotEnough.Default:
                    return GetEnumeratorOrDefault();
            }
            throw new NotSupportedException($"{nameof(NotEnough)}({NotEnough}) is NotSupport.");
        }
        IEnumerator<TResult> GetEnumeratorOrBreak()
        {
            var Enumerators = Items.Select(v => v.GetEnumerator()).ToArray();
            try
            {
                while (Enumerators.All(v => v.MoveNext()))
                    yield return Action.Invoke(Enumerators.Select(v => v.Current).ToArray());
            }
            finally
            {
                foreach (var Enumerator in Enumerators)
                    Enumerator.Dispose();
            }
        }
        IEnumerator<TResult> GetEnumeratorOrDefault()
        {

            var Enumerators = Items.Select(v => v.GetEnumerator()).ToArray();
            try
            {
                var dfaultValue = default(T);
                var MoveNext = new bool[Enumerators.Length];
                while (Enumerators.Where((v, i) => MoveNext[i] = v.MoveNext()).Count() > 0)
                    yield return Action.Invoke(Enumerators.Select((v, i) => MoveNext[i] ? v.Current : dfaultValue).ToArray());
            }
            finally
            {
                foreach (var Enumerator in Enumerators)
                    Enumerator.Dispose();
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
