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
}
