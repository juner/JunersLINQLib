using System;
using System.Collections;
using System.Collections.Generic;
using Juners.Enumerable;

namespace Juners.Enumerable {
    internal class ZipEnumerable<T1, T2, TResult> : IEnumerable<TResult> {
        private readonly IEnumerable<T1> Item1;
        private readonly IEnumerable<T2> Item2;
        private readonly ZipNotEnough NotEnough;
        private readonly Func<T1, T2, TResult> Action;
        public ZipEnumerable(IEnumerable<T1> Item1, IEnumerable<T2> Item2, Func<T1, T2, TResult> Action, ZipNotEnough NotEnough = default)
            => (this.Item1, this.Item2, this.Action, this.NotEnough) = (
            Item1 ?? throw new ArgumentNullException(nameof(Item1))
            , Item2 ?? throw new ArgumentNullException(nameof(Item2))
            , Action ?? throw new ArgumentNullException(nameof(Action))
            , NotEnough);
        public IEnumerator<TResult> GetEnumerator()
        {
            switch (NotEnough) {
            case ZipNotEnough.Break:
                return GetEnumeratorOrBreak();
            case ZipNotEnough.Default:
                return GetEnumeratorOrDefault();
            }
            throw new NotSupportedException($"{nameof(NotEnough)}({NotEnough}) is NotSupport.");
        }

        private IEnumerator<TResult> GetEnumeratorOrBreak()
        {
            using (var Enumerator1 = Item1?.GetEnumerator())
            using (var Enumerator2 = Item2?.GetEnumerator())
                while (Enumerator1.MoveNext()
                    && Enumerator2.MoveNext())
                    yield return Action
                        .Invoke(Enumerator1.Current
                        , Enumerator2.Current);
        }

