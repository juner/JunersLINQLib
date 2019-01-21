﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Juners.Linq
{
    /// <summary>
    /// IEnumerableの合成を行う為のインナークラス
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class SimpleSimultaneousEnumerable<T> : IEnumerable<T[]>
    {
        readonly SimultaneousNotEnough NotEnough;
        readonly IEnumerable<IEnumerable<T>> Items;
        public SimpleSimultaneousEnumerable(SimultaneousNotEnough NotEnough, IEnumerable<IEnumerable<T>> Items)
            => (this.NotEnough, this.Items) = (NotEnough, Items);

        public IEnumerator<T[]> GetEnumerator()
        {
            switch (NotEnough)
            {
                case SimultaneousNotEnough.Break:
                    return GetEnumeratorOrBreak();
                case SimultaneousNotEnough.Default:
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
                var MoveNext = new bool[Enumerators.Length];
                while (Enumerators.Where((v, i) => MoveNext[i] = v.MoveNext()).Count() > 0)
                    yield return Enumerators.Select((v, i) => MoveNext[i] ? v.Current : default).ToArray();
            }
            finally
            {
                foreach (var Enumerator in Enumerators)
                    Enumerator.Dispose();
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    internal class SimpleSimultaneousEnumerable<T, TResult> : IEnumerable<TResult>
    {
        readonly Func<T[], TResult> Action;
        readonly SimultaneousNotEnough NotEnough;
        readonly IEnumerable<IEnumerable<T>> Items;
        public SimpleSimultaneousEnumerable(SimultaneousNotEnough NotEnough, Func<T[], TResult> Action, IEnumerable<IEnumerable<T>> Items)
            => (this.NotEnough, this.Action, this.Items) = (NotEnough, Action ?? throw new ArgumentNullException(nameof(Action)), Items);

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
                var MoveNext = new bool[Enumerators.Length];
                while (Enumerators.Where((v, i) => MoveNext[i] = v.MoveNext()).Count() > 0)
                    yield return Action.Invoke(Enumerators.Select((v, i) => MoveNext[i] ? v.Current : default).ToArray());
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