        private IEnumerator<TResult> GetEnumeratorOrDefault()
        {
            using (var Enumerator1 = Item1.GetEnumerator())
            using (var Enumerator2 = Item2.GetEnumerator())
                for (var (MoveNext1, MoveNext2) = (Enumerator1.MoveNext(), Enumerator2.MoveNext());
                    MoveNext1 || MoveNext2;
                    (MoveNext1, MoveNext2) = (Enumerator1.MoveNext(), Enumerator2.MoveNext())) 
                    yield return Action
                        .Invoke(MoveNext1 ? Enumerator1.Current : default
                        , MoveNext2 ? Enumerator2.Current : default);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    internal class ZipEnumerable<T1, T2, T3, TResult> : IEnumerable<TResult> {
        private readonly IEnumerable<T1> Item1;
        private readonly IEnumerable<T2> Item2;
        private readonly IEnumerable<T3> Item3;
        private readonly ZipNotEnough NotEnough;
        private readonly Func<T1, T2, T3, TResult> Action;
        public ZipEnumerable(IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, Func<T1, T2, T3, TResult> Action, ZipNotEnough NotEnough = default)
            => (this.Item1, this.Item2, this.Item3, this.Action, this.NotEnough) = (
            Item1 ?? throw new ArgumentNullException(nameof(Item1))
            , Item2 ?? throw new ArgumentNullException(nameof(Item2))
            , Item3 ?? throw new ArgumentNullException(nameof(Item3))
            , Action ?? throw new ArgumentNullException(nameof(Action))
            , NotEnough);
        public IEnumerator<TResult> GetEnumerator()
        {
            switch (NotEnough) {
            case ZipNotEnough.Break:
                return GetEnumeratorOrBreak();
            case ZipNotEnough.Default:
                return GetEnumeratorOrDefault();
            }
            throw new NotSupportedException($"{nameof(NotEnough)}({NotEnough}) is NotSupport.");
        }
        private IEnumerator<TResult> GetEnumeratorOrBreak()
        {
            using (var Enumerator1 = Item1?.GetEnumerator())
            using (var Enumerator2 = Item2?.GetEnumerator())
            using (var Enumerator3 = Item3?.GetEnumerator())
                while (Enumerator1.MoveNext()
                    && Enumerator2.MoveNext()
                    && Enumerator3.MoveNext())
                    yield return Action
                        .Invoke(Enumerator1.Current
                        , Enumerator2.Current
                        , Enumerator3.Current);
        }
        private IEnumerator<TResult> GetEnumeratorOrDefault()
        {
            using (var Enumerator1 = Item1?.GetEnumerator())
            using (var Enumerator2 = Item2?.GetEnumerator())
            using (var Enumerator3 = Item3?.GetEnumerator())
                for (var (MoveNext1, MoveNext2, MoveNext3) = (Enumerator1.MoveNext(), Enumerator2.MoveNext(), Enumerator3.MoveNext());
                    MoveNext1 || MoveNext2 || MoveNext3;
                    (MoveNext1, MoveNext2, MoveNext3) = (Enumerator1.MoveNext(), Enumerator2.MoveNext(), Enumerator3.MoveNext()))
                    yield return Action
                        .Invoke(MoveNext1 ? Enumerator1.Current : default
                        , MoveNext2 ? Enumerator2.Current : default
                        , MoveNext3 ? Enumerator3.Current : default);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    internal class ZipEnumerable<T1, T2, T3, T4, TResult> : IEnumerable<TResult> {
        private readonly IEnumerable<T1> Item1;
        private readonly IEnumerable<T2> Item2;
        private readonly IEnumerable<T3> Item3;
        private readonly IEnumerable<T4> Item4;
        private readonly ZipNotEnough NotEnough;
        private readonly Func<T1, T2, T3, T4, TResult> Action;
        public ZipEnumerable(IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, Func<T1, T2, T3, T4, TResult> Action, ZipNotEnough NotEnough = default)
            => (this.Item1, this.Item2, this.Item3, this.Item4, this.Action, this.NotEnough) = (
            Item1 ?? throw new ArgumentNullException(nameof(Item1))
            , Item2 ?? throw new ArgumentNullException(nameof(Item2))
            , Item3 ?? throw new ArgumentNullException(nameof(Item3))
            , Item4 ?? throw new ArgumentNullException(nameof(Item4))
            , Action ?? throw new ArgumentNullException(nameof(Action))
            , NotEnough);
        public IEnumerator<TResult> GetEnumerator()
        {
            switch (NotEnough) {
            case ZipNotEnough.Break:
                return GetEnumeratorOrBreak();
            case ZipNotEnough.Default:
                return GetEnumeratorOrDefault();
            }
            throw new NotSupportedException($"{nameof(NotEnough)}({NotEnough}) is NotSupport.");
        }
        private IEnumerator<TResult> GetEnumeratorOrBreak()
        {
            using (var Enumerator1 = Item1?.GetEnumerator())
            using (var Enumerator2 = Item2?.GetEnumerator())
            using (var Enumerator3 = Item3?.GetEnumerator())
            using (var Enumerator4 = Item4?.GetEnumerator())
                while (Enumerator1.MoveNext()
                    && Enumerator2.MoveNext()
                    && Enumerator3.MoveNext()
                    && Enumerator4.MoveNext())
                    yield return Action
                        .Invoke(Enumerator1.Current
                        , Enumerator2.Current
                        , Enumerator3.Current
                        , Enumerator4.Current);
        }
        private IEnumerator<TResult> GetEnumeratorOrDefault()
        {
            using (var Enumerator1 = Item1?.GetEnumerator())
            using (var Enumerator2 = Item2?.GetEnumerator())
            using (var Enumerator3 = Item3?.GetEnumerator())
            using (var Enumerator4 = Item4?.GetEnumerator())
                for (var (MoveNext1, MoveNext2, MoveNext3, MoveNext4) = (Enumerator1.MoveNext(), Enumerator2.MoveNext(), Enumerator3.MoveNext(), Enumerator4.MoveNext());
                    MoveNext1 || MoveNext2 || MoveNext3 || MoveNext4;
                    (MoveNext1, MoveNext2, MoveNext3, MoveNext4) = (Enumerator1.MoveNext(), Enumerator2.MoveNext(), Enumerator3.MoveNext(), Enumerator4.MoveNext()))
                    yield return Action
                        .Invoke(MoveNext1 ? Enumerator1.Current : default
                        , MoveNext2 ? Enumerator2.Current : default
                        , MoveNext3 ? Enumerator3.Current : default
                        , MoveNext4 ? Enumerator4.Current : default);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    internal class ZipEnumerable<T1, T2, T3, T4, T5, TResult> : IEnumerable<TResult> {
        private readonly IEnumerable<T1> Item1;
        private readonly IEnumerable<T2> Item2;
        private readonly IEnumerable<T3> Item3;
        private readonly IEnumerable<T4> Item4;
        private readonly IEnumerable<T5> Item5;
        private readonly ZipNotEnough NotEnough;
        private readonly Func<T1, T2, T3, T4, T5, TResult> Action;
        public ZipEnumerable(IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, Func<T1, T2, T3, T4, T5, TResult> Action, ZipNotEnough NotEnough = default)
            => (this.Item1, this.Item2, this.Item3, this.Item4, this.Item5, this.Action, this.NotEnough) = (
            Item1 ?? throw new ArgumentNullException(nameof(Item1))
            , Item2 ?? throw new ArgumentNullException(nameof(Item2))
            , Item3 ?? throw new ArgumentNullException(nameof(Item3))
            , Item4 ?? throw new ArgumentNullException(nameof(Item4))
            , Item5 ?? throw new ArgumentNullException(nameof(Item5))
            , Action ?? throw new ArgumentNullException(nameof(Action))
            , NotEnough);
        public IEnumerator<TResult> GetEnumerator()
        {
            switch (NotEnough) {
            case ZipNotEnough.Break:
                return GetEnumeratorOrBreak();
            case ZipNotEnough.Default:
                return GetEnumeratorOrDefault();
            }
            throw new NotSupportedException($"{nameof(NotEnough)}({NotEnough}) is NotSupport.");
        }
        private IEnumerator<TResult> GetEnumeratorOrBreak()
        {
            using (var Enumerator1 = Item1?.GetEnumerator())
            using (var Enumerator2 = Item2?.GetEnumerator())
            using (var Enumerator3 = Item3?.GetEnumerator())
            using (var Enumerator4 = Item4?.GetEnumerator())
            using (var Enumerator5 = Item5?.GetEnumerator())
                while (Enumerator1.MoveNext()
                    && Enumerator2.MoveNext()
                    && Enumerator3.MoveNext()
                    && Enumerator4.MoveNext()
                    && Enumerator5.MoveNext())
                    yield return Action
                        .Invoke(Enumerator1.Current
                        , Enumerator2.Current
                        , Enumerator3.Current
                        , Enumerator4.Current
                        , Enumerator5.Current);
        }
        private IEnumerator<TResult> GetEnumeratorOrDefault()
        {
            using (var Enumerator1 = Item1?.GetEnumerator())
            using (var Enumerator2 = Item2?.GetEnumerator())
            using (var Enumerator3 = Item3?.GetEnumerator())
            using (var Enumerator4 = Item4?.GetEnumerator())
            using (var Enumerator5 = Item5?.GetEnumerator())
                for (var (MoveNext1
                    , MoveNext2
                    , MoveNext3
                    , MoveNext4
                    , MoveNext5) = (
                        Enumerator1.MoveNext()
                        , Enumerator2.MoveNext()
                        , Enumerator3.MoveNext()
                        , Enumerator4.MoveNext()
                        , Enumerator5.MoveNext());
                    MoveNext1
                    || MoveNext2
                    || MoveNext3
                    || MoveNext4
                    || MoveNext5;
                    (MoveNext1
                    , MoveNext2
                    , MoveNext3
                    , MoveNext4
                    , MoveNext5) = (
                        Enumerator1.MoveNext()
                        , Enumerator2.MoveNext()
                        , Enumerator3.MoveNext()
                        , Enumerator4.MoveNext()
                        , Enumerator5.MoveNext()))
                    yield return Action
                        .Invoke(MoveNext1 ? Enumerator1.Current : default
                        , MoveNext2 ? Enumerator2.Current : default
                        , MoveNext3 ? Enumerator3.Current : default
                        , MoveNext4 ? Enumerator4.Current : default
                        , MoveNext5 ? Enumerator5.Current : default);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    internal class ZipEnumerable<T1, T2, T3, T4, T5, T6, TResult> : IEnumerable<TResult> {
        readonly IEnumerable<T1> Item1;
        readonly IEnumerable<T2> Item2;
        readonly IEnumerable<T3> Item3;
        readonly IEnumerable<T4> Item4;
        readonly IEnumerable<T5> Item5;
        readonly IEnumerable<T6> Item6;
        readonly ZipNotEnough NotEnough;
        readonly Func<T1, T2, T3, T4, T5, T6, TResult> Action;
        public ZipEnumerable(IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, Func<T1, T2, T3, T4, T5, T6, TResult> Action, ZipNotEnough NotEnough = default)
            => (this.Item1, this.Item2, this.Item3, this.Item4, this.Item5, this.Item6, this.Action, this.NotEnough) = (
            Item1 ?? throw new ArgumentNullException(nameof(Item1))
            , Item2 ?? throw new ArgumentNullException(nameof(Item2))
            , Item3 ?? throw new ArgumentNullException(nameof(Item3))
            , Item4 ?? throw new ArgumentNullException(nameof(Item4))
            , Item5 ?? throw new ArgumentNullException(nameof(Item5))
            , Item6 ?? throw new ArgumentNullException(nameof(Item6))
            , Action ?? throw new ArgumentNullException(nameof(Action))
            , NotEnough);
        public IEnumerator<TResult> GetEnumerator()
        {
            switch (NotEnough) {
            case ZipNotEnough.Break:
                return GetEnumeratorOrBreak();
            case ZipNotEnough.Default:
                return GetEnumeratorOrDefault();
            }
            throw new NotSupportedException($"{nameof(NotEnough)}({NotEnough}) is NotSupport.");
        }
        private IEnumerator<TResult> GetEnumeratorOrBreak()
        {
            using (var Enumerator1 = Item1?.GetEnumerator())
            using (var Enumerator2 = Item2?.GetEnumerator())
            using (var Enumerator3 = Item3?.GetEnumerator())
            using (var Enumerator4 = Item4?.GetEnumerator())
            using (var Enumerator5 = Item5?.GetEnumerator())
            using (var Enumerator6 = Item6?.GetEnumerator())
                while (Enumerator1.MoveNext()
                    && Enumerator2.MoveNext()
                    && Enumerator3.MoveNext()
                    && Enumerator4.MoveNext()
                    && Enumerator5.MoveNext()
                    && Enumerator6.MoveNext())
                    yield return Action
                        .Invoke(Enumerator1.Current
                        , Enumerator2.Current
                        , Enumerator3.Current
                        , Enumerator4.Current
                        , Enumerator5.Current
                        , Enumerator6.Current);
        }
        private IEnumerator<TResult> GetEnumeratorOrDefault()
        {
            using (var Enumerator1 = Item1?.GetEnumerator())
            using (var Enumerator2 = Item2?.GetEnumerator())
            using (var Enumerator3 = Item3?.GetEnumerator())
            using (var Enumerator4 = Item4?.GetEnumerator())
            using (var Enumerator5 = Item5?.GetEnumerator())
            using (var Enumerator6 = Item6?.GetEnumerator())
                for (var (MoveNext1
                    , MoveNext2
                    , MoveNext3
                    , MoveNext4
                    , MoveNext5
                    , MoveNext6) = (
                        Enumerator1.MoveNext()
                        , Enumerator2.MoveNext()
                        , Enumerator3.MoveNext()
                        , Enumerator4.MoveNext()
                        , Enumerator5.MoveNext()
                        , Enumerator6.MoveNext());
                    MoveNext1
                    || MoveNext2
                    || MoveNext3
                    || MoveNext4
                    || MoveNext5
                    || MoveNext6;
                    (MoveNext1
                    , MoveNext2
                    , MoveNext3
                    , MoveNext4
                    , MoveNext5
                    , MoveNext6) = (
                        Enumerator1.MoveNext()
                        , Enumerator2.MoveNext()
                        , Enumerator3.MoveNext()
                        , Enumerator4.MoveNext()
                        , Enumerator5.MoveNext()
                        , Enumerator6.MoveNext()))
                    yield return Action
                        .Invoke(MoveNext1 ? Enumerator1.Current : default
                        , MoveNext2 ? Enumerator2.Current : default
                        , MoveNext3 ? Enumerator3.Current : default
                        , MoveNext4 ? Enumerator4.Current : default
                        , MoveNext5 ? Enumerator5.Current : default
                        , MoveNext6 ? Enumerator6.Current : default);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    internal class ZipEnumerable<T1, T2, T3, T4, T5, T6, T7, TResult> : IEnumerable<TResult> {
        readonly IEnumerable<T1> Item1;
        readonly IEnumerable<T2> Item2;
        readonly IEnumerable<T3> Item3;
        readonly IEnumerable<T4> Item4;
        readonly IEnumerable<T5> Item5;
        readonly IEnumerable<T6> Item6;
        readonly IEnumerable<T7> Item7;
        readonly ZipNotEnough NotEnough;
        readonly Func<T1, T2, T3, T4, T5, T6, T7, TResult> Action;
        public ZipEnumerable(IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, IEnumerable<T7> Item7, Func<T1, T2, T3, T4, T5, T6, T7, TResult> Action, ZipNotEnough NotEnough = default)
            => (this.Item1, this.Item2, this.Item3, this.Item4, this.Item5, this.Item6, this.Item7, this.Action, this.NotEnough) = (
            Item1 ?? throw new ArgumentNullException(nameof(Item1))
            , Item2 ?? throw new ArgumentNullException(nameof(Item2))
            , Item3 ?? throw new ArgumentNullException(nameof(Item3))
            , Item4 ?? throw new ArgumentNullException(nameof(Item4))
            , Item5 ?? throw new ArgumentNullException(nameof(Item5))
            , Item6 ?? throw new ArgumentNullException(nameof(Item6))
            , Item7 ?? throw new ArgumentNullException(nameof(Item7))
            , Action ?? throw new ArgumentNullException(nameof(Action))
            , NotEnough);
        public IEnumerator<TResult> GetEnumerator()
        {
            switch (NotEnough) {
            case ZipNotEnough.Break:
                return GetEnumeratorOrBreak();
            case ZipNotEnough.Default:
                return GetEnumeratorOrDefault();
            }
            throw new NotSupportedException($"{nameof(NotEnough)}({NotEnough}) is NotSupport.");
        }
        private IEnumerator<TResult> GetEnumeratorOrBreak()
        {
            using (var Enumerator1 = Item1?.GetEnumerator())
            using (var Enumerator2 = Item2?.GetEnumerator())
            using (var Enumerator3 = Item3?.GetEnumerator())
            using (var Enumerator4 = Item4?.GetEnumerator())
            using (var Enumerator5 = Item5?.GetEnumerator())
            using (var Enumerator6 = Item6?.GetEnumerator())
            using (var Enumerator7 = Item7?.GetEnumerator())
                while (Enumerator1.MoveNext()
                    && Enumerator2.MoveNext()
                    && Enumerator3.MoveNext()
                    && Enumerator4.MoveNext()
                    && Enumerator5.MoveNext()
                    && Enumerator6.MoveNext()
                    && Enumerator7.MoveNext())
                    yield return Action
                        .Invoke(Enumerator1.Current
                        , Enumerator2.Current
                        , Enumerator3.Current
                        , Enumerator4.Current
                        , Enumerator5.Current
                        , Enumerator6.Current
                        , Enumerator7.Current);
        }
        private IEnumerator<TResult> GetEnumeratorOrDefault()
        {
            using (var Enumerator1 = Item1?.GetEnumerator())
            using (var Enumerator2 = Item2?.GetEnumerator())
            using (var Enumerator3 = Item3?.GetEnumerator())
            using (var Enumerator4 = Item4?.GetEnumerator())
            using (var Enumerator5 = Item5?.GetEnumerator())
            using (var Enumerator6 = Item6?.GetEnumerator())
            using (var Enumerator7 = Item7?.GetEnumerator())
                for (var (MoveNext1
                    , MoveNext2
                    , MoveNext3
                    , MoveNext4
                    , MoveNext5
                    , MoveNext6
                    , MoveNext7) = (
                        Enumerator1.MoveNext()
                        , Enumerator2.MoveNext()
                        , Enumerator3.MoveNext()
                        , Enumerator4.MoveNext()
                        , Enumerator5.MoveNext()
                        , Enumerator6.MoveNext()
                        , Enumerator7.MoveNext());
                    MoveNext1
                    || MoveNext2
                    || MoveNext3
                    || MoveNext4
                    || MoveNext5
                    || MoveNext6
                    || MoveNext7;
                    (MoveNext1
                    , MoveNext2
                    , MoveNext3
                    , MoveNext4
                    , MoveNext5
                    , MoveNext6
                    , MoveNext7) = (
                        Enumerator1.MoveNext()
                        , Enumerator2.MoveNext()
                        , Enumerator3.MoveNext()
                        , Enumerator4.MoveNext()
                        , Enumerator5.MoveNext()
                        , Enumerator6.MoveNext()
                        , Enumerator7.MoveNext()))
                    yield return Action
                        .Invoke(MoveNext1 ? Enumerator1.Current : default
                        , MoveNext2 ? Enumerator2.Current : default
                        , MoveNext3 ? Enumerator3.Current : default
                        , MoveNext4 ? Enumerator4.Current : default
                        , MoveNext5 ? Enumerator5.Current : default
                        , MoveNext6 ? Enumerator6.Current : default
                        , MoveNext7 ? Enumerator7.Current : default);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    internal class ZipEnumerable<T1, T2, T3, T4, T5, T6, T7, T8, TResult> : IEnumerable<TResult> {
        readonly IEnumerable<T1> Item1;
        readonly IEnumerable<T2> Item2;
        readonly IEnumerable<T3> Item3;
        readonly IEnumerable<T4> Item4;
        readonly IEnumerable<T5> Item5;
        readonly IEnumerable<T6> Item6;
        readonly IEnumerable<T7> Item7;
        readonly IEnumerable<T8> Item8;
        readonly ZipNotEnough NotEnough;
        readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> Action;
        public ZipEnumerable(IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, IEnumerable<T7> Item7, IEnumerable<T8> Item8, Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> Action, ZipNotEnough NotEnough = default)
            => (this.Item1, this.Item2, this.Item3, this.Item4, this.Item5, this.Item6, this.Item7, this.Item8, this.Action, this.NotEnough) = (
            Item1 ?? throw new ArgumentNullException(nameof(Item1))
            , Item2 ?? throw new ArgumentNullException(nameof(Item2))
            , Item3 ?? throw new ArgumentNullException(nameof(Item3))
            , Item4 ?? throw new ArgumentNullException(nameof(Item4))
            , Item5 ?? throw new ArgumentNullException(nameof(Item5))
            , Item6 ?? throw new ArgumentNullException(nameof(Item6))
            , Item7 ?? throw new ArgumentNullException(nameof(Item7))
            , Item8 ?? throw new ArgumentNullException(nameof(Item8))
            , Action ?? throw new ArgumentNullException(nameof(Action))
            , NotEnough);
        public IEnumerator<TResult> GetEnumerator()
        {
            switch (NotEnough) {
            case ZipNotEnough.Break:
                return GetEnumeratorOrBreak();
            case ZipNotEnough.Default:
                return GetEnumeratorOrDefault();
            }
            throw new NotSupportedException($"{nameof(NotEnough)}({NotEnough}) is NotSupport.");
        }
        private IEnumerator<TResult> GetEnumeratorOrBreak()
        {
            using (var Enumerator1 = Item1?.GetEnumerator())
            using (var Enumerator2 = Item2?.GetEnumerator())
            using (var Enumerator3 = Item3?.GetEnumerator())
            using (var Enumerator4 = Item4?.GetEnumerator())
            using (var Enumerator5 = Item5?.GetEnumerator())
            using (var Enumerator6 = Item6?.GetEnumerator())
            using (var Enumerator7 = Item7?.GetEnumerator())
            using (var Enumerator8 = Item8?.GetEnumerator())
                while (Enumerator1.MoveNext()
                    && Enumerator2.MoveNext()
                    && Enumerator3.MoveNext()
                    && Enumerator4.MoveNext()
                    && Enumerator5.MoveNext()
                    && Enumerator6.MoveNext()
                    && Enumerator7.MoveNext()
                    && Enumerator8.MoveNext())
                    yield return Action
                        .Invoke(Enumerator1.Current
                        , Enumerator2.Current
                        , Enumerator3.Current
                        , Enumerator4.Current
                        , Enumerator5.Current
                        , Enumerator6.Current
                        , Enumerator7.Current
                        , Enumerator8.Current);
        }
        private IEnumerator<TResult> GetEnumeratorOrDefault()
        {
            using (var Enumerator1 = Item1?.GetEnumerator())
            using (var Enumerator2 = Item2?.GetEnumerator())
            using (var Enumerator3 = Item3?.GetEnumerator())
            using (var Enumerator4 = Item4?.GetEnumerator())
            using (var Enumerator5 = Item5?.GetEnumerator())
            using (var Enumerator6 = Item6?.GetEnumerator())
            using (var Enumerator7 = Item7?.GetEnumerator())
            using (var Enumerator8 = Item8?.GetEnumerator())
                for (var (MoveNext1
                    , MoveNext2
                    , MoveNext3
                    , MoveNext4
                    , MoveNext5
                    , MoveNext6
                    , MoveNext7
                    , MoveNext8) = (
                        Enumerator1.MoveNext()
                        , Enumerator2.MoveNext()
                        , Enumerator3.MoveNext()
                        , Enumerator4.MoveNext()
                        , Enumerator5.MoveNext()
                        , Enumerator6.MoveNext()
                        , Enumerator7.MoveNext()
                        , Enumerator8.MoveNext());
                    MoveNext1
                    || MoveNext2
                    || MoveNext3
                    || MoveNext4
                    || MoveNext5
                    || MoveNext6
                    || MoveNext7
                    || MoveNext8;
                    (MoveNext1
                    , MoveNext2
                    , MoveNext3
                    , MoveNext4
                    , MoveNext5
                    , MoveNext6
                    , MoveNext7
                    , MoveNext8) = (
                        Enumerator1.MoveNext()
                        , Enumerator2.MoveNext()
                        , Enumerator3.MoveNext()
                        , Enumerator4.MoveNext()
                        , Enumerator5.MoveNext()
                        , Enumerator6.MoveNext()
                        , Enumerator7.MoveNext()
                        , Enumerator8.MoveNext()))
                    yield return Action
                        .Invoke(MoveNext1 ? Enumerator1.Current : default
                        , MoveNext2 ? Enumerator2.Current : default
                        , MoveNext3 ? Enumerator3.Current : default
                        , MoveNext4 ? Enumerator4.Current : default
                        , MoveNext5 ? Enumerator5.Current : default
                        , MoveNext6 ? Enumerator6.Current : default
                        , MoveNext7 ? Enumerator7.Current : default
                        , MoveNext8 ? Enumerator8.Current : default);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    internal class ZipEnumerable<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> : IEnumerable<TResult> {
        readonly IEnumerable<T1> Item1;
        readonly IEnumerable<T2> Item2;
        readonly IEnumerable<T3> Item3;
        readonly IEnumerable<T4> Item4;
        readonly IEnumerable<T5> Item5;
        readonly IEnumerable<T6> Item6;
        readonly IEnumerable<T7> Item7;
        readonly IEnumerable<T8> Item8;
        readonly IEnumerable<T9> Item9;
        readonly ZipNotEnough NotEnough;
        readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> Action;
        public ZipEnumerable(IEnumerable<T1> Item1, IEnumerable<T2> Item2, IEnumerable<T3> Item3, IEnumerable<T4> Item4, IEnumerable<T5> Item5, IEnumerable<T6> Item6, IEnumerable<T7> Item7, IEnumerable<T8> Item8, IEnumerable<T9> Item9, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> Action, ZipNotEnough NotEnough = default)
            => (this.Item1, this.Item2, this.Item3, this.Item4, this.Item5, this.Item6, this.Item7, this.Item8, this.Item9, this.Action, this.NotEnough) = (
            Item1 ?? throw new ArgumentNullException(nameof(Item1))
            , Item2 ?? throw new ArgumentNullException(nameof(Item2))
            , Item3 ?? throw new ArgumentNullException(nameof(Item3))
            , Item4 ?? throw new ArgumentNullException(nameof(Item4))
            , Item5 ?? throw new ArgumentNullException(nameof(Item5))
            , Item6 ?? throw new ArgumentNullException(nameof(Item6))
            , Item7 ?? throw new ArgumentNullException(nameof(Item7))
            , Item8 ?? throw new ArgumentNullException(nameof(Item8))
            , Item9 ?? throw new ArgumentNullException(nameof(Item9))
            , Action ?? throw new ArgumentNullException(nameof(Action))
            , NotEnough);
        public IEnumerator<TResult> GetEnumerator()
        {
            switch (NotEnough) {
            case ZipNotEnough.Break:
                return GetEnumeratorOrBreak();
            case ZipNotEnough.Default:
                return GetEnumeratorOrDefault();
            }
            throw new NotSupportedException($"{nameof(NotEnough)}({NotEnough}) is NotSupport.");
        }
        private IEnumerator<TResult> GetEnumeratorOrBreak()
        {
            using (var Enumerator1 = Item1?.GetEnumerator())
            using (var Enumerator2 = Item2?.GetEnumerator())
            using (var Enumerator3 = Item3?.GetEnumerator())
            using (var Enumerator4 = Item4?.GetEnumerator())
            using (var Enumerator5 = Item5?.GetEnumerator())
            using (var Enumerator6 = Item6?.GetEnumerator())
            using (var Enumerator7 = Item7?.GetEnumerator())
            using (var Enumerator8 = Item8?.GetEnumerator())
            using (var Enumerator9 = Item9?.GetEnumerator())
                while (Enumerator1.MoveNext()
                    && Enumerator2.MoveNext()
                    && Enumerator3.MoveNext()
                    && Enumerator4.MoveNext()
                    && Enumerator5.MoveNext()
                    && Enumerator6.MoveNext()
                    && Enumerator7.MoveNext()
                    && Enumerator8.MoveNext()
                    && Enumerator9.MoveNext())
                    yield return Action
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
        private IEnumerator<TResult> GetEnumeratorOrDefault()
        {
            using (var Enumerator1 = Item1?.GetEnumerator())
            using (var Enumerator2 = Item2?.GetEnumerator())
            using (var Enumerator3 = Item3?.GetEnumerator())
            using (var Enumerator4 = Item4?.GetEnumerator())
            using (var Enumerator5 = Item5?.GetEnumerator())
            using (var Enumerator6 = Item6?.GetEnumerator())
            using (var Enumerator7 = Item7?.GetEnumerator())
            using (var Enumerator8 = Item8?.GetEnumerator())
            using (var Enumerator9 = Item9?.GetEnumerator())
                for (var (MoveNext1
                    , MoveNext2
                    , MoveNext3
                    , MoveNext4
                    , MoveNext5
                    , MoveNext6
                    , MoveNext7
                    , MoveNext8
                    , MoveNext9) = (
                        Enumerator1.MoveNext()
                        , Enumerator2.MoveNext()
                        , Enumerator3.MoveNext()
                        , Enumerator4.MoveNext()
                        , Enumerator5.MoveNext()
                        , Enumerator6.MoveNext()
                        , Enumerator7.MoveNext()
                        , Enumerator8.MoveNext()
                        , Enumerator9.MoveNext());
                    MoveNext1
                    || MoveNext2
                    || MoveNext3
                    || MoveNext4
                    || MoveNext5
                    || MoveNext6
                    || MoveNext7
                    || MoveNext8
                    || MoveNext9;
                    (MoveNext1
                    , MoveNext2
                    , MoveNext3
                    , MoveNext4
                    , MoveNext5
                    , MoveNext6
                    , MoveNext7
                    , MoveNext8
                    , MoveNext9) = (
                        Enumerator1.MoveNext()
                        , Enumerator2.MoveNext()
                        , Enumerator3.MoveNext()
                        , Enumerator4.MoveNext()
                        , Enumerator5.MoveNext()
                        , Enumerator6.MoveNext()
                        , Enumerator7.MoveNext()
                        , Enumerator8.MoveNext()
                        , Enumerator9.MoveNext()))
                    yield return Action
                        .Invoke(MoveNext1 ? Enumerator1.Current : default
                        , MoveNext2 ? Enumerator2.Current : default
                        , MoveNext3 ? Enumerator3.Current : default
                        , MoveNext4 ? Enumerator4.Current : default
                        , MoveNext5 ? Enumerator5.Current : default
                        , MoveNext6 ? Enumerator6.Current : default
                        , MoveNext7 ? Enumerator7.Current : default
                        , MoveNext8 ? Enumerator8.Current : default
                        , MoveNext9 ? Enumerator9.Current : default);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    internal class ZipEnumerable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> : IEnumerable<TResult> {
        readonly IEnumerable<T1> Item1;
        readonly IEnumerable<T2> Item2;
        readonly IEnumerable<T3> Item3;
        readonly IEnumerable<T4> Item4;
        readonly IEnumerable<T5> Item5;
        readonly IEnumerable<T6> Item6;
        readonly IEnumerable<T7> Item7;
        readonly IEnumerable<T8> Item8;
        readonly IEnumerable<T9> Item9;
        readonly IEnumerable<T10> Item10;
        readonly ZipNotEnough NotEnough;
        readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> Action;
        public ZipEnumerable(IEnumerable<T1> Item1
            , IEnumerable<T2> Item2
            , IEnumerable<T3> Item3
            , IEnumerable<T4> Item4
            , IEnumerable<T5> Item5
            , IEnumerable<T6> Item6
            , IEnumerable<T7> Item7
            , IEnumerable<T8> Item8
            , IEnumerable<T9> Item9
            , IEnumerable<T10> Item10
            , Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> Action, ZipNotEnough NotEnough = default)
            => (this.Item1, this.Item2, this.Item3, this.Item4, this.Item5, this.Item6, this.Item7, this.Item8, this.Item9, this.Item10, this.Action, this.NotEnough) = (
            Item1 ?? throw new ArgumentNullException(nameof(Item1))
            , Item2 ?? throw new ArgumentNullException(nameof(Item2))
            , Item3 ?? throw new ArgumentNullException(nameof(Item3))
            , Item4 ?? throw new ArgumentNullException(nameof(Item4))
            , Item5 ?? throw new ArgumentNullException(nameof(Item5))
            , Item6 ?? throw new ArgumentNullException(nameof(Item6))
            , Item7 ?? throw new ArgumentNullException(nameof(Item7))
            , Item8 ?? throw new ArgumentNullException(nameof(Item8))
            , Item9 ?? throw new ArgumentNullException(nameof(Item9))
            , Item10 ?? throw new ArgumentNullException(nameof(Item10))
            , Action ?? throw new ArgumentNullException(nameof(Action))
            , NotEnough);
        public IEnumerator<TResult> GetEnumerator()
        {
            switch (NotEnough) {
            case ZipNotEnough.Break:
                return GetEnumeratorOrBreak();
            case ZipNotEnough.Default:
                return GetEnumeratorOrDefault();
            }
            throw new NotSupportedException($"{nameof(NotEnough)}({NotEnough}) is NotSupport.");
        }
        private IEnumerator<TResult> GetEnumeratorOrBreak()
        {
            using (var Enumerator1 = Item1?.GetEnumerator())
            using (var Enumerator2 = Item2?.GetEnumerator())
            using (var Enumerator3 = Item3?.GetEnumerator())
            using (var Enumerator4 = Item4?.GetEnumerator())
            using (var Enumerator5 = Item5?.GetEnumerator())
            using (var Enumerator6 = Item6?.GetEnumerator())
            using (var Enumerator7 = Item7?.GetEnumerator())
            using (var Enumerator8 = Item8?.GetEnumerator())
            using (var Enumerator9 = Item9?.GetEnumerator())
            using (var Enumerator10 = Item10?.GetEnumerator())
                while (Enumerator1.MoveNext()
                    && Enumerator2.MoveNext()
                    && Enumerator3.MoveNext()
                    && Enumerator4.MoveNext()
                    && Enumerator5.MoveNext()
                    && Enumerator6.MoveNext()
                    && Enumerator7.MoveNext()
                    && Enumerator8.MoveNext()
                    && Enumerator9.MoveNext()
                    && Enumerator10.MoveNext())
                    yield return Action
                        .Invoke(Enumerator1.Current
                        , Enumerator2.Current
                        , Enumerator3.Current
                        , Enumerator4.Current
                        , Enumerator5.Current
                        , Enumerator6.Current
                        , Enumerator7.Current
                        , Enumerator8.Current
                        , Enumerator9.Current
                        , Enumerator10.Current);
        }
        private IEnumerator<TResult> GetEnumeratorOrDefault()
        {
            using (var Enumerator1 = Item1?.GetEnumerator())
            using (var Enumerator2 = Item2?.GetEnumerator())
            using (var Enumerator3 = Item3?.GetEnumerator())
            using (var Enumerator4 = Item4?.GetEnumerator())
            using (var Enumerator5 = Item5?.GetEnumerator())
            using (var Enumerator6 = Item6?.GetEnumerator())
            using (var Enumerator7 = Item7?.GetEnumerator())
            using (var Enumerator8 = Item8?.GetEnumerator())
            using (var Enumerator9 = Item9?.GetEnumerator())
            using (var Enumerator10 = Item10?.GetEnumerator())
                for (var (MoveNext1
                    , MoveNext2
                    , MoveNext3
                    , MoveNext4
                    , MoveNext5
                    , MoveNext6
                    , MoveNext7
                    , MoveNext8
                    , MoveNext9
                    , MoveNext10) = (
                        Enumerator1.MoveNext()
                        , Enumerator2.MoveNext()
                        , Enumerator3.MoveNext()
                        , Enumerator4.MoveNext()
                        , Enumerator5.MoveNext()
                        , Enumerator6.MoveNext()
                        , Enumerator7.MoveNext()
                        , Enumerator8.MoveNext()
                        , Enumerator9.MoveNext()
                        , Enumerator10.MoveNext());
                    MoveNext1
                    || MoveNext2
                    || MoveNext3
                    || MoveNext4
                    || MoveNext5
                    || MoveNext6
                    || MoveNext7
                    || MoveNext8
                    || MoveNext9
                    || MoveNext10;
                    (MoveNext1
                    , MoveNext2
                    , MoveNext3
                    , MoveNext4
                    , MoveNext5
                    , MoveNext6
                    , MoveNext7
                    , MoveNext8
                    , MoveNext9
                    , MoveNext10) = (
                        Enumerator1.MoveNext()
                        , Enumerator2.MoveNext()
                        , Enumerator3.MoveNext()
                        , Enumerator4.MoveNext()
                        , Enumerator5.MoveNext()
                        , Enumerator6.MoveNext()
                        , Enumerator7.MoveNext()
                        , Enumerator8.MoveNext()
                        , Enumerator9.MoveNext()
                        , Enumerator10.MoveNext()))
                    yield return Action
                        .Invoke(MoveNext1 ? Enumerator1.Current : default
                        , MoveNext2 ? Enumerator2.Current : default
                        , MoveNext3 ? Enumerator3.Current : default
                        , MoveNext4 ? Enumerator4.Current : default
                        , MoveNext5 ? Enumerator5.Current : default
                        , MoveNext6 ? Enumerator6.Current : default
                        , MoveNext7 ? Enumerator7.Current : default
                        , MoveNext8 ? Enumerator8.Current : default
                        , MoveNext9 ? Enumerator9.Current : default
                        , MoveNext10 ? Enumerator10.Current : default);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    internal class ZipEnumerable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> : IEnumerable<TResult> {
        readonly IEnumerable<T1> Item1;
        readonly IEnumerable<T2> Item2;
        readonly IEnumerable<T3> Item3;
        readonly IEnumerable<T4> Item4;
        readonly IEnumerable<T5> Item5;
        readonly IEnumerable<T6> Item6;
        readonly IEnumerable<T7> Item7;
        readonly IEnumerable<T8> Item8;
        readonly IEnumerable<T9> Item9;
        readonly IEnumerable<T10> Item10;
        readonly IEnumerable<T11> Item11;
        readonly ZipNotEnough NotEnough;
        readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Action;
        public ZipEnumerable(IEnumerable<T1> Item1
            , IEnumerable<T2> Item2
            , IEnumerable<T3> Item3
            , IEnumerable<T4> Item4
            , IEnumerable<T5> Item5
            , IEnumerable<T6> Item6
            , IEnumerable<T7> Item7
            , IEnumerable<T8> Item8
            , IEnumerable<T9> Item9
            , IEnumerable<T10> Item10
            , IEnumerable<T11> Item11
            , Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Action, ZipNotEnough NotEnough = default)
            => (this.Item1
            , this.Item2
            , this.Item3
            , this.Item4
            , this.Item5
            , this.Item6
            , this.Item7
            , this.Item8
            , this.Item9
            , this.Item10
            , this.Item11
            , this.Action
            , this.NotEnough) = (
                Item1 ?? throw new ArgumentNullException(nameof(Item1))
                , Item2 ?? throw new ArgumentNullException(nameof(Item2))
                , Item3 ?? throw new ArgumentNullException(nameof(Item3))
                , Item4 ?? throw new ArgumentNullException(nameof(Item4))
                , Item5 ?? throw new ArgumentNullException(nameof(Item5))
                , Item6 ?? throw new ArgumentNullException(nameof(Item6))
                , Item7 ?? throw new ArgumentNullException(nameof(Item7))
                , Item8 ?? throw new ArgumentNullException(nameof(Item8))
                , Item9 ?? throw new ArgumentNullException(nameof(Item9))
                , Item10 ?? throw new ArgumentNullException(nameof(Item10))
                , Item11 ?? throw new ArgumentNullException(nameof(Item11))
                , Action ?? throw new ArgumentNullException(nameof(Action))
                , NotEnough);
        public IEnumerator<TResult> GetEnumerator()
        {
            switch (NotEnough) {
            case ZipNotEnough.Break:
                return GetEnumeratorOrBreak();
            case ZipNotEnough.Default:
                return GetEnumeratorOrDefault();
            }
            throw new NotSupportedException($"{nameof(NotEnough)}({NotEnough}) is NotSupport.");
        }
        private IEnumerator<TResult> GetEnumeratorOrBreak()
        {
            using (var Enumerator1 = Item1?.GetEnumerator())
            using (var Enumerator2 = Item2?.GetEnumerator())
            using (var Enumerator3 = Item3?.GetEnumerator())
            using (var Enumerator4 = Item4?.GetEnumerator())
            using (var Enumerator5 = Item5?.GetEnumerator())
            using (var Enumerator6 = Item6?.GetEnumerator())
            using (var Enumerator7 = Item7?.GetEnumerator())
            using (var Enumerator8 = Item8?.GetEnumerator())
            using (var Enumerator9 = Item9?.GetEnumerator())
            using (var Enumerator10 = Item10?.GetEnumerator())
            using (var Enumerator11 = Item11?.GetEnumerator())
                while (Enumerator1.MoveNext()
                    && Enumerator2.MoveNext()
                    && Enumerator3.MoveNext()
                    && Enumerator4.MoveNext()
                    && Enumerator5.MoveNext()
                    && Enumerator6.MoveNext()
                    && Enumerator7.MoveNext()
                    && Enumerator8.MoveNext()
                    && Enumerator9.MoveNext()
                    && Enumerator10.MoveNext()
                    && Enumerator11.MoveNext())
                    yield return Action
                        .Invoke(Enumerator1.Current
                        , Enumerator2.Current
                        , Enumerator3.Current
                        , Enumerator4.Current
                        , Enumerator5.Current
                        , Enumerator6.Current
                        , Enumerator7.Current
                        , Enumerator8.Current
                        , Enumerator9.Current
                        , Enumerator10.Current
                        , Enumerator11.Current);
        }
        private IEnumerator<TResult> GetEnumeratorOrDefault()
        {
            using (var Enumerator1 = Item1?.GetEnumerator())
            using (var Enumerator2 = Item2?.GetEnumerator())
            using (var Enumerator3 = Item3?.GetEnumerator())
            using (var Enumerator4 = Item4?.GetEnumerator())
            using (var Enumerator5 = Item5?.GetEnumerator())
            using (var Enumerator6 = Item6?.GetEnumerator())
            using (var Enumerator7 = Item7?.GetEnumerator())
            using (var Enumerator8 = Item8?.GetEnumerator())
            using (var Enumerator9 = Item9?.GetEnumerator())
            using (var Enumerator10 = Item10?.GetEnumerator())
            using (var Enumerator11 = Item11?.GetEnumerator())
                for (var (MoveNext1
                    , MoveNext2
                    , MoveNext3
                    , MoveNext4
                    , MoveNext5
                    , MoveNext6
                    , MoveNext7
                    , MoveNext8
                    , MoveNext9
                    , MoveNext10
                    , MoveNext11) = (
                        Enumerator1.MoveNext()
                        , Enumerator2.MoveNext()
                        , Enumerator3.MoveNext()
                        , Enumerator4.MoveNext()
                        , Enumerator5.MoveNext()
                        , Enumerator6.MoveNext()
                        , Enumerator7.MoveNext()
                        , Enumerator8.MoveNext()
                        , Enumerator9.MoveNext()
                        , Enumerator10.MoveNext()
                        , Enumerator11.MoveNext());
                    MoveNext1
                    || MoveNext2
                    || MoveNext3
                    || MoveNext4
                    || MoveNext5
                    || MoveNext6
                    || MoveNext7
                    || MoveNext8
                    || MoveNext9
                    || MoveNext10
                    || MoveNext11;
                    (MoveNext1
                    , MoveNext2
                    , MoveNext3
                    , MoveNext4
                    , MoveNext5
                    , MoveNext6
                    , MoveNext7
                    , MoveNext8
                    , MoveNext9
                    , MoveNext10
                    , MoveNext11) = (
                        Enumerator1.MoveNext()
                        , Enumerator2.MoveNext()
                        , Enumerator3.MoveNext()
                        , Enumerator4.MoveNext()
                        , Enumerator5.MoveNext()
                        , Enumerator6.MoveNext()
                        , Enumerator7.MoveNext()
                        , Enumerator8.MoveNext()
                        , Enumerator9.MoveNext()
                        , Enumerator10.MoveNext()
                        , Enumerator11.MoveNext()))
                    yield return Action
                        .Invoke(MoveNext1 ? Enumerator1.Current : default
                        , MoveNext2 ? Enumerator2.Current : default
                        , MoveNext3 ? Enumerator3.Current : default
                        , MoveNext4 ? Enumerator4.Current : default
                        , MoveNext5 ? Enumerator5.Current : default
                        , MoveNext6 ? Enumerator6.Current : default
                        , MoveNext7 ? Enumerator7.Current : default
                        , MoveNext8 ? Enumerator8.Current : default
                        , MoveNext9 ? Enumerator9.Current : default
                        , MoveNext10 ? Enumerator10.Current : default
                        , MoveNext11 ? Enumerator11.Current : default);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    internal class ZipEnumerable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> : IEnumerable<TResult> {
        readonly IEnumerable<T1> Item1;
        readonly IEnumerable<T2> Item2;
        readonly IEnumerable<T3> Item3;
        readonly IEnumerable<T4> Item4;
        readonly IEnumerable<T5> Item5;
        readonly IEnumerable<T6> Item6;
        readonly IEnumerable<T7> Item7;
        readonly IEnumerable<T8> Item8;
        readonly IEnumerable<T9> Item9;
        readonly IEnumerable<T10> Item10;
        readonly IEnumerable<T11> Item11;
        readonly IEnumerable<T12> Item12;
        readonly ZipNotEnough NotEnough;
        readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Action;
        public ZipEnumerable(IEnumerable<T1> Item1
            , IEnumerable<T2> Item2
            , IEnumerable<T3> Item3
            , IEnumerable<T4> Item4
            , IEnumerable<T5> Item5
            , IEnumerable<T6> Item6
            , IEnumerable<T7> Item7
            , IEnumerable<T8> Item8
            , IEnumerable<T9> Item9
            , IEnumerable<T10> Item10
            , IEnumerable<T11> Item11
            , IEnumerable<T12> Item12
            , Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Action, ZipNotEnough NotEnough = default)
            => (this.Item1
            , this.Item2
            , this.Item3
            , this.Item4
            , this.Item5
            , this.Item6
            , this.Item7
            , this.Item8
            , this.Item9
            , this.Item10
            , this.Item11
            , this.Item12
            , this.Action
            , this.NotEnough) = (
                Item1 ?? throw new ArgumentNullException(nameof(Item1))
                , Item2 ?? throw new ArgumentNullException(nameof(Item2))
                , Item3 ?? throw new ArgumentNullException(nameof(Item3))
                , Item4 ?? throw new ArgumentNullException(nameof(Item4))
                , Item5 ?? throw new ArgumentNullException(nameof(Item5))
                , Item6 ?? throw new ArgumentNullException(nameof(Item6))
                , Item7 ?? throw new ArgumentNullException(nameof(Item7))
                , Item8 ?? throw new ArgumentNullException(nameof(Item8))
                , Item9 ?? throw new ArgumentNullException(nameof(Item9))
                , Item10 ?? throw new ArgumentNullException(nameof(Item10))
                , Item11 ?? throw new ArgumentNullException(nameof(Item11))
                , Item12 ?? throw new ArgumentNullException(nameof(Item12))
                , Action ?? throw new ArgumentNullException(nameof(Action))
                , NotEnough);
        public IEnumerator<TResult> GetEnumerator()
        {
            switch (NotEnough) {
            case ZipNotEnough.Break:
                return GetEnumeratorOrBreak();
            case ZipNotEnough.Default:
                return GetEnumeratorOrDefault();
            }
            throw new NotSupportedException($"{nameof(NotEnough)}({NotEnough}) is NotSupport.");
        }
        private IEnumerator<TResult> GetEnumeratorOrBreak()
        {
            using (var Enumerator1 = Item1?.GetEnumerator())
            using (var Enumerator2 = Item2?.GetEnumerator())
            using (var Enumerator3 = Item3?.GetEnumerator())
            using (var Enumerator4 = Item4?.GetEnumerator())
            using (var Enumerator5 = Item5?.GetEnumerator())
            using (var Enumerator6 = Item6?.GetEnumerator())
            using (var Enumerator7 = Item7?.GetEnumerator())
            using (var Enumerator8 = Item8?.GetEnumerator())
            using (var Enumerator9 = Item9?.GetEnumerator())
            using (var Enumerator10 = Item10?.GetEnumerator())
            using (var Enumerator11 = Item11?.GetEnumerator())
            using (var Enumerator12 = Item12?.GetEnumerator())
                while (Enumerator1.MoveNext()
                    && Enumerator2.MoveNext()
                    && Enumerator3.MoveNext()
                    && Enumerator4.MoveNext()
                    && Enumerator5.MoveNext()
                    && Enumerator6.MoveNext()
                    && Enumerator7.MoveNext()
                    && Enumerator8.MoveNext()
                    && Enumerator9.MoveNext()
                    && Enumerator10.MoveNext()
                    && Enumerator11.MoveNext()
                    && Enumerator12.MoveNext())
                    yield return Action
                        .Invoke(Enumerator1.Current
                        , Enumerator2.Current
                        , Enumerator3.Current
                        , Enumerator4.Current
                        , Enumerator5.Current
                        , Enumerator6.Current
                        , Enumerator7.Current
                        , Enumerator8.Current
                        , Enumerator9.Current
                        , Enumerator10.Current
                        , Enumerator11.Current
                        , Enumerator12.Current);
        }
        private IEnumerator<TResult> GetEnumeratorOrDefault()
        {
            using (var Enumerator1 = Item1?.GetEnumerator())
            using (var Enumerator2 = Item2?.GetEnumerator())
            using (var Enumerator3 = Item3?.GetEnumerator())
            using (var Enumerator4 = Item4?.GetEnumerator())
            using (var Enumerator5 = Item5?.GetEnumerator())
            using (var Enumerator6 = Item6?.GetEnumerator())
            using (var Enumerator7 = Item7?.GetEnumerator())
            using (var Enumerator8 = Item8?.GetEnumerator())
            using (var Enumerator9 = Item9?.GetEnumerator())
            using (var Enumerator10 = Item10?.GetEnumerator())
            using (var Enumerator11 = Item11?.GetEnumerator())
            using (var Enumerator12 = Item12?.GetEnumerator())
                for (var (MoveNext1
                    , MoveNext2
                    , MoveNext3
                    , MoveNext4
                    , MoveNext5
                    , MoveNext6
                    , MoveNext7
                    , MoveNext8
                    , MoveNext9
                    , MoveNext10
                    , MoveNext11
                    , MoveNext12) = (
                        Enumerator1.MoveNext()
                        , Enumerator2.MoveNext()
                        , Enumerator3.MoveNext()
                        , Enumerator4.MoveNext()
                        , Enumerator5.MoveNext()
                        , Enumerator6.MoveNext()
                        , Enumerator7.MoveNext()
                        , Enumerator8.MoveNext()
                        , Enumerator9.MoveNext()
                        , Enumerator10.MoveNext()
                        , Enumerator11.MoveNext()
                        , Enumerator12.MoveNext());
                    MoveNext1
                    || MoveNext2
                    || MoveNext3
                    || MoveNext4
                    || MoveNext5
                    || MoveNext6
                    || MoveNext7
                    || MoveNext8
                    || MoveNext9
                    || MoveNext10
                    || MoveNext11
                    || MoveNext12;
                    (MoveNext1
                    , MoveNext2
                    , MoveNext3
                    , MoveNext4
                    , MoveNext5
                    , MoveNext6
                    , MoveNext7
                    , MoveNext8
                    , MoveNext9
                    , MoveNext10
                    , MoveNext11
                    , MoveNext12) = (
                        Enumerator1.MoveNext()
                        , Enumerator2.MoveNext()
                        , Enumerator3.MoveNext()
                        , Enumerator4.MoveNext()
                        , Enumerator5.MoveNext()
                        , Enumerator6.MoveNext()
                        , Enumerator7.MoveNext()
                        , Enumerator8.MoveNext()
                        , Enumerator9.MoveNext()
                        , Enumerator10.MoveNext()
                        , Enumerator11.MoveNext()
                        , Enumerator12.MoveNext()))
                    yield return Action
                        .Invoke(MoveNext1 ? Enumerator1.Current : default
                        , MoveNext2 ? Enumerator2.Current : default
                        , MoveNext3 ? Enumerator3.Current : default
                        , MoveNext4 ? Enumerator4.Current : default
                        , MoveNext5 ? Enumerator5.Current : default
                        , MoveNext6 ? Enumerator6.Current : default
                        , MoveNext7 ? Enumerator7.Current : default
                        , MoveNext8 ? Enumerator8.Current : default
                        , MoveNext9 ? Enumerator9.Current : default
                        , MoveNext10 ? Enumerator10.Current : default
                        , MoveNext11 ? Enumerator11.Current : default
                        , MoveNext12 ? Enumerator12.Current : default);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    internal class ZipEnumerable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> : IEnumerable<TResult> {
        readonly IEnumerable<T1> Item1;
        readonly IEnumerable<T2> Item2;
        readonly IEnumerable<T3> Item3;
        readonly IEnumerable<T4> Item4;
        readonly IEnumerable<T5> Item5;
        readonly IEnumerable<T6> Item6;
        readonly IEnumerable<T7> Item7;
        readonly IEnumerable<T8> Item8;
        readonly IEnumerable<T9> Item9;
        readonly IEnumerable<T10> Item10;
        readonly IEnumerable<T11> Item11;
        readonly IEnumerable<T12> Item12;
        readonly IEnumerable<T13> Item13;
        readonly ZipNotEnough NotEnough;
        readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Action;
        public ZipEnumerable(IEnumerable<T1> Item1
            , IEnumerable<T2> Item2
            , IEnumerable<T3> Item3
            , IEnumerable<T4> Item4
            , IEnumerable<T5> Item5
            , IEnumerable<T6> Item6
            , IEnumerable<T7> Item7
            , IEnumerable<T8> Item8
            , IEnumerable<T9> Item9
            , IEnumerable<T10> Item10
            , IEnumerable<T11> Item11
            , IEnumerable<T12> Item12
            , IEnumerable<T13> Item13
            , Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Action, ZipNotEnough NotEnough = default)
            => (this.Item1
            , this.Item2
            , this.Item3
            , this.Item4
            , this.Item5
            , this.Item6
            , this.Item7
            , this.Item8
            , this.Item9
            , this.Item10
            , this.Item11
            , this.Item12
            , this.Item13
            , this.Action
            , this.NotEnough) = (
                Item1 ?? throw new ArgumentNullException(nameof(Item1))
                , Item2 ?? throw new ArgumentNullException(nameof(Item2))
                , Item3 ?? throw new ArgumentNullException(nameof(Item3))
                , Item4 ?? throw new ArgumentNullException(nameof(Item4))
                , Item5 ?? throw new ArgumentNullException(nameof(Item5))
                , Item6 ?? throw new ArgumentNullException(nameof(Item6))
                , Item7 ?? throw new ArgumentNullException(nameof(Item7))
                , Item8 ?? throw new ArgumentNullException(nameof(Item8))
                , Item9 ?? throw new ArgumentNullException(nameof(Item9))
                , Item10 ?? throw new ArgumentNullException(nameof(Item10))
                , Item11 ?? throw new ArgumentNullException(nameof(Item11))
                , Item12 ?? throw new ArgumentNullException(nameof(Item12))
                , Item13 ?? throw new ArgumentNullException(nameof(Item13))
                , Action ?? throw new ArgumentNullException(nameof(Action))
                , NotEnough);
        public IEnumerator<TResult> GetEnumerator()
        {
            switch (NotEnough) {
            case ZipNotEnough.Break:
                return GetEnumeratorOrBreak();
            case ZipNotEnough.Default:
                return GetEnumeratorOrDefault();
            }
            throw new NotSupportedException($"{nameof(NotEnough)}({NotEnough}) is NotSupport.");
        }
        private IEnumerator<TResult> GetEnumeratorOrBreak()
        {
            using (var Enumerator1 = Item1?.GetEnumerator())
            using (var Enumerator2 = Item2?.GetEnumerator())
            using (var Enumerator3 = Item3?.GetEnumerator())
            using (var Enumerator4 = Item4?.GetEnumerator())
            using (var Enumerator5 = Item5?.GetEnumerator())
            using (var Enumerator6 = Item6?.GetEnumerator())
            using (var Enumerator7 = Item7?.GetEnumerator())
            using (var Enumerator8 = Item8?.GetEnumerator())
            using (var Enumerator9 = Item9?.GetEnumerator())
            using (var Enumerator10 = Item10?.GetEnumerator())
            using (var Enumerator11 = Item11?.GetEnumerator())
            using (var Enumerator12 = Item12?.GetEnumerator())
            using (var Enumerator13 = Item13?.GetEnumerator())
                while (Enumerator1.MoveNext()
                    && Enumerator2.MoveNext()
                    && Enumerator3.MoveNext()
                    && Enumerator4.MoveNext()
                    && Enumerator5.MoveNext()
                    && Enumerator6.MoveNext()
                    && Enumerator7.MoveNext()
                    && Enumerator8.MoveNext()
                    && Enumerator9.MoveNext()
                    && Enumerator10.MoveNext()
                    && Enumerator11.MoveNext()
                    && Enumerator12.MoveNext()
                    && Enumerator13.MoveNext())
                    yield return Action
                        .Invoke(Enumerator1.Current
                        , Enumerator2.Current
                        , Enumerator3.Current
                        , Enumerator4.Current
                        , Enumerator5.Current
                        , Enumerator6.Current
                        , Enumerator7.Current
                        , Enumerator8.Current
                        , Enumerator9.Current
                        , Enumerator10.Current
                        , Enumerator11.Current
                        , Enumerator12.Current
                        , Enumerator13.Current);
        }
        private IEnumerator<TResult> GetEnumeratorOrDefault()
        {
            using (var Enumerator1 = Item1?.GetEnumerator())
            using (var Enumerator2 = Item2?.GetEnumerator())
            using (var Enumerator3 = Item3?.GetEnumerator())
            using (var Enumerator4 = Item4?.GetEnumerator())
            using (var Enumerator5 = Item5?.GetEnumerator())
            using (var Enumerator6 = Item6?.GetEnumerator())
            using (var Enumerator7 = Item7?.GetEnumerator())
            using (var Enumerator8 = Item8?.GetEnumerator())
            using (var Enumerator9 = Item9?.GetEnumerator())
            using (var Enumerator10 = Item10?.GetEnumerator())
            using (var Enumerator11 = Item11?.GetEnumerator())
            using (var Enumerator12 = Item12?.GetEnumerator())
            using (var Enumerator13 = Item13?.GetEnumerator())
                for (var (MoveNext1
                    , MoveNext2
                    , MoveNext3
                    , MoveNext4
                    , MoveNext5
                    , MoveNext6
                    , MoveNext7
                    , MoveNext8
                    , MoveNext9
                    , MoveNext10
                    , MoveNext11
                    , MoveNext12
                    , MoveNext13) = (
                        Enumerator1.MoveNext()
                        , Enumerator2.MoveNext()
                        , Enumerator3.MoveNext()
                        , Enumerator4.MoveNext()
                        , Enumerator5.MoveNext()
                        , Enumerator6.MoveNext()
                        , Enumerator7.MoveNext()
                        , Enumerator8.MoveNext()
                        , Enumerator9.MoveNext()
                        , Enumerator10.MoveNext()
                        , Enumerator11.MoveNext()
                        , Enumerator12.MoveNext()
                        , Enumerator13.MoveNext());
                    MoveNext1
                    || MoveNext2
                    || MoveNext3
                    || MoveNext4
                    || MoveNext5
                    || MoveNext6
                    || MoveNext7
                    || MoveNext8
                    || MoveNext9
                    || MoveNext10
                    || MoveNext11
                    || MoveNext12
                    || MoveNext13;
                    (MoveNext1
                    , MoveNext2
                    , MoveNext3
                    , MoveNext4
                    , MoveNext5
                    , MoveNext6
                    , MoveNext7
                    , MoveNext8
                    , MoveNext9
                    , MoveNext10
                    , MoveNext11
                    , MoveNext12
                    , MoveNext13) = (
                        Enumerator1.MoveNext()
                        , Enumerator2.MoveNext()
                        , Enumerator3.MoveNext()
                        , Enumerator4.MoveNext()
                        , Enumerator5.MoveNext()
                        , Enumerator6.MoveNext()
                        , Enumerator7.MoveNext()
                        , Enumerator8.MoveNext()
                        , Enumerator9.MoveNext()
                        , Enumerator10.MoveNext()
                        , Enumerator11.MoveNext()
                        , Enumerator12.MoveNext()
                        , Enumerator13.MoveNext()))
                    yield return Action
                        .Invoke(MoveNext1 ? Enumerator1.Current : default
                        , MoveNext2 ? Enumerator2.Current : default
                        , MoveNext3 ? Enumerator3.Current : default
                        , MoveNext4 ? Enumerator4.Current : default
                        , MoveNext5 ? Enumerator5.Current : default
                        , MoveNext6 ? Enumerator6.Current : default
                        , MoveNext7 ? Enumerator7.Current : default
                        , MoveNext8 ? Enumerator8.Current : default
                        , MoveNext9 ? Enumerator9.Current : default
                        , MoveNext10 ? Enumerator10.Current : default
                        , MoveNext11 ? Enumerator11.Current : default
                        , MoveNext12 ? Enumerator12.Current : default
                        , MoveNext13 ? Enumerator13.Current : default);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    internal class ZipEnumerable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> : IEnumerable<TResult> {
        readonly IEnumerable<T1> Item1;
        readonly IEnumerable<T2> Item2;
        readonly IEnumerable<T3> Item3;
        readonly IEnumerable<T4> Item4;
        readonly IEnumerable<T5> Item5;
        readonly IEnumerable<T6> Item6;
        readonly IEnumerable<T7> Item7;
        readonly IEnumerable<T8> Item8;
        readonly IEnumerable<T9> Item9;
        readonly IEnumerable<T10> Item10;
        readonly IEnumerable<T11> Item11;
        readonly IEnumerable<T12> Item12;
        readonly IEnumerable<T13> Item13;
        readonly IEnumerable<T14> Item14;
        readonly ZipNotEnough NotEnough;
        readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Action;
        public ZipEnumerable(IEnumerable<T1> Item1
            , IEnumerable<T2> Item2
            , IEnumerable<T3> Item3
            , IEnumerable<T4> Item4
            , IEnumerable<T5> Item5
            , IEnumerable<T6> Item6
            , IEnumerable<T7> Item7
            , IEnumerable<T8> Item8
            , IEnumerable<T9> Item9
            , IEnumerable<T10> Item10
            , IEnumerable<T11> Item11
            , IEnumerable<T12> Item12
            , IEnumerable<T13> Item13
            , IEnumerable<T14> Item14
            , Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Action, ZipNotEnough NotEnough = default)
            => (this.Item1
            , this.Item2
            , this.Item3
            , this.Item4
            , this.Item5
            , this.Item6
            , this.Item7
            , this.Item8
            , this.Item9
            , this.Item10
            , this.Item11
            , this.Item12
            , this.Item13
            , this.Item14
            , this.Action
            , this.NotEnough) = (
                Item1 ?? throw new ArgumentNullException(nameof(Item1))
                , Item2 ?? throw new ArgumentNullException(nameof(Item2))
                , Item3 ?? throw new ArgumentNullException(nameof(Item3))
                , Item4 ?? throw new ArgumentNullException(nameof(Item4))
                , Item5 ?? throw new ArgumentNullException(nameof(Item5))
                , Item6 ?? throw new ArgumentNullException(nameof(Item6))
                , Item7 ?? throw new ArgumentNullException(nameof(Item7))
                , Item8 ?? throw new ArgumentNullException(nameof(Item8))
                , Item9 ?? throw new ArgumentNullException(nameof(Item9))
                , Item10 ?? throw new ArgumentNullException(nameof(Item10))
                , Item11 ?? throw new ArgumentNullException(nameof(Item11))
                , Item12 ?? throw new ArgumentNullException(nameof(Item12))
                , Item13 ?? throw new ArgumentNullException(nameof(Item13))
                , Item14 ?? throw new ArgumentNullException(nameof(Item14))
                , Action ?? throw new ArgumentNullException(nameof(Action))
                , NotEnough);
        public IEnumerator<TResult> GetEnumerator()
        {
            switch (NotEnough) {
            case ZipNotEnough.Break:
                return GetEnumeratorOrBreak();
            case ZipNotEnough.Default:
                return GetEnumeratorOrDefault();
            }
            throw new NotSupportedException($"{nameof(NotEnough)}({NotEnough}) is NotSupport.");
        }
        private IEnumerator<TResult> GetEnumeratorOrBreak()
        {
            using (var Enumerator1 = Item1?.GetEnumerator())
            using (var Enumerator2 = Item2?.GetEnumerator())
            using (var Enumerator3 = Item3?.GetEnumerator())
            using (var Enumerator4 = Item4?.GetEnumerator())
            using (var Enumerator5 = Item5?.GetEnumerator())
            using (var Enumerator6 = Item6?.GetEnumerator())
            using (var Enumerator7 = Item7?.GetEnumerator())
            using (var Enumerator8 = Item8?.GetEnumerator())
            using (var Enumerator9 = Item9?.GetEnumerator())
            using (var Enumerator10 = Item10?.GetEnumerator())
            using (var Enumerator11 = Item11?.GetEnumerator())
            using (var Enumerator12 = Item12?.GetEnumerator())
            using (var Enumerator13 = Item13?.GetEnumerator())
            using (var Enumerator14 = Item14?.GetEnumerator())
                while (Enumerator1.MoveNext()
                    && Enumerator2.MoveNext()
                    && Enumerator3.MoveNext()
                    && Enumerator4.MoveNext()
                    && Enumerator5.MoveNext()
                    && Enumerator6.MoveNext()
                    && Enumerator7.MoveNext()
                    && Enumerator8.MoveNext()
                    && Enumerator9.MoveNext()
                    && Enumerator10.MoveNext()
                    && Enumerator11.MoveNext()
                    && Enumerator12.MoveNext()
                    && Enumerator13.MoveNext()
                    && Enumerator14.MoveNext())
                    yield return Action
                        .Invoke(Enumerator1.Current
                        , Enumerator2.Current
                        , Enumerator3.Current
                        , Enumerator4.Current
                        , Enumerator5.Current
                        , Enumerator6.Current
                        , Enumerator7.Current
                        , Enumerator8.Current
                        , Enumerator9.Current
                        , Enumerator10.Current
                        , Enumerator11.Current
                        , Enumerator12.Current
                        , Enumerator13.Current
                        , Enumerator14.Current);
        }
        private IEnumerator<TResult> GetEnumeratorOrDefault()
        {
            using (var Enumerator1 = Item1?.GetEnumerator())
            using (var Enumerator2 = Item2?.GetEnumerator())
            using (var Enumerator3 = Item3?.GetEnumerator())
            using (var Enumerator4 = Item4?.GetEnumerator())
            using (var Enumerator5 = Item5?.GetEnumerator())
            using (var Enumerator6 = Item6?.GetEnumerator())
            using (var Enumerator7 = Item7?.GetEnumerator())
            using (var Enumerator8 = Item8?.GetEnumerator())
            using (var Enumerator9 = Item9?.GetEnumerator())
            using (var Enumerator10 = Item10?.GetEnumerator())
            using (var Enumerator11 = Item11?.GetEnumerator())
            using (var Enumerator12 = Item12?.GetEnumerator())
            using (var Enumerator13 = Item13?.GetEnumerator())
            using (var Enumerator14 = Item14?.GetEnumerator())
                for (var (MoveNext1
                    , MoveNext2
                    , MoveNext3
                    , MoveNext4
                    , MoveNext5
                    , MoveNext6
                    , MoveNext7
                    , MoveNext8
                    , MoveNext9
                    , MoveNext10
                    , MoveNext11
                    , MoveNext12
                    , MoveNext13
                    , MoveNext14) = (
                        Enumerator1.MoveNext()
                        , Enumerator2.MoveNext()
                        , Enumerator3.MoveNext()
                        , Enumerator4.MoveNext()
                        , Enumerator5.MoveNext()
                        , Enumerator6.MoveNext()
                        , Enumerator7.MoveNext()
                        , Enumerator8.MoveNext()
                        , Enumerator9.MoveNext()
                        , Enumerator10.MoveNext()
                        , Enumerator11.MoveNext()
                        , Enumerator12.MoveNext()
                        , Enumerator13.MoveNext()
                        , Enumerator14.MoveNext());
                    MoveNext1
                    || MoveNext2
                    || MoveNext3
                    || MoveNext4
                    || MoveNext5
                    || MoveNext6
                    || MoveNext7
                    || MoveNext8
                    || MoveNext9
                    || MoveNext10
                    || MoveNext11
                    || MoveNext12
                    || MoveNext13
                    || MoveNext14;
                    (MoveNext1
                    , MoveNext2
                    , MoveNext3
                    , MoveNext4
                    , MoveNext5
                    , MoveNext6
                    , MoveNext7
                    , MoveNext8
                    , MoveNext9
                    , MoveNext10
                    , MoveNext11
                    , MoveNext12
                    , MoveNext13
                    , MoveNext14) = (
                        Enumerator1.MoveNext()
                        , Enumerator2.MoveNext()
                        , Enumerator3.MoveNext()
                        , Enumerator4.MoveNext()
                        , Enumerator5.MoveNext()
                        , Enumerator6.MoveNext()
                        , Enumerator7.MoveNext()
                        , Enumerator8.MoveNext()
                        , Enumerator9.MoveNext()
                        , Enumerator10.MoveNext()
                        , Enumerator11.MoveNext()
                        , Enumerator12.MoveNext()
                        , Enumerator13.MoveNext()
                        , Enumerator14.MoveNext()))
                    yield return Action
                        .Invoke(MoveNext1 ? Enumerator1.Current : default
                        , MoveNext2 ? Enumerator2.Current : default
                        , MoveNext3 ? Enumerator3.Current : default
                        , MoveNext4 ? Enumerator4.Current : default
                        , MoveNext5 ? Enumerator5.Current : default
                        , MoveNext6 ? Enumerator6.Current : default
                        , MoveNext7 ? Enumerator7.Current : default
                        , MoveNext8 ? Enumerator8.Current : default
                        , MoveNext9 ? Enumerator9.Current : default
                        , MoveNext10 ? Enumerator10.Current : default
                        , MoveNext11 ? Enumerator11.Current : default
                        , MoveNext12 ? Enumerator12.Current : default
                        , MoveNext13 ? Enumerator13.Current : default
                        , MoveNext14 ? Enumerator14.Current : default);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    internal class ZipEnumerable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> : IEnumerable<TResult> {
        readonly IEnumerable<T1> Item1;
        readonly IEnumerable<T2> Item2;
        readonly IEnumerable<T3> Item3;
        readonly IEnumerable<T4> Item4;
        readonly IEnumerable<T5> Item5;
        readonly IEnumerable<T6> Item6;
        readonly IEnumerable<T7> Item7;
        readonly IEnumerable<T8> Item8;
        readonly IEnumerable<T9> Item9;
        readonly IEnumerable<T10> Item10;
        readonly IEnumerable<T11> Item11;
        readonly IEnumerable<T12> Item12;
        readonly IEnumerable<T13> Item13;
        readonly IEnumerable<T14> Item14;
        readonly IEnumerable<T15> Item15;
        readonly ZipNotEnough NotEnough;
        readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Action;
        public ZipEnumerable(IEnumerable<T1> Item1
            , IEnumerable<T2> Item2
            , IEnumerable<T3> Item3
            , IEnumerable<T4> Item4
            , IEnumerable<T5> Item5
            , IEnumerable<T6> Item6
            , IEnumerable<T7> Item7
            , IEnumerable<T8> Item8
            , IEnumerable<T9> Item9
            , IEnumerable<T10> Item10
            , IEnumerable<T11> Item11
            , IEnumerable<T12> Item12
            , IEnumerable<T13> Item13
            , IEnumerable<T14> Item14
            , IEnumerable<T15> Item15
            , Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Action, ZipNotEnough NotEnough = default)
            => (this.Item1
            , this.Item2
            , this.Item3
            , this.Item4
            , this.Item5
            , this.Item6
            , this.Item7
            , this.Item8
            , this.Item9
            , this.Item10
            , this.Item11
            , this.Item12
            , this.Item13
            , this.Item14
            , this.Item15
            , this.Action
            , this.NotEnough) = (
                Item1 ?? throw new ArgumentNullException(nameof(Item1))
                , Item2 ?? throw new ArgumentNullException(nameof(Item2))
                , Item3 ?? throw new ArgumentNullException(nameof(Item3))
                , Item4 ?? throw new ArgumentNullException(nameof(Item4))
                , Item5 ?? throw new ArgumentNullException(nameof(Item5))
                , Item6 ?? throw new ArgumentNullException(nameof(Item6))
                , Item7 ?? throw new ArgumentNullException(nameof(Item7))
                , Item8 ?? throw new ArgumentNullException(nameof(Item8))
                , Item9 ?? throw new ArgumentNullException(nameof(Item9))
                , Item10 ?? throw new ArgumentNullException(nameof(Item10))
                , Item11 ?? throw new ArgumentNullException(nameof(Item11))
                , Item12 ?? throw new ArgumentNullException(nameof(Item12))
                , Item13 ?? throw new ArgumentNullException(nameof(Item13))
                , Item14 ?? throw new ArgumentNullException(nameof(Item14))
                , Item15 ?? throw new ArgumentNullException(nameof(Item15))
                , Action ?? throw new ArgumentNullException(nameof(Action))
                , NotEnough);
        public IEnumerator<TResult> GetEnumerator()
        {
            switch (NotEnough) {
            case ZipNotEnough.Break:
                return GetEnumeratorOrBreak();
            case ZipNotEnough.Default:
                return GetEnumeratorOrDefault();
            }
            throw new NotSupportedException($"{nameof(NotEnough)}({NotEnough}) is NotSupport.");
        }
        private IEnumerator<TResult> GetEnumeratorOrBreak()
        {
            using (var Enumerator1 = Item1?.GetEnumerator())
            using (var Enumerator2 = Item2?.GetEnumerator())
            using (var Enumerator3 = Item3?.GetEnumerator())
            using (var Enumerator4 = Item4?.GetEnumerator())
            using (var Enumerator5 = Item5?.GetEnumerator())
            using (var Enumerator6 = Item6?.GetEnumerator())
            using (var Enumerator7 = Item7?.GetEnumerator())
            using (var Enumerator8 = Item8?.GetEnumerator())
            using (var Enumerator9 = Item9?.GetEnumerator())
            using (var Enumerator10 = Item10?.GetEnumerator())
            using (var Enumerator11 = Item11?.GetEnumerator())
            using (var Enumerator12 = Item12?.GetEnumerator())
            using (var Enumerator13 = Item13?.GetEnumerator())
            using (var Enumerator14 = Item14?.GetEnumerator())
            using (var Enumerator15 = Item15?.GetEnumerator())
                while (Enumerator1.MoveNext()
                    && Enumerator2.MoveNext()
                    && Enumerator3.MoveNext()
                    && Enumerator4.MoveNext()
                    && Enumerator5.MoveNext()
                    && Enumerator6.MoveNext()
                    && Enumerator7.MoveNext()
                    && Enumerator8.MoveNext()
                    && Enumerator9.MoveNext()
                    && Enumerator10.MoveNext()
                    && Enumerator11.MoveNext()
                    && Enumerator12.MoveNext()
                    && Enumerator13.MoveNext()
                    && Enumerator14.MoveNext()
                    && Enumerator15.MoveNext())
                    yield return Action
                        .Invoke(Enumerator1.Current
                        , Enumerator2.Current
                        , Enumerator3.Current
                        , Enumerator4.Current
                        , Enumerator5.Current
                        , Enumerator6.Current
                        , Enumerator7.Current
                        , Enumerator8.Current
                        , Enumerator9.Current
                        , Enumerator10.Current
                        , Enumerator11.Current
                        , Enumerator12.Current
                        , Enumerator13.Current
                        , Enumerator14.Current
                        , Enumerator15.Current);
        }
        private IEnumerator<TResult> GetEnumeratorOrDefault()
        {
            using (var Enumerator1 = Item1?.GetEnumerator())
            using (var Enumerator2 = Item2?.GetEnumerator())
            using (var Enumerator3 = Item3?.GetEnumerator())
            using (var Enumerator4 = Item4?.GetEnumerator())
            using (var Enumerator5 = Item5?.GetEnumerator())
            using (var Enumerator6 = Item6?.GetEnumerator())
            using (var Enumerator7 = Item7?.GetEnumerator())
            using (var Enumerator8 = Item8?.GetEnumerator())
            using (var Enumerator9 = Item9?.GetEnumerator())
            using (var Enumerator10 = Item10?.GetEnumerator())
            using (var Enumerator11 = Item11?.GetEnumerator())
            using (var Enumerator12 = Item12?.GetEnumerator())
            using (var Enumerator13 = Item13?.GetEnumerator())
            using (var Enumerator14 = Item14?.GetEnumerator())
            using (var Enumerator15 = Item15?.GetEnumerator())
                for (var (MoveNext1
                    , MoveNext2
                    , MoveNext3
                    , MoveNext4
                    , MoveNext5
                    , MoveNext6
                    , MoveNext7
                    , MoveNext8
                    , MoveNext9
                    , MoveNext10
                    , MoveNext11
                    , MoveNext12
                    , MoveNext13
                    , MoveNext14
                    , MoveNext15) = (
                        Enumerator1.MoveNext()
                        , Enumerator2.MoveNext()
                        , Enumerator3.MoveNext()
                        , Enumerator4.MoveNext()
                        , Enumerator5.MoveNext()
                        , Enumerator6.MoveNext()
                        , Enumerator7.MoveNext()
                        , Enumerator8.MoveNext()
                        , Enumerator9.MoveNext()
                        , Enumerator10.MoveNext()
                        , Enumerator11.MoveNext()
                        , Enumerator12.MoveNext()
                        , Enumerator13.MoveNext()
                        , Enumerator14.MoveNext()
                        , Enumerator15.MoveNext());
                    MoveNext1
                    || MoveNext2
                    || MoveNext3
                    || MoveNext4
                    || MoveNext5
                    || MoveNext6
                    || MoveNext7
                    || MoveNext8
                    || MoveNext9
                    || MoveNext10
                    || MoveNext11
                    || MoveNext12
                    || MoveNext13
                    || MoveNext14
                    || MoveNext15;
                    (MoveNext1
                    , MoveNext2
                    , MoveNext3
                    , MoveNext4
                    , MoveNext5
                    , MoveNext6
                    , MoveNext7
                    , MoveNext8
                    , MoveNext9
                    , MoveNext10
                    , MoveNext11
                    , MoveNext12
                    , MoveNext13
                    , MoveNext14
                    , MoveNext15) = (
                        Enumerator1.MoveNext()
                        , Enumerator2.MoveNext()
                        , Enumerator3.MoveNext()
                        , Enumerator4.MoveNext()
                        , Enumerator5.MoveNext()
                        , Enumerator6.MoveNext()
                        , Enumerator7.MoveNext()
                        , Enumerator8.MoveNext()
                        , Enumerator9.MoveNext()
                        , Enumerator10.MoveNext()
                        , Enumerator11.MoveNext()
                        , Enumerator12.MoveNext()
                        , Enumerator13.MoveNext()
                        , Enumerator14.MoveNext()
                        , Enumerator15.MoveNext()))
                    yield return Action
                        .Invoke(MoveNext1 ? Enumerator1.Current : default
                        , MoveNext2 ? Enumerator2.Current : default
                        , MoveNext3 ? Enumerator3.Current : default
                        , MoveNext4 ? Enumerator4.Current : default
                        , MoveNext5 ? Enumerator5.Current : default
                        , MoveNext6 ? Enumerator6.Current : default
                        , MoveNext7 ? Enumerator7.Current : default
                        , MoveNext8 ? Enumerator8.Current : default
                        , MoveNext9 ? Enumerator9.Current : default
                        , MoveNext10 ? Enumerator10.Current : default
                        , MoveNext11 ? Enumerator11.Current : default
                        , MoveNext12 ? Enumerator12.Current : default
                        , MoveNext13 ? Enumerator13.Current : default
                        , MoveNext14 ? Enumerator14.Current : default
                        , MoveNext15 ? Enumerator15.Current : default);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    internal class ZipEnumerable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> : IEnumerable<TResult> {
        readonly IEnumerable<T1> Item1;
        readonly IEnumerable<T2> Item2;
        readonly IEnumerable<T3> Item3;
        readonly IEnumerable<T4> Item4;
        readonly IEnumerable<T5> Item5;
        readonly IEnumerable<T6> Item6;
        readonly IEnumerable<T7> Item7;
        readonly IEnumerable<T8> Item8;
        readonly IEnumerable<T9> Item9;
        readonly IEnumerable<T10> Item10;
        readonly IEnumerable<T11> Item11;
        readonly IEnumerable<T12> Item12;
        readonly IEnumerable<T13> Item13;
        readonly IEnumerable<T14> Item14;
        readonly IEnumerable<T15> Item15;
        readonly IEnumerable<T16> Item16;
        readonly ZipNotEnough NotEnough;
        readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Action;
        public ZipEnumerable(IEnumerable<T1> Item1
            , IEnumerable<T2> Item2
            , IEnumerable<T3> Item3
            , IEnumerable<T4> Item4
            , IEnumerable<T5> Item5
            , IEnumerable<T6> Item6
            , IEnumerable<T7> Item7
            , IEnumerable<T8> Item8
            , IEnumerable<T9> Item9
            , IEnumerable<T10> Item10
            , IEnumerable<T11> Item11
            , IEnumerable<T12> Item12
            , IEnumerable<T13> Item13
            , IEnumerable<T14> Item14
            , IEnumerable<T15> Item15
            , IEnumerable<T16> Item16
            , Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Action, ZipNotEnough NotEnough = default)
            => (this.Item1
            , this.Item2
            , this.Item3
            , this.Item4
            , this.Item5
            , this.Item6
            , this.Item7
            , this.Item8
            , this.Item9
            , this.Item10
            , this.Item11
            , this.Item12
            , this.Item13
            , this.Item14
            , this.Item15
            , this.Item16
            , this.Action
            , this.NotEnough) = (
                Item1 ?? throw new ArgumentNullException(nameof(Item1))
                , Item2 ?? throw new ArgumentNullException(nameof(Item2))
                , Item3 ?? throw new ArgumentNullException(nameof(Item3))
                , Item4 ?? throw new ArgumentNullException(nameof(Item4))
                , Item5 ?? throw new ArgumentNullException(nameof(Item5))
                , Item6 ?? throw new ArgumentNullException(nameof(Item6))
                , Item7 ?? throw new ArgumentNullException(nameof(Item7))
                , Item8 ?? throw new ArgumentNullException(nameof(Item8))
                , Item9 ?? throw new ArgumentNullException(nameof(Item9))
                , Item10 ?? throw new ArgumentNullException(nameof(Item10))
                , Item11 ?? throw new ArgumentNullException(nameof(Item11))
                , Item12 ?? throw new ArgumentNullException(nameof(Item12))
                , Item13 ?? throw new ArgumentNullException(nameof(Item13))
                , Item14 ?? throw new ArgumentNullException(nameof(Item14))
                , Item15 ?? throw new ArgumentNullException(nameof(Item15))
                , Item16 ?? throw new ArgumentNullException(nameof(Item16))
                , Action ?? throw new ArgumentNullException(nameof(Action))
                , NotEnough);
        public IEnumerator<TResult> GetEnumerator()
        {
            switch (NotEnough) {
            case ZipNotEnough.Break:
                return GetEnumeratorOrBreak();
            case ZipNotEnough.Default:
                return GetEnumeratorOrDefault();
            }
            throw new NotSupportedException($"{nameof(NotEnough)}({NotEnough}) is NotSupport.");
        }
        private IEnumerator<TResult> GetEnumeratorOrBreak()
        {
            using (var Enumerator1 = Item1?.GetEnumerator())
            using (var Enumerator2 = Item2?.GetEnumerator())
            using (var Enumerator3 = Item3?.GetEnumerator())
            using (var Enumerator4 = Item4?.GetEnumerator())
            using (var Enumerator5 = Item5?.GetEnumerator())
            using (var Enumerator6 = Item6?.GetEnumerator())
            using (var Enumerator7 = Item7?.GetEnumerator())
            using (var Enumerator8 = Item8?.GetEnumerator())
            using (var Enumerator9 = Item9?.GetEnumerator())
            using (var Enumerator10 = Item10?.GetEnumerator())
            using (var Enumerator11 = Item11?.GetEnumerator())
            using (var Enumerator12 = Item12?.GetEnumerator())
            using (var Enumerator13 = Item13?.GetEnumerator())
            using (var Enumerator14 = Item14?.GetEnumerator())
            using (var Enumerator15 = Item15?.GetEnumerator())
            using (var Enumerator16 = Item16?.GetEnumerator())
                while (Enumerator1.MoveNext()
                    && Enumerator2.MoveNext()
                    && Enumerator3.MoveNext()
                    && Enumerator4.MoveNext()
                    && Enumerator5.MoveNext()
                    && Enumerator6.MoveNext()
                    && Enumerator7.MoveNext()
                    && Enumerator8.MoveNext()
                    && Enumerator9.MoveNext()
                    && Enumerator10.MoveNext()
                    && Enumerator11.MoveNext()
                    && Enumerator12.MoveNext()
                    && Enumerator13.MoveNext()
                    && Enumerator14.MoveNext()
                    && Enumerator15.MoveNext()
                    && Enumerator16.MoveNext())
                    yield return Action
                        .Invoke(Enumerator1.Current
                        , Enumerator2.Current
                        , Enumerator3.Current
                        , Enumerator4.Current
                        , Enumerator5.Current
                        , Enumerator6.Current
                        , Enumerator7.Current
                        , Enumerator8.Current
                        , Enumerator9.Current
                        , Enumerator10.Current
                        , Enumerator11.Current
                        , Enumerator12.Current
                        , Enumerator13.Current
                        , Enumerator14.Current
                        , Enumerator15.Current
                        , Enumerator16.Current);
        }
        private IEnumerator<TResult> GetEnumeratorOrDefault()
        {
            using (var Enumerator1 = Item1?.GetEnumerator())
            using (var Enumerator2 = Item2?.GetEnumerator())
            using (var Enumerator3 = Item3?.GetEnumerator())
            using (var Enumerator4 = Item4?.GetEnumerator())
            using (var Enumerator5 = Item5?.GetEnumerator())
            using (var Enumerator6 = Item6?.GetEnumerator())
            using (var Enumerator7 = Item7?.GetEnumerator())
            using (var Enumerator8 = Item8?.GetEnumerator())
            using (var Enumerator9 = Item9?.GetEnumerator())
            using (var Enumerator10 = Item10?.GetEnumerator())
            using (var Enumerator11 = Item11?.GetEnumerator())
            using (var Enumerator12 = Item12?.GetEnumerator())
            using (var Enumerator13 = Item13?.GetEnumerator())
            using (var Enumerator14 = Item14?.GetEnumerator())
            using (var Enumerator15 = Item15?.GetEnumerator())
            using (var Enumerator16 = Item16?.GetEnumerator())
                for (var (MoveNext1
                    , MoveNext2
                    , MoveNext3
                    , MoveNext4
                    , MoveNext5
                    , MoveNext6
                    , MoveNext7
                    , MoveNext8
                    , MoveNext9
                    , MoveNext10
                    , MoveNext11
                    , MoveNext12
                    , MoveNext13
                    , MoveNext14
                    , MoveNext15
                    , MoveNext16) = (
                        Enumerator1.MoveNext()
                        , Enumerator2.MoveNext()
                        , Enumerator3.MoveNext()
                        , Enumerator4.MoveNext()
                        , Enumerator5.MoveNext()
                        , Enumerator6.MoveNext()
                        , Enumerator7.MoveNext()
                        , Enumerator8.MoveNext()
                        , Enumerator9.MoveNext()
                        , Enumerator10.MoveNext()
                        , Enumerator11.MoveNext()
                        , Enumerator12.MoveNext()
                        , Enumerator13.MoveNext()
                        , Enumerator14.MoveNext()
                        , Enumerator15.MoveNext()
                        , Enumerator16.MoveNext());
                    MoveNext1
                    || MoveNext2
                    || MoveNext3
                    || MoveNext4
                    || MoveNext5
                    || MoveNext6
                    || MoveNext7
                    || MoveNext8
                    || MoveNext9
                    || MoveNext10
                    || MoveNext11
                    || MoveNext12
                    || MoveNext13
                    || MoveNext14
                    || MoveNext15
                    || MoveNext16;
                    (MoveNext1
                    , MoveNext2
                    , MoveNext3
                    , MoveNext4
                    , MoveNext5
                    , MoveNext6
                    , MoveNext7
                    , MoveNext8
                    , MoveNext9
                    , MoveNext10
                    , MoveNext11
                    , MoveNext12
                    , MoveNext13
                    , MoveNext14
                    , MoveNext15
                    , MoveNext16) = (
                        Enumerator1.MoveNext()
                        , Enumerator2.MoveNext()
                        , Enumerator3.MoveNext()
                        , Enumerator4.MoveNext()
                        , Enumerator5.MoveNext()
                        , Enumerator6.MoveNext()
                        , Enumerator7.MoveNext()
                        , Enumerator8.MoveNext()
                        , Enumerator9.MoveNext()
                        , Enumerator10.MoveNext()
                        , Enumerator11.MoveNext()
                        , Enumerator12.MoveNext()
                        , Enumerator13.MoveNext()
                        , Enumerator14.MoveNext()
                        , Enumerator15.MoveNext()
                        , Enumerator16.MoveNext()))
                    yield return Action
                        .Invoke(MoveNext1 ? Enumerator1.Current : default
                        , MoveNext2 ? Enumerator2.Current : default
                        , MoveNext3 ? Enumerator3.Current : default
                        , MoveNext4 ? Enumerator4.Current : default
                        , MoveNext5 ? Enumerator5.Current : default
                        , MoveNext6 ? Enumerator6.Current : default
                        , MoveNext7 ? Enumerator7.Current : default
                        , MoveNext8 ? Enumerator8.Current : default
                        , MoveNext9 ? Enumerator9.Current : default
                        , MoveNext10 ? Enumerator10.Current : default
                        , MoveNext11 ? Enumerator11.Current : default
                        , MoveNext12 ? Enumerator12.Current : default
                        , MoveNext13 ? Enumerator13.Current : default
                        , MoveNext14 ? Enumerator14.Current : default
                        , MoveNext15 ? Enumerator15.Current : default
                        , MoveNext16 ? Enumerator16.Current : default);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    internal class ZipTupleEnumerable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>
        : IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5, T6 Item6, T7 Item7, T8 Item8, T9 Item9, T10 Item10, T11 Item11, T12 Item12, T13 Item13, T14 Item14, T15 Item15, T16 Item16, T17 Item17)> {
        readonly IEnumerable<T1> Item1;
        readonly IEnumerable<T2> Item2;
        readonly IEnumerable<T3> Item3;
        readonly IEnumerable<T4> Item4;
        readonly IEnumerable<T5> Item5;
        readonly IEnumerable<T6> Item6;
        readonly IEnumerable<T7> Item7;
        readonly IEnumerable<T8> Item8;
        readonly IEnumerable<T9> Item9;
        readonly IEnumerable<T10> Item10;
        readonly IEnumerable<T11> Item11;
        readonly IEnumerable<T12> Item12;
        readonly IEnumerable<T13> Item13;
        readonly IEnumerable<T14> Item14;
        readonly IEnumerable<T15> Item15;
        readonly IEnumerable<T16> Item16;
        readonly IEnumerable<T17> Item17;
        readonly ZipNotEnough NotEnough;
        public ZipTupleEnumerable(IEnumerable<T1> Item1
            , IEnumerable<T2> Item2
            , IEnumerable<T3> Item3
            , IEnumerable<T4> Item4
            , IEnumerable<T5> Item5
            , IEnumerable<T6> Item6
            , IEnumerable<T7> Item7
            , IEnumerable<T8> Item8
            , IEnumerable<T9> Item9
            , IEnumerable<T10> Item10
            , IEnumerable<T11> Item11
            , IEnumerable<T12> Item12
            , IEnumerable<T13> Item13
            , IEnumerable<T14> Item14
            , IEnumerable<T15> Item15
            , IEnumerable<T16> Item16
            , IEnumerable<T17> Item17
            , ZipNotEnough NotEnough = default)
            => (this.Item1
            , this.Item2
            , this.Item3
            , this.Item4
            , this.Item5
            , this.Item6
            , this.Item7
            , this.Item8
            , this.Item9
            , this.Item10
            , this.Item11
            , this.Item12
            , this.Item13
            , this.Item14
            , this.Item15
            , this.Item16
            , this.Item17
            , this.NotEnough) = (
                Item1 ?? throw new ArgumentNullException(nameof(Item1))
                , Item2 ?? throw new ArgumentNullException(nameof(Item2))
                , Item3 ?? throw new ArgumentNullException(nameof(Item3))
                , Item4 ?? throw new ArgumentNullException(nameof(Item4))
                , Item5 ?? throw new ArgumentNullException(nameof(Item5))
                , Item6 ?? throw new ArgumentNullException(nameof(Item6))
                , Item7 ?? throw new ArgumentNullException(nameof(Item7))
                , Item8 ?? throw new ArgumentNullException(nameof(Item8))
                , Item9 ?? throw new ArgumentNullException(nameof(Item9))
                , Item10 ?? throw new ArgumentNullException(nameof(Item10))
                , Item11 ?? throw new ArgumentNullException(nameof(Item11))
                , Item12 ?? throw new ArgumentNullException(nameof(Item12))
                , Item13 ?? throw new ArgumentNullException(nameof(Item13))
                , Item14 ?? throw new ArgumentNullException(nameof(Item14))
                , Item15 ?? throw new ArgumentNullException(nameof(Item15))
                , Item16 ?? throw new ArgumentNullException(nameof(Item16))
                , Item17 ?? throw new ArgumentNullException(nameof(Item17))
                , NotEnough);
        public IEnumerator<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17)> GetEnumerator()
        {
            switch (NotEnough) {
            case ZipNotEnough.Break:
                return GetEnumeratorOrBreak();
            case ZipNotEnough.Default:
                return GetEnumeratorOrDefault();
            }
            throw new NotSupportedException($"{nameof(NotEnough)}({NotEnough}) is NotSupport.");
        }
        private IEnumerator<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17)> GetEnumeratorOrBreak()
        {
            using (var Enumerator1 = Item1?.GetEnumerator())
            using (var Enumerator2 = Item2?.GetEnumerator())
            using (var Enumerator3 = Item3?.GetEnumerator())
            using (var Enumerator4 = Item4?.GetEnumerator())
            using (var Enumerator5 = Item5?.GetEnumerator())
            using (var Enumerator6 = Item6?.GetEnumerator())
            using (var Enumerator7 = Item7?.GetEnumerator())
            using (var Enumerator8 = Item8?.GetEnumerator())
            using (var Enumerator9 = Item9?.GetEnumerator())
            using (var Enumerator10 = Item10?.GetEnumerator())
            using (var Enumerator11 = Item11?.GetEnumerator())
            using (var Enumerator12 = Item12?.GetEnumerator())
            using (var Enumerator13 = Item13?.GetEnumerator())
            using (var Enumerator14 = Item14?.GetEnumerator())
            using (var Enumerator15 = Item15?.GetEnumerator())
            using (var Enumerator16 = Item16?.GetEnumerator())
            using (var Enumerator17 = Item17?.GetEnumerator())
                while (Enumerator1.MoveNext()
                    && Enumerator2.MoveNext()
                    && Enumerator3.MoveNext()
                    && Enumerator4.MoveNext()
                    && Enumerator5.MoveNext()
                    && Enumerator6.MoveNext()
                    && Enumerator7.MoveNext()
                    && Enumerator8.MoveNext()
                    && Enumerator9.MoveNext()
                    && Enumerator10.MoveNext()
                    && Enumerator11.MoveNext()
                    && Enumerator12.MoveNext()
                    && Enumerator13.MoveNext()
                    && Enumerator14.MoveNext()
                    && Enumerator15.MoveNext()
                    && Enumerator16.MoveNext()
                    && Enumerator17.MoveNext())
                    yield return
                        (Enumerator1.Current
                        , Enumerator2.Current
                        , Enumerator3.Current
                        , Enumerator4.Current
                        , Enumerator5.Current
                        , Enumerator6.Current
                        , Enumerator7.Current
                        , Enumerator8.Current
                        , Enumerator9.Current
                        , Enumerator10.Current
                        , Enumerator11.Current
                        , Enumerator12.Current
                        , Enumerator13.Current
                        , Enumerator14.Current
                        , Enumerator15.Current
                        , Enumerator16.Current
                        , Enumerator17.Current);
        }
        private IEnumerator<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17)> GetEnumeratorOrDefault()
        {
            using (var Enumerator1 = Item1?.GetEnumerator())
            using (var Enumerator2 = Item2?.GetEnumerator())
            using (var Enumerator3 = Item3?.GetEnumerator())
            using (var Enumerator4 = Item4?.GetEnumerator())
            using (var Enumerator5 = Item5?.GetEnumerator())
            using (var Enumerator6 = Item6?.GetEnumerator())
            using (var Enumerator7 = Item7?.GetEnumerator())
            using (var Enumerator8 = Item8?.GetEnumerator())
            using (var Enumerator9 = Item9?.GetEnumerator())
            using (var Enumerator10 = Item10?.GetEnumerator())
            using (var Enumerator11 = Item11?.GetEnumerator())
            using (var Enumerator12 = Item12?.GetEnumerator())
            using (var Enumerator13 = Item13?.GetEnumerator())
            using (var Enumerator14 = Item14?.GetEnumerator())
            using (var Enumerator15 = Item15?.GetEnumerator())
            using (var Enumerator16 = Item16?.GetEnumerator())
            using (var Enumerator17 = Item17?.GetEnumerator())
                for (var (MoveNext1
                    , MoveNext2
                    , MoveNext3
                    , MoveNext4
                    , MoveNext5
                    , MoveNext6
                    , MoveNext7
                    , MoveNext8
                    , MoveNext9
                    , MoveNext10
                    , MoveNext11
                    , MoveNext12
                    , MoveNext13
                    , MoveNext14
                    , MoveNext15
                    , MoveNext16
                    , MoveNext17) = (
                        Enumerator1.MoveNext()
                        , Enumerator2.MoveNext()
                        , Enumerator3.MoveNext()
                        , Enumerator4.MoveNext()
                        , Enumerator5.MoveNext()
                        , Enumerator6.MoveNext()
                        , Enumerator7.MoveNext()
                        , Enumerator8.MoveNext()
                        , Enumerator9.MoveNext()
                        , Enumerator10.MoveNext()
                        , Enumerator11.MoveNext()
                        , Enumerator12.MoveNext()
                        , Enumerator13.MoveNext()
                        , Enumerator14.MoveNext()
                        , Enumerator15.MoveNext()
                        , Enumerator16.MoveNext()
                        , Enumerator17.MoveNext());
                    MoveNext1
                    || MoveNext2
                    || MoveNext3
                    || MoveNext4
                    || MoveNext5
                    || MoveNext6
                    || MoveNext7
                    || MoveNext8
                    || MoveNext9
                    || MoveNext10
                    || MoveNext11
                    || MoveNext12
                    || MoveNext13
                    || MoveNext14
                    || MoveNext15
                    || MoveNext16
                    || MoveNext17;
                    (MoveNext1
                    , MoveNext2
                    , MoveNext3
                    , MoveNext4
                    , MoveNext5
                    , MoveNext6
                    , MoveNext7
                    , MoveNext8
                    , MoveNext9
                    , MoveNext10
                    , MoveNext11
                    , MoveNext12
                    , MoveNext13
                    , MoveNext14
                    , MoveNext15
                    , MoveNext16
                    , MoveNext17) = (
                        Enumerator1.MoveNext()
                        , Enumerator2.MoveNext()
                        , Enumerator3.MoveNext()
                        , Enumerator4.MoveNext()
                        , Enumerator5.MoveNext()
                        , Enumerator6.MoveNext()
                        , Enumerator7.MoveNext()
                        , Enumerator8.MoveNext()
                        , Enumerator9.MoveNext()
                        , Enumerator10.MoveNext()
                        , Enumerator11.MoveNext()
                        , Enumerator12.MoveNext()
                        , Enumerator13.MoveNext()
                        , Enumerator14.MoveNext()
                        , Enumerator15.MoveNext()
                        , Enumerator16.MoveNext()
                        , Enumerator17.MoveNext()))
                    yield return (MoveNext1 ? Enumerator1.Current : default
                        , MoveNext2 ? Enumerator2.Current : default
                        , MoveNext3 ? Enumerator3.Current : default
                        , MoveNext4 ? Enumerator4.Current : default
                        , MoveNext5 ? Enumerator5.Current : default
                        , MoveNext6 ? Enumerator6.Current : default
                        , MoveNext7 ? Enumerator7.Current : default
                        , MoveNext8 ? Enumerator8.Current : default
                        , MoveNext9 ? Enumerator9.Current : default
                        , MoveNext10 ? Enumerator10.Current : default
                        , MoveNext11 ? Enumerator11.Current : default
                        , MoveNext12 ? Enumerator12.Current : default
                        , MoveNext13 ? Enumerator13.Current : default
                        , MoveNext14 ? Enumerator14.Current : default
                        , MoveNext15 ? Enumerator15.Current : default
                        , MoveNext16 ? Enumerator16.Current : default
                        , MoveNext17 ? Enumerator17.Current : default);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    internal class ZipTupleEnumerable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>
        : IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5, T6 Item6, T7 Item7, T8 Item8, T9 Item9, T10 Item10, T11 Item11, T12 Item12, T13 Item13, T14 Item14, T15 Item15, T16 Item16, T17 Item17, T18 Item18)> {
        readonly IEnumerable<T1> Item1;
        readonly IEnumerable<T2> Item2;
        readonly IEnumerable<T3> Item3;
        readonly IEnumerable<T4> Item4;
        readonly IEnumerable<T5> Item5;
        readonly IEnumerable<T6> Item6;
        readonly IEnumerable<T7> Item7;
        readonly IEnumerable<T8> Item8;
        readonly IEnumerable<T9> Item9;
        readonly IEnumerable<T10> Item10;
        readonly IEnumerable<T11> Item11;
        readonly IEnumerable<T12> Item12;
        readonly IEnumerable<T13> Item13;
        readonly IEnumerable<T14> Item14;
        readonly IEnumerable<T15> Item15;
        readonly IEnumerable<T16> Item16;
        readonly IEnumerable<T17> Item17;
        readonly IEnumerable<T18> Item18;
        readonly ZipNotEnough NotEnough;
        public ZipTupleEnumerable(IEnumerable<T1> Item1
            , IEnumerable<T2> Item2
            , IEnumerable<T3> Item3
            , IEnumerable<T4> Item4
            , IEnumerable<T5> Item5
            , IEnumerable<T6> Item6
            , IEnumerable<T7> Item7
            , IEnumerable<T8> Item8
            , IEnumerable<T9> Item9
            , IEnumerable<T10> Item10
            , IEnumerable<T11> Item11
            , IEnumerable<T12> Item12
            , IEnumerable<T13> Item13
            , IEnumerable<T14> Item14
            , IEnumerable<T15> Item15
            , IEnumerable<T16> Item16
            , IEnumerable<T17> Item17
            , IEnumerable<T18> Item18
            , ZipNotEnough NotEnough = default)
            => (this.Item1
            , this.Item2
            , this.Item3
            , this.Item4
            , this.Item5
            , this.Item6
            , this.Item7
            , this.Item8
            , this.Item9
            , this.Item10
            , this.Item11
            , this.Item12
            , this.Item13
            , this.Item14
            , this.Item15
            , this.Item16
            , this.Item17
            , this.Item18
            , this.NotEnough) = (
                Item1 ?? throw new ArgumentNullException(nameof(Item1))
                , Item2 ?? throw new ArgumentNullException(nameof(Item2))
                , Item3 ?? throw new ArgumentNullException(nameof(Item3))
                , Item4 ?? throw new ArgumentNullException(nameof(Item4))
                , Item5 ?? throw new ArgumentNullException(nameof(Item5))
                , Item6 ?? throw new ArgumentNullException(nameof(Item6))
                , Item7 ?? throw new ArgumentNullException(nameof(Item7))
                , Item8 ?? throw new ArgumentNullException(nameof(Item8))
                , Item9 ?? throw new ArgumentNullException(nameof(Item9))
                , Item10 ?? throw new ArgumentNullException(nameof(Item10))
                , Item11 ?? throw new ArgumentNullException(nameof(Item11))
                , Item12 ?? throw new ArgumentNullException(nameof(Item12))
                , Item13 ?? throw new ArgumentNullException(nameof(Item13))
                , Item14 ?? throw new ArgumentNullException(nameof(Item14))
                , Item15 ?? throw new ArgumentNullException(nameof(Item15))
                , Item16 ?? throw new ArgumentNullException(nameof(Item16))
                , Item17 ?? throw new ArgumentNullException(nameof(Item17))
                , Item18 ?? throw new ArgumentNullException(nameof(Item18))
                , NotEnough);
        public IEnumerator<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18)> GetEnumerator()
        {
            switch (NotEnough) {
            case ZipNotEnough.Break:
                return GetEnumeratorOrBreak();
            case ZipNotEnough.Default:
                return GetEnumeratorOrDefault();
            }
            throw new NotSupportedException($"{nameof(NotEnough)}({NotEnough}) is NotSupport.");
        }
        private IEnumerator<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18)> GetEnumeratorOrBreak()
        {
            using (var Enumerator1 = Item1?.GetEnumerator())
            using (var Enumerator2 = Item2?.GetEnumerator())
            using (var Enumerator3 = Item3?.GetEnumerator())
            using (var Enumerator4 = Item4?.GetEnumerator())
            using (var Enumerator5 = Item5?.GetEnumerator())
            using (var Enumerator6 = Item6?.GetEnumerator())
            using (var Enumerator7 = Item7?.GetEnumerator())
            using (var Enumerator8 = Item8?.GetEnumerator())
            using (var Enumerator9 = Item9?.GetEnumerator())
            using (var Enumerator10 = Item10?.GetEnumerator())
            using (var Enumerator11 = Item11?.GetEnumerator())
            using (var Enumerator12 = Item12?.GetEnumerator())
            using (var Enumerator13 = Item13?.GetEnumerator())
            using (var Enumerator14 = Item14?.GetEnumerator())
            using (var Enumerator15 = Item15?.GetEnumerator())
            using (var Enumerator16 = Item16?.GetEnumerator())
            using (var Enumerator17 = Item17?.GetEnumerator())
            using (var Enumerator18 = Item18?.GetEnumerator())
                while (Enumerator1.MoveNext()
                    && Enumerator2.MoveNext()
                    && Enumerator3.MoveNext()
                    && Enumerator4.MoveNext()
                    && Enumerator5.MoveNext()
                    && Enumerator6.MoveNext()
                    && Enumerator7.MoveNext()
                    && Enumerator8.MoveNext()
                    && Enumerator9.MoveNext()
                    && Enumerator10.MoveNext()
                    && Enumerator11.MoveNext()
                    && Enumerator12.MoveNext()
                    && Enumerator13.MoveNext()
                    && Enumerator14.MoveNext()
                    && Enumerator15.MoveNext()
                    && Enumerator16.MoveNext()
                    && Enumerator17.MoveNext()
                    && Enumerator18.MoveNext())
                    yield return
                        (Enumerator1.Current
                        , Enumerator2.Current
                        , Enumerator3.Current
                        , Enumerator4.Current
                        , Enumerator5.Current
                        , Enumerator6.Current
                        , Enumerator7.Current
                        , Enumerator8.Current
                        , Enumerator9.Current
                        , Enumerator10.Current
                        , Enumerator11.Current
                        , Enumerator12.Current
                        , Enumerator13.Current
                        , Enumerator14.Current
                        , Enumerator15.Current
                        , Enumerator16.Current
                        , Enumerator17.Current
                        , Enumerator18.Current);
        }
        private IEnumerator<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18)> GetEnumeratorOrDefault()
        {
            using (var Enumerator1 = Item1?.GetEnumerator())
            using (var Enumerator2 = Item2?.GetEnumerator())
            using (var Enumerator3 = Item3?.GetEnumerator())
            using (var Enumerator4 = Item4?.GetEnumerator())
            using (var Enumerator5 = Item5?.GetEnumerator())
            using (var Enumerator6 = Item6?.GetEnumerator())
            using (var Enumerator7 = Item7?.GetEnumerator())
            using (var Enumerator8 = Item8?.GetEnumerator())
            using (var Enumerator9 = Item9?.GetEnumerator())
            using (var Enumerator10 = Item10?.GetEnumerator())
            using (var Enumerator11 = Item11?.GetEnumerator())
            using (var Enumerator12 = Item12?.GetEnumerator())
            using (var Enumerator13 = Item13?.GetEnumerator())
            using (var Enumerator14 = Item14?.GetEnumerator())
            using (var Enumerator15 = Item15?.GetEnumerator())
            using (var Enumerator16 = Item16?.GetEnumerator())
            using (var Enumerator17 = Item17?.GetEnumerator())
            using (var Enumerator18 = Item18?.GetEnumerator())
                for (var (MoveNext1
                    , MoveNext2
                    , MoveNext3
                    , MoveNext4
                    , MoveNext5
                    , MoveNext6
                    , MoveNext7
                    , MoveNext8
                    , MoveNext9
                    , MoveNext10
                    , MoveNext11
                    , MoveNext12
                    , MoveNext13
                    , MoveNext14
                    , MoveNext15
                    , MoveNext16
                    , MoveNext17
                    , MoveNext18) = (
                        Enumerator1.MoveNext()
                        , Enumerator2.MoveNext()
                        , Enumerator3.MoveNext()
                        , Enumerator4.MoveNext()
                        , Enumerator5.MoveNext()
                        , Enumerator6.MoveNext()
                        , Enumerator7.MoveNext()
                        , Enumerator8.MoveNext()
                        , Enumerator9.MoveNext()
                        , Enumerator10.MoveNext()
                        , Enumerator11.MoveNext()
                        , Enumerator12.MoveNext()
                        , Enumerator13.MoveNext()
                        , Enumerator14.MoveNext()
                        , Enumerator15.MoveNext()
                        , Enumerator16.MoveNext()
                        , Enumerator17.MoveNext()
                        , Enumerator18.MoveNext());
                    MoveNext1
                    || MoveNext2
                    || MoveNext3
                    || MoveNext4
                    || MoveNext5
                    || MoveNext6
                    || MoveNext7
                    || MoveNext8
                    || MoveNext9
                    || MoveNext10
                    || MoveNext11
                    || MoveNext12
                    || MoveNext13
                    || MoveNext14
                    || MoveNext15
                    || MoveNext16
                    || MoveNext17
                    || MoveNext18;
                    (MoveNext1
                    , MoveNext2
                    , MoveNext3
                    , MoveNext4
                    , MoveNext5
                    , MoveNext6
                    , MoveNext7
                    , MoveNext8
                    , MoveNext9
                    , MoveNext10
                    , MoveNext11
                    , MoveNext12
                    , MoveNext13
                    , MoveNext14
                    , MoveNext15
                    , MoveNext16
                    , MoveNext17
                    , MoveNext18) = (
                        Enumerator1.MoveNext()
                        , Enumerator2.MoveNext()
                        , Enumerator3.MoveNext()
                        , Enumerator4.MoveNext()
                        , Enumerator5.MoveNext()
                        , Enumerator6.MoveNext()
                        , Enumerator7.MoveNext()
                        , Enumerator8.MoveNext()
                        , Enumerator9.MoveNext()
                        , Enumerator10.MoveNext()
                        , Enumerator11.MoveNext()
                        , Enumerator12.MoveNext()
                        , Enumerator13.MoveNext()
                        , Enumerator14.MoveNext()
                        , Enumerator15.MoveNext()
                        , Enumerator16.MoveNext()
                        , Enumerator17.MoveNext()
                        , Enumerator18.MoveNext()))
                    yield return (MoveNext1 ? Enumerator1.Current : default
                        , MoveNext2 ? Enumerator2.Current : default
                        , MoveNext3 ? Enumerator3.Current : default
                        , MoveNext4 ? Enumerator4.Current : default
                        , MoveNext5 ? Enumerator5.Current : default
                        , MoveNext6 ? Enumerator6.Current : default
                        , MoveNext7 ? Enumerator7.Current : default
                        , MoveNext8 ? Enumerator8.Current : default
                        , MoveNext9 ? Enumerator9.Current : default
                        , MoveNext10 ? Enumerator10.Current : default
                        , MoveNext11 ? Enumerator11.Current : default
                        , MoveNext12 ? Enumerator12.Current : default
                        , MoveNext13 ? Enumerator13.Current : default
                        , MoveNext14 ? Enumerator14.Current : default
                        , MoveNext15 ? Enumerator15.Current : default
                        , MoveNext16 ? Enumerator16.Current : default
                        , MoveNext17 ? Enumerator17.Current : default
                        , MoveNext18 ? Enumerator18.Current : default);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    internal class ZipTupleEnumerable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>
        : IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5, T6 Item6, T7 Item7, T8 Item8, T9 Item9, T10 Item10, T11 Item11, T12 Item12, T13 Item13, T14 Item14, T15 Item15, T16 Item16, T17 Item17, T18 Item18, T19 Item19)> {
        readonly IEnumerable<T1> Item1;
        readonly IEnumerable<T2> Item2;
        readonly IEnumerable<T3> Item3;
        readonly IEnumerable<T4> Item4;
        readonly IEnumerable<T5> Item5;
        readonly IEnumerable<T6> Item6;
        readonly IEnumerable<T7> Item7;
        readonly IEnumerable<T8> Item8;
        readonly IEnumerable<T9> Item9;
        readonly IEnumerable<T10> Item10;
        readonly IEnumerable<T11> Item11;
        readonly IEnumerable<T12> Item12;
        readonly IEnumerable<T13> Item13;
        readonly IEnumerable<T14> Item14;
        readonly IEnumerable<T15> Item15;
        readonly IEnumerable<T16> Item16;
        readonly IEnumerable<T17> Item17;
        readonly IEnumerable<T18> Item18;
        readonly IEnumerable<T19> Item19;
        readonly ZipNotEnough NotEnough;
        public ZipTupleEnumerable(IEnumerable<T1> Item1
            , IEnumerable<T2> Item2
            , IEnumerable<T3> Item3
            , IEnumerable<T4> Item4
            , IEnumerable<T5> Item5
            , IEnumerable<T6> Item6
            , IEnumerable<T7> Item7
            , IEnumerable<T8> Item8
            , IEnumerable<T9> Item9
            , IEnumerable<T10> Item10
            , IEnumerable<T11> Item11
            , IEnumerable<T12> Item12
            , IEnumerable<T13> Item13
            , IEnumerable<T14> Item14
            , IEnumerable<T15> Item15
            , IEnumerable<T16> Item16
            , IEnumerable<T17> Item17
            , IEnumerable<T18> Item18
            , IEnumerable<T19> Item19
            , ZipNotEnough NotEnough = default)
            => (this.Item1
            , this.Item2
            , this.Item3
            , this.Item4
            , this.Item5
            , this.Item6
            , this.Item7
            , this.Item8
            , this.Item9
            , this.Item10
            , this.Item11
            , this.Item12
            , this.Item13
            , this.Item14
            , this.Item15
            , this.Item16
            , this.Item17
            , this.Item18
            , this.Item19
            , this.NotEnough) = (
                Item1 ?? throw new ArgumentNullException(nameof(Item1))
                , Item2 ?? throw new ArgumentNullException(nameof(Item2))
                , Item3 ?? throw new ArgumentNullException(nameof(Item3))
                , Item4 ?? throw new ArgumentNullException(nameof(Item4))
                , Item5 ?? throw new ArgumentNullException(nameof(Item5))
                , Item6 ?? throw new ArgumentNullException(nameof(Item6))
                , Item7 ?? throw new ArgumentNullException(nameof(Item7))
                , Item8 ?? throw new ArgumentNullException(nameof(Item8))
                , Item9 ?? throw new ArgumentNullException(nameof(Item9))
                , Item10 ?? throw new ArgumentNullException(nameof(Item10))
                , Item11 ?? throw new ArgumentNullException(nameof(Item11))
                , Item12 ?? throw new ArgumentNullException(nameof(Item12))
                , Item13 ?? throw new ArgumentNullException(nameof(Item13))
                , Item14 ?? throw new ArgumentNullException(nameof(Item14))
                , Item15 ?? throw new ArgumentNullException(nameof(Item15))
                , Item16 ?? throw new ArgumentNullException(nameof(Item16))
                , Item17 ?? throw new ArgumentNullException(nameof(Item17))
                , Item18 ?? throw new ArgumentNullException(nameof(Item18))
                , Item19 ?? throw new ArgumentNullException(nameof(Item19))
                , NotEnough);
        public IEnumerator<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19)> GetEnumerator()
        {
            switch (NotEnough) {
            case ZipNotEnough.Break:
                return GetEnumeratorOrBreak();
            case ZipNotEnough.Default:
                return GetEnumeratorOrDefault();
            }
            throw new NotSupportedException($"{nameof(NotEnough)}({NotEnough}) is NotSupport.");
        }
        private IEnumerator<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19)> GetEnumeratorOrBreak()
        {
            using (var Enumerator1 = Item1?.GetEnumerator())
            using (var Enumerator2 = Item2?.GetEnumerator())
            using (var Enumerator3 = Item3?.GetEnumerator())
            using (var Enumerator4 = Item4?.GetEnumerator())
            using (var Enumerator5 = Item5?.GetEnumerator())
            using (var Enumerator6 = Item6?.GetEnumerator())
            using (var Enumerator7 = Item7?.GetEnumerator())
            using (var Enumerator8 = Item8?.GetEnumerator())
            using (var Enumerator9 = Item9?.GetEnumerator())
            using (var Enumerator10 = Item10?.GetEnumerator())
            using (var Enumerator11 = Item11?.GetEnumerator())
            using (var Enumerator12 = Item12?.GetEnumerator())
            using (var Enumerator13 = Item13?.GetEnumerator())
            using (var Enumerator14 = Item14?.GetEnumerator())
            using (var Enumerator15 = Item15?.GetEnumerator())
            using (var Enumerator16 = Item16?.GetEnumerator())
            using (var Enumerator17 = Item17?.GetEnumerator())
            using (var Enumerator18 = Item18?.GetEnumerator())
            using (var Enumerator19 = Item19?.GetEnumerator())
                while (Enumerator1.MoveNext()
                    && Enumerator2.MoveNext()
                    && Enumerator3.MoveNext()
                    && Enumerator4.MoveNext()
                    && Enumerator5.MoveNext()
                    && Enumerator6.MoveNext()
                    && Enumerator7.MoveNext()
                    && Enumerator8.MoveNext()
                    && Enumerator9.MoveNext()
                    && Enumerator10.MoveNext()
                    && Enumerator11.MoveNext()
                    && Enumerator12.MoveNext()
                    && Enumerator13.MoveNext()
                    && Enumerator14.MoveNext()
                    && Enumerator15.MoveNext()
                    && Enumerator16.MoveNext()
                    && Enumerator17.MoveNext()
                    && Enumerator18.MoveNext()
                    && Enumerator19.MoveNext())
                    yield return
                        (Enumerator1.Current
                        , Enumerator2.Current
                        , Enumerator3.Current
                        , Enumerator4.Current
                        , Enumerator5.Current
                        , Enumerator6.Current
                        , Enumerator7.Current
                        , Enumerator8.Current
                        , Enumerator9.Current
                        , Enumerator10.Current
                        , Enumerator11.Current
                        , Enumerator12.Current
                        , Enumerator13.Current
                        , Enumerator14.Current
                        , Enumerator15.Current
                        , Enumerator16.Current
                        , Enumerator17.Current
                        , Enumerator18.Current
                        , Enumerator19.Current);
        }
        private IEnumerator<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19)> GetEnumeratorOrDefault()
        {
            using (var Enumerator1 = Item1?.GetEnumerator())
            using (var Enumerator2 = Item2?.GetEnumerator())
            using (var Enumerator3 = Item3?.GetEnumerator())
            using (var Enumerator4 = Item4?.GetEnumerator())
            using (var Enumerator5 = Item5?.GetEnumerator())
            using (var Enumerator6 = Item6?.GetEnumerator())
            using (var Enumerator7 = Item7?.GetEnumerator())
            using (var Enumerator8 = Item8?.GetEnumerator())
            using (var Enumerator9 = Item9?.GetEnumerator())
            using (var Enumerator10 = Item10?.GetEnumerator())
            using (var Enumerator11 = Item11?.GetEnumerator())
            using (var Enumerator12 = Item12?.GetEnumerator())
            using (var Enumerator13 = Item13?.GetEnumerator())
            using (var Enumerator14 = Item14?.GetEnumerator())
            using (var Enumerator15 = Item15?.GetEnumerator())
            using (var Enumerator16 = Item16?.GetEnumerator())
            using (var Enumerator17 = Item17?.GetEnumerator())
            using (var Enumerator18 = Item18?.GetEnumerator())
            using (var Enumerator19 = Item19?.GetEnumerator())
                for (var (MoveNext1
                    , MoveNext2
                    , MoveNext3
                    , MoveNext4
                    , MoveNext5
                    , MoveNext6
                    , MoveNext7
                    , MoveNext8
                    , MoveNext9
                    , MoveNext10
                    , MoveNext11
                    , MoveNext12
                    , MoveNext13
                    , MoveNext14
                    , MoveNext15
                    , MoveNext16
                    , MoveNext17
                    , MoveNext18
                    , MoveNext19) = (
                        Enumerator1.MoveNext()
                        , Enumerator2.MoveNext()
                        , Enumerator3.MoveNext()
                        , Enumerator4.MoveNext()
                        , Enumerator5.MoveNext()
                        , Enumerator6.MoveNext()
                        , Enumerator7.MoveNext()
                        , Enumerator8.MoveNext()
                        , Enumerator9.MoveNext()
                        , Enumerator10.MoveNext()
                        , Enumerator11.MoveNext()
                        , Enumerator12.MoveNext()
                        , Enumerator13.MoveNext()
                        , Enumerator14.MoveNext()
                        , Enumerator15.MoveNext()
                        , Enumerator16.MoveNext()
                        , Enumerator17.MoveNext()
                        , Enumerator18.MoveNext()
                        , Enumerator19.MoveNext());
                    MoveNext1
                    || MoveNext2
                    || MoveNext3
                    || MoveNext4
                    || MoveNext5
                    || MoveNext6
                    || MoveNext7
                    || MoveNext8
                    || MoveNext9
                    || MoveNext10
                    || MoveNext11
                    || MoveNext12
                    || MoveNext13
                    || MoveNext14
                    || MoveNext15
                    || MoveNext16
                    || MoveNext17
                    || MoveNext18
                    || MoveNext19;
                    (MoveNext1
                    , MoveNext2
                    , MoveNext3
                    , MoveNext4
                    , MoveNext5
                    , MoveNext6
                    , MoveNext7
                    , MoveNext8
                    , MoveNext9
                    , MoveNext10
                    , MoveNext11
                    , MoveNext12
                    , MoveNext13
                    , MoveNext14
                    , MoveNext15
                    , MoveNext16
                    , MoveNext17
                    , MoveNext18
                    , MoveNext19) = (
                        Enumerator1.MoveNext()
                        , Enumerator2.MoveNext()
                        , Enumerator3.MoveNext()
                        , Enumerator4.MoveNext()
                        , Enumerator5.MoveNext()
                        , Enumerator6.MoveNext()
                        , Enumerator7.MoveNext()
                        , Enumerator8.MoveNext()
                        , Enumerator9.MoveNext()
                        , Enumerator10.MoveNext()
                        , Enumerator11.MoveNext()
                        , Enumerator12.MoveNext()
                        , Enumerator13.MoveNext()
                        , Enumerator14.MoveNext()
                        , Enumerator15.MoveNext()
                        , Enumerator16.MoveNext()
                        , Enumerator17.MoveNext()
                        , Enumerator18.MoveNext()
                        , Enumerator19.MoveNext()))
                    yield return (MoveNext1 ? Enumerator1.Current : default
                        , MoveNext2 ? Enumerator2.Current : default
                        , MoveNext3 ? Enumerator3.Current : default
                        , MoveNext4 ? Enumerator4.Current : default
                        , MoveNext5 ? Enumerator5.Current : default
                        , MoveNext6 ? Enumerator6.Current : default
                        , MoveNext7 ? Enumerator7.Current : default
                        , MoveNext8 ? Enumerator8.Current : default
                        , MoveNext9 ? Enumerator9.Current : default
                        , MoveNext10 ? Enumerator10.Current : default
                        , MoveNext11 ? Enumerator11.Current : default
                        , MoveNext12 ? Enumerator12.Current : default
                        , MoveNext13 ? Enumerator13.Current : default
                        , MoveNext14 ? Enumerator14.Current : default
                        , MoveNext15 ? Enumerator15.Current : default
                        , MoveNext16 ? Enumerator16.Current : default
                        , MoveNext17 ? Enumerator17.Current : default
                        , MoveNext18 ? Enumerator18.Current : default
                        , MoveNext19 ? Enumerator19.Current : default);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    internal class ZipTupleEnumerable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>
        : IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5, T6 Item6, T7 Item7, T8 Item8, T9 Item9, T10 Item10, T11 Item11, T12 Item12, T13 Item13, T14 Item14, T15 Item15, T16 Item16, T17 Item17, T18 Item18, T19 Item19, T20 Item20)> {
        readonly IEnumerable<T1> Item1;
        readonly IEnumerable<T2> Item2;
        readonly IEnumerable<T3> Item3;
        readonly IEnumerable<T4> Item4;
        readonly IEnumerable<T5> Item5;
        readonly IEnumerable<T6> Item6;
        readonly IEnumerable<T7> Item7;
        readonly IEnumerable<T8> Item8;
        readonly IEnumerable<T9> Item9;
        readonly IEnumerable<T10> Item10;
        readonly IEnumerable<T11> Item11;
        readonly IEnumerable<T12> Item12;
        readonly IEnumerable<T13> Item13;
        readonly IEnumerable<T14> Item14;
        readonly IEnumerable<T15> Item15;
        readonly IEnumerable<T16> Item16;
        readonly IEnumerable<T17> Item17;
        readonly IEnumerable<T18> Item18;
        readonly IEnumerable<T19> Item19;
        readonly IEnumerable<T20> Item20;
        readonly ZipNotEnough NotEnough;
        public ZipTupleEnumerable(IEnumerable<T1> Item1
            , IEnumerable<T2> Item2
            , IEnumerable<T3> Item3
            , IEnumerable<T4> Item4
            , IEnumerable<T5> Item5
            , IEnumerable<T6> Item6
            , IEnumerable<T7> Item7
            , IEnumerable<T8> Item8
            , IEnumerable<T9> Item9
            , IEnumerable<T10> Item10
            , IEnumerable<T11> Item11
            , IEnumerable<T12> Item12
            , IEnumerable<T13> Item13
            , IEnumerable<T14> Item14
            , IEnumerable<T15> Item15
            , IEnumerable<T16> Item16
            , IEnumerable<T17> Item17
            , IEnumerable<T18> Item18
            , IEnumerable<T19> Item19
            , IEnumerable<T20> Item20
            , ZipNotEnough NotEnough = default)
            => (this.Item1
            , this.Item2
            , this.Item3
            , this.Item4
            , this.Item5
            , this.Item6
            , this.Item7
            , this.Item8
            , this.Item9
            , this.Item10
            , this.Item11
            , this.Item12
            , this.Item13
            , this.Item14
            , this.Item15
            , this.Item16
            , this.Item17
            , this.Item18
            , this.Item19
            , this.Item20
            , this.NotEnough) = (
                Item1 ?? throw new ArgumentNullException(nameof(Item1))
                , Item2 ?? throw new ArgumentNullException(nameof(Item2))
                , Item3 ?? throw new ArgumentNullException(nameof(Item3))
                , Item4 ?? throw new ArgumentNullException(nameof(Item4))
                , Item5 ?? throw new ArgumentNullException(nameof(Item5))
                , Item6 ?? throw new ArgumentNullException(nameof(Item6))
                , Item7 ?? throw new ArgumentNullException(nameof(Item7))
                , Item8 ?? throw new ArgumentNullException(nameof(Item8))
                , Item9 ?? throw new ArgumentNullException(nameof(Item9))
                , Item10 ?? throw new ArgumentNullException(nameof(Item10))
                , Item11 ?? throw new ArgumentNullException(nameof(Item11))
                , Item12 ?? throw new ArgumentNullException(nameof(Item12))
                , Item13 ?? throw new ArgumentNullException(nameof(Item13))
                , Item14 ?? throw new ArgumentNullException(nameof(Item14))
                , Item15 ?? throw new ArgumentNullException(nameof(Item15))
                , Item16 ?? throw new ArgumentNullException(nameof(Item16))
                , Item17 ?? throw new ArgumentNullException(nameof(Item17))
                , Item18 ?? throw new ArgumentNullException(nameof(Item18))
                , Item19 ?? throw new ArgumentNullException(nameof(Item19))
                , Item20 ?? throw new ArgumentNullException(nameof(Item20))
                , NotEnough);
        public IEnumerator<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20)> GetEnumerator()
        {
            switch (NotEnough) {
            case ZipNotEnough.Break:
                return GetEnumeratorOrBreak();
            case ZipNotEnough.Default:
                return GetEnumeratorOrDefault();
            }
            throw new NotSupportedException($"{nameof(NotEnough)}({NotEnough}) is NotSupport.");
        }
        private IEnumerator<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20)> GetEnumeratorOrBreak()
        {
            using (var Enumerator1 = Item1?.GetEnumerator())
            using (var Enumerator2 = Item2?.GetEnumerator())
            using (var Enumerator3 = Item3?.GetEnumerator())
            using (var Enumerator4 = Item4?.GetEnumerator())
            using (var Enumerator5 = Item5?.GetEnumerator())
            using (var Enumerator6 = Item6?.GetEnumerator())
            using (var Enumerator7 = Item7?.GetEnumerator())
            using (var Enumerator8 = Item8?.GetEnumerator())
            using (var Enumerator9 = Item9?.GetEnumerator())
            using (var Enumerator10 = Item10?.GetEnumerator())
            using (var Enumerator11 = Item11?.GetEnumerator())
            using (var Enumerator12 = Item12?.GetEnumerator())
            using (var Enumerator13 = Item13?.GetEnumerator())
            using (var Enumerator14 = Item14?.GetEnumerator())
            using (var Enumerator15 = Item15?.GetEnumerator())
            using (var Enumerator16 = Item16?.GetEnumerator())
            using (var Enumerator17 = Item17?.GetEnumerator())
            using (var Enumerator18 = Item18?.GetEnumerator())
            using (var Enumerator19 = Item19?.GetEnumerator())
            using (var Enumerator20 = Item20?.GetEnumerator())
                while (Enumerator1.MoveNext()
                    && Enumerator2.MoveNext()
                    && Enumerator3.MoveNext()
                    && Enumerator4.MoveNext()
                    && Enumerator5.MoveNext()
                    && Enumerator6.MoveNext()
                    && Enumerator7.MoveNext()
                    && Enumerator8.MoveNext()
                    && Enumerator9.MoveNext()
                    && Enumerator10.MoveNext()
                    && Enumerator11.MoveNext()
                    && Enumerator12.MoveNext()
                    && Enumerator13.MoveNext()
                    && Enumerator14.MoveNext()
                    && Enumerator15.MoveNext()
                    && Enumerator16.MoveNext()
                    && Enumerator17.MoveNext()
                    && Enumerator18.MoveNext()
                    && Enumerator19.MoveNext()
                    && Enumerator20.MoveNext())
                    yield return
                        (Enumerator1.Current
                        , Enumerator2.Current
                        , Enumerator3.Current
                        , Enumerator4.Current
                        , Enumerator5.Current
                        , Enumerator6.Current
                        , Enumerator7.Current
                        , Enumerator8.Current
                        , Enumerator9.Current
                        , Enumerator10.Current
                        , Enumerator11.Current
                        , Enumerator12.Current
                        , Enumerator13.Current
                        , Enumerator14.Current
                        , Enumerator15.Current
                        , Enumerator16.Current
                        , Enumerator17.Current
                        , Enumerator18.Current
                        , Enumerator19.Current
                        , Enumerator20.Current);
        }
        private IEnumerator<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20)> GetEnumeratorOrDefault()
        {
            using (var Enumerator1 = Item1?.GetEnumerator())
            using (var Enumerator2 = Item2?.GetEnumerator())
            using (var Enumerator3 = Item3?.GetEnumerator())
            using (var Enumerator4 = Item4?.GetEnumerator())
            using (var Enumerator5 = Item5?.GetEnumerator())
            using (var Enumerator6 = Item6?.GetEnumerator())
            using (var Enumerator7 = Item7?.GetEnumerator())
            using (var Enumerator8 = Item8?.GetEnumerator())
            using (var Enumerator9 = Item9?.GetEnumerator())
            using (var Enumerator10 = Item10?.GetEnumerator())
            using (var Enumerator11 = Item11?.GetEnumerator())
            using (var Enumerator12 = Item12?.GetEnumerator())
            using (var Enumerator13 = Item13?.GetEnumerator())
            using (var Enumerator14 = Item14?.GetEnumerator())
            using (var Enumerator15 = Item15?.GetEnumerator())
            using (var Enumerator16 = Item16?.GetEnumerator())
            using (var Enumerator17 = Item17?.GetEnumerator())
            using (var Enumerator18 = Item18?.GetEnumerator())
            using (var Enumerator19 = Item19?.GetEnumerator())
            using (var Enumerator20 = Item20?.GetEnumerator())
                for (var (MoveNext1
                    , MoveNext2
                    , MoveNext3
                    , MoveNext4
                    , MoveNext5
                    , MoveNext6
                    , MoveNext7
                    , MoveNext8
                    , MoveNext9
                    , MoveNext10
                    , MoveNext11
                    , MoveNext12
                    , MoveNext13
                    , MoveNext14
                    , MoveNext15
                    , MoveNext16
                    , MoveNext17
                    , MoveNext18
                    , MoveNext19
                    , MoveNext20) = (
                        Enumerator1.MoveNext()
                        , Enumerator2.MoveNext()
                        , Enumerator3.MoveNext()
                        , Enumerator4.MoveNext()
                        , Enumerator5.MoveNext()
                        , Enumerator6.MoveNext()
                        , Enumerator7.MoveNext()
                        , Enumerator8.MoveNext()
                        , Enumerator9.MoveNext()
                        , Enumerator10.MoveNext()
                        , Enumerator11.MoveNext()
                        , Enumerator12.MoveNext()
                        , Enumerator13.MoveNext()
                        , Enumerator14.MoveNext()
                        , Enumerator15.MoveNext()
                        , Enumerator16.MoveNext()
                        , Enumerator17.MoveNext()
                        , Enumerator18.MoveNext()
                        , Enumerator19.MoveNext()
                        , Enumerator20.MoveNext());
                    MoveNext1
                    || MoveNext2
                    || MoveNext3
                    || MoveNext4
                    || MoveNext5
                    || MoveNext6
                    || MoveNext7
                    || MoveNext8
                    || MoveNext9
                    || MoveNext10
                    || MoveNext11
                    || MoveNext12
                    || MoveNext13
                    || MoveNext14
                    || MoveNext15
                    || MoveNext16
                    || MoveNext17
                    || MoveNext18
                    || MoveNext19
                    || MoveNext20;
                    (MoveNext1
                    , MoveNext2
                    , MoveNext3
                    , MoveNext4
                    , MoveNext5
                    , MoveNext6
                    , MoveNext7
                    , MoveNext8
                    , MoveNext9
                    , MoveNext10
                    , MoveNext11
                    , MoveNext12
                    , MoveNext13
                    , MoveNext14
                    , MoveNext15
                    , MoveNext16
                    , MoveNext17
                    , MoveNext18
                    , MoveNext19
                    , MoveNext20) = (
                        Enumerator1.MoveNext()
                        , Enumerator2.MoveNext()
                        , Enumerator3.MoveNext()
                        , Enumerator4.MoveNext()
                        , Enumerator5.MoveNext()
                        , Enumerator6.MoveNext()
                        , Enumerator7.MoveNext()
                        , Enumerator8.MoveNext()
                        , Enumerator9.MoveNext()
                        , Enumerator10.MoveNext()
                        , Enumerator11.MoveNext()
                        , Enumerator12.MoveNext()
                        , Enumerator13.MoveNext()
                        , Enumerator14.MoveNext()
                        , Enumerator15.MoveNext()
                        , Enumerator16.MoveNext()
                        , Enumerator17.MoveNext()
                        , Enumerator18.MoveNext()
                        , Enumerator19.MoveNext()
                        , Enumerator20.MoveNext()))
                    yield return (MoveNext1 ? Enumerator1.Current : default
                        , MoveNext2 ? Enumerator2.Current : default
                        , MoveNext3 ? Enumerator3.Current : default
                        , MoveNext4 ? Enumerator4.Current : default
                        , MoveNext5 ? Enumerator5.Current : default
                        , MoveNext6 ? Enumerator6.Current : default
                        , MoveNext7 ? Enumerator7.Current : default
                        , MoveNext8 ? Enumerator8.Current : default
                        , MoveNext9 ? Enumerator9.Current : default
                        , MoveNext10 ? Enumerator10.Current : default
                        , MoveNext11 ? Enumerator11.Current : default
                        , MoveNext12 ? Enumerator12.Current : default
                        , MoveNext13 ? Enumerator13.Current : default
                        , MoveNext14 ? Enumerator14.Current : default
                        , MoveNext15 ? Enumerator15.Current : default
                        , MoveNext16 ? Enumerator16.Current : default
                        , MoveNext17 ? Enumerator17.Current : default
                        , MoveNext18 ? Enumerator18.Current : default
                        , MoveNext19 ? Enumerator19.Current : default
                        , MoveNext20 ? Enumerator20.Current : default);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    internal class ZipTupleEnumerable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>
        : IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5, T6 Item6, T7 Item7, T8 Item8, T9 Item9, T10 Item10, T11 Item11, T12 Item12, T13 Item13, T14 Item14, T15 Item15, T16 Item16, T17 Item17, T18 Item18, T19 Item19, T20 Item20, T21 Item21)> {
        readonly IEnumerable<T1> Item1;
        readonly IEnumerable<T2> Item2;
        readonly IEnumerable<T3> Item3;
        readonly IEnumerable<T4> Item4;
        readonly IEnumerable<T5> Item5;
        readonly IEnumerable<T6> Item6;
        readonly IEnumerable<T7> Item7;
        readonly IEnumerable<T8> Item8;
        readonly IEnumerable<T9> Item9;
        readonly IEnumerable<T10> Item10;
        readonly IEnumerable<T11> Item11;
        readonly IEnumerable<T12> Item12;
        readonly IEnumerable<T13> Item13;
        readonly IEnumerable<T14> Item14;
        readonly IEnumerable<T15> Item15;
        readonly IEnumerable<T16> Item16;
        readonly IEnumerable<T17> Item17;
        readonly IEnumerable<T18> Item18;
        readonly IEnumerable<T19> Item19;
        readonly IEnumerable<T20> Item20;
        readonly IEnumerable<T21> Item21;
        readonly ZipNotEnough NotEnough;
        public ZipTupleEnumerable(IEnumerable<T1> Item1
            , IEnumerable<T2> Item2
            , IEnumerable<T3> Item3
            , IEnumerable<T4> Item4
            , IEnumerable<T5> Item5
            , IEnumerable<T6> Item6
            , IEnumerable<T7> Item7
            , IEnumerable<T8> Item8
            , IEnumerable<T9> Item9
            , IEnumerable<T10> Item10
            , IEnumerable<T11> Item11
            , IEnumerable<T12> Item12
            , IEnumerable<T13> Item13
            , IEnumerable<T14> Item14
            , IEnumerable<T15> Item15
            , IEnumerable<T16> Item16
            , IEnumerable<T17> Item17
            , IEnumerable<T18> Item18
            , IEnumerable<T19> Item19
            , IEnumerable<T20> Item20
            , IEnumerable<T21> Item21
            , ZipNotEnough NotEnough = default)
            => (this.Item1
            , this.Item2
            , this.Item3
            , this.Item4
            , this.Item5
            , this.Item6
            , this.Item7
            , this.Item8
            , this.Item9
            , this.Item10
            , this.Item11
            , this.Item12
            , this.Item13
            , this.Item14
            , this.Item15
            , this.Item16
            , this.Item17
            , this.Item18
            , this.Item19
            , this.Item20
            , this.Item21
            , this.NotEnough) = (
                Item1 ?? throw new ArgumentNullException(nameof(Item1))
                , Item2 ?? throw new ArgumentNullException(nameof(Item2))
                , Item3 ?? throw new ArgumentNullException(nameof(Item3))
                , Item4 ?? throw new ArgumentNullException(nameof(Item4))
                , Item5 ?? throw new ArgumentNullException(nameof(Item5))
                , Item6 ?? throw new ArgumentNullException(nameof(Item6))
                , Item7 ?? throw new ArgumentNullException(nameof(Item7))
                , Item8 ?? throw new ArgumentNullException(nameof(Item8))
                , Item9 ?? throw new ArgumentNullException(nameof(Item9))
                , Item10 ?? throw new ArgumentNullException(nameof(Item10))
                , Item11 ?? throw new ArgumentNullException(nameof(Item11))
                , Item12 ?? throw new ArgumentNullException(nameof(Item12))
                , Item13 ?? throw new ArgumentNullException(nameof(Item13))
                , Item14 ?? throw new ArgumentNullException(nameof(Item14))
                , Item15 ?? throw new ArgumentNullException(nameof(Item15))
                , Item16 ?? throw new ArgumentNullException(nameof(Item16))
                , Item17 ?? throw new ArgumentNullException(nameof(Item17))
                , Item18 ?? throw new ArgumentNullException(nameof(Item18))
                , Item19 ?? throw new ArgumentNullException(nameof(Item19))
                , Item20 ?? throw new ArgumentNullException(nameof(Item20))
                , Item21 ?? throw new ArgumentNullException(nameof(Item21))
                , NotEnough);
        public IEnumerator<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21)> GetEnumerator()
        {
            switch (NotEnough) {
            case ZipNotEnough.Break:
                return GetEnumeratorOrBreak();
            case ZipNotEnough.Default:
                return GetEnumeratorOrDefault();
            }
            throw new NotSupportedException($"{nameof(NotEnough)}({NotEnough}) is NotSupport.");
        }
        private IEnumerator<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21)> GetEnumeratorOrBreak()
        {
            using (var Enumerator1 = Item1?.GetEnumerator())
            using (var Enumerator2 = Item2?.GetEnumerator())
            using (var Enumerator3 = Item3?.GetEnumerator())
            using (var Enumerator4 = Item4?.GetEnumerator())
            using (var Enumerator5 = Item5?.GetEnumerator())
            using (var Enumerator6 = Item6?.GetEnumerator())
            using (var Enumerator7 = Item7?.GetEnumerator())
            using (var Enumerator8 = Item8?.GetEnumerator())
            using (var Enumerator9 = Item9?.GetEnumerator())
            using (var Enumerator10 = Item10?.GetEnumerator())
            using (var Enumerator11 = Item11?.GetEnumerator())
            using (var Enumerator12 = Item12?.GetEnumerator())
            using (var Enumerator13 = Item13?.GetEnumerator())
            using (var Enumerator14 = Item14?.GetEnumerator())
            using (var Enumerator15 = Item15?.GetEnumerator())
            using (var Enumerator16 = Item16?.GetEnumerator())
            using (var Enumerator17 = Item17?.GetEnumerator())
            using (var Enumerator18 = Item18?.GetEnumerator())
            using (var Enumerator19 = Item19?.GetEnumerator())
            using (var Enumerator20 = Item20?.GetEnumerator())
            using (var Enumerator21 = Item21?.GetEnumerator())
                while (Enumerator1.MoveNext()
                    && Enumerator2.MoveNext()
                    && Enumerator3.MoveNext()
                    && Enumerator4.MoveNext()
                    && Enumerator5.MoveNext()
                    && Enumerator6.MoveNext()
                    && Enumerator7.MoveNext()
                    && Enumerator8.MoveNext()
                    && Enumerator9.MoveNext()
                    && Enumerator10.MoveNext()
                    && Enumerator11.MoveNext()
                    && Enumerator12.MoveNext()
                    && Enumerator13.MoveNext()
                    && Enumerator14.MoveNext()
                    && Enumerator15.MoveNext()
                    && Enumerator16.MoveNext()
                    && Enumerator17.MoveNext()
                    && Enumerator18.MoveNext()
                    && Enumerator19.MoveNext()
                    && Enumerator20.MoveNext()
                    && Enumerator21.MoveNext())
                    yield return
                        (Enumerator1.Current
                        , Enumerator2.Current
                        , Enumerator3.Current
                        , Enumerator4.Current
                        , Enumerator5.Current
                        , Enumerator6.Current
                        , Enumerator7.Current
                        , Enumerator8.Current
                        , Enumerator9.Current
                        , Enumerator10.Current
                        , Enumerator11.Current
                        , Enumerator12.Current
                        , Enumerator13.Current
                        , Enumerator14.Current
                        , Enumerator15.Current
                        , Enumerator16.Current
                        , Enumerator17.Current
                        , Enumerator18.Current
                        , Enumerator19.Current
                        , Enumerator20.Current
                        , Enumerator21.Current);
        }
        private IEnumerator<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21)> GetEnumeratorOrDefault()
        {
            using (var Enumerator1 = Item1?.GetEnumerator())
            using (var Enumerator2 = Item2?.GetEnumerator())
            using (var Enumerator3 = Item3?.GetEnumerator())
            using (var Enumerator4 = Item4?.GetEnumerator())
            using (var Enumerator5 = Item5?.GetEnumerator())
            using (var Enumerator6 = Item6?.GetEnumerator())
            using (var Enumerator7 = Item7?.GetEnumerator())
            using (var Enumerator8 = Item8?.GetEnumerator())
            using (var Enumerator9 = Item9?.GetEnumerator())
            using (var Enumerator10 = Item10?.GetEnumerator())
            using (var Enumerator11 = Item11?.GetEnumerator())
            using (var Enumerator12 = Item12?.GetEnumerator())
            using (var Enumerator13 = Item13?.GetEnumerator())
            using (var Enumerator14 = Item14?.GetEnumerator())
            using (var Enumerator15 = Item15?.GetEnumerator())
            using (var Enumerator16 = Item16?.GetEnumerator())
            using (var Enumerator17 = Item17?.GetEnumerator())
            using (var Enumerator18 = Item18?.GetEnumerator())
            using (var Enumerator19 = Item19?.GetEnumerator())
            using (var Enumerator20 = Item20?.GetEnumerator())
            using (var Enumerator21 = Item21?.GetEnumerator())
                for (var (MoveNext1
                    , MoveNext2
                    , MoveNext3
                    , MoveNext4
                    , MoveNext5
                    , MoveNext6
                    , MoveNext7
                    , MoveNext8
                    , MoveNext9
                    , MoveNext10
                    , MoveNext11
                    , MoveNext12
                    , MoveNext13
                    , MoveNext14
                    , MoveNext15
                    , MoveNext16
                    , MoveNext17
                    , MoveNext18
                    , MoveNext19
                    , MoveNext20
                    , MoveNext21) = (
                        Enumerator1.MoveNext()
                        , Enumerator2.MoveNext()
                        , Enumerator3.MoveNext()
                        , Enumerator4.MoveNext()
                        , Enumerator5.MoveNext()
                        , Enumerator6.MoveNext()
                        , Enumerator7.MoveNext()
                        , Enumerator8.MoveNext()
                        , Enumerator9.MoveNext()
                        , Enumerator10.MoveNext()
                        , Enumerator11.MoveNext()
                        , Enumerator12.MoveNext()
                        , Enumerator13.MoveNext()
                        , Enumerator14.MoveNext()
                        , Enumerator15.MoveNext()
                        , Enumerator16.MoveNext()
                        , Enumerator17.MoveNext()
                        , Enumerator18.MoveNext()
                        , Enumerator19.MoveNext()
                        , Enumerator20.MoveNext()
                        , Enumerator21.MoveNext());
                    MoveNext1
                    || MoveNext2
                    || MoveNext3
                    || MoveNext4
                    || MoveNext5
                    || MoveNext6
                    || MoveNext7
                    || MoveNext8
                    || MoveNext9
                    || MoveNext10
                    || MoveNext11
                    || MoveNext12
                    || MoveNext13
                    || MoveNext14
                    || MoveNext15
                    || MoveNext16
                    || MoveNext17
                    || MoveNext18
                    || MoveNext19
                    || MoveNext20
                    || MoveNext21;
                    (MoveNext1
                    , MoveNext2
                    , MoveNext3
                    , MoveNext4
                    , MoveNext5
                    , MoveNext6
                    , MoveNext7
                    , MoveNext8
                    , MoveNext9
                    , MoveNext10
                    , MoveNext11
                    , MoveNext12
                    , MoveNext13
                    , MoveNext14
                    , MoveNext15
                    , MoveNext16
                    , MoveNext17
                    , MoveNext18
                    , MoveNext19
                    , MoveNext20
                    , MoveNext21) = (
                        Enumerator1.MoveNext()
                        , Enumerator2.MoveNext()
                        , Enumerator3.MoveNext()
                        , Enumerator4.MoveNext()
                        , Enumerator5.MoveNext()
                        , Enumerator6.MoveNext()
                        , Enumerator7.MoveNext()
                        , Enumerator8.MoveNext()
                        , Enumerator9.MoveNext()
                        , Enumerator10.MoveNext()
                        , Enumerator11.MoveNext()
                        , Enumerator12.MoveNext()
                        , Enumerator13.MoveNext()
                        , Enumerator14.MoveNext()
                        , Enumerator15.MoveNext()
                        , Enumerator16.MoveNext()
                        , Enumerator17.MoveNext()
                        , Enumerator18.MoveNext()
                        , Enumerator19.MoveNext()
                        , Enumerator20.MoveNext()
                        , Enumerator21.MoveNext()))
                    yield return (MoveNext1 ? Enumerator1.Current : default
                        , MoveNext2 ? Enumerator2.Current : default
                        , MoveNext3 ? Enumerator3.Current : default
                        , MoveNext4 ? Enumerator4.Current : default
                        , MoveNext5 ? Enumerator5.Current : default
                        , MoveNext6 ? Enumerator6.Current : default
                        , MoveNext7 ? Enumerator7.Current : default
                        , MoveNext8 ? Enumerator8.Current : default
                        , MoveNext9 ? Enumerator9.Current : default
                        , MoveNext10 ? Enumerator10.Current : default
                        , MoveNext11 ? Enumerator11.Current : default
                        , MoveNext12 ? Enumerator12.Current : default
                        , MoveNext13 ? Enumerator13.Current : default
                        , MoveNext14 ? Enumerator14.Current : default
                        , MoveNext15 ? Enumerator15.Current : default
                        , MoveNext16 ? Enumerator16.Current : default
                        , MoveNext17 ? Enumerator17.Current : default
                        , MoveNext18 ? Enumerator18.Current : default
                        , MoveNext19 ? Enumerator19.Current : default
                        , MoveNext20 ? Enumerator20.Current : default
                        , MoveNext21 ? Enumerator21.Current : default);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
