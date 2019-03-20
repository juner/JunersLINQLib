using System;
using System.Collections;
using System.Collections.Generic;

namespace Juners.Enumerable {
    internal class ZipTupleEnumerable<T1, T2>
        : IEnumerable<(T1 Item1, T2 Item2)> {
        readonly IEnumerable<T1> Item1;
        readonly IEnumerable<T2> Item2;
        readonly ZipNotEnough NotEnough;
        public ZipTupleEnumerable(IEnumerable<T1> Item1
            , IEnumerable<T2> Item2
            , ZipNotEnough NotEnough = default)
            => (this.Item1, this.Item2, this.NotEnough)
            = (Item1, Item2, NotEnough);

        public IEnumerator<(T1, T2)> GetEnumerator()
        {
            switch (NotEnough) {
            case ZipNotEnough.Break:
                return GetEnumeratorOrBreak();
            case ZipNotEnough.Default:
                return GetEnumeratorOrDefault();
            }
            throw new NotSupportedException($"{nameof(NotEnough)}({NotEnough}) is NotSupport.");
        }
        private IEnumerator<(T1, T2)> GetEnumeratorOrBreak()
        {
            using (var Enumerator1 = Item1?.GetEnumerator())
            using (var Enumerator2 = Item2?.GetEnumerator())
                while (Enumerator1.MoveNext()
                    && Enumerator2.MoveNext())
                    yield return
                        (Enumerator1.Current
                        , Enumerator2.Current);
        }
        private IEnumerator<(T1, T2)> GetEnumeratorOrDefault()
        {
            var DefaultValue1 = default(T1)!;
            var DefaultValue2 = default(T2)!;	
            using (var Enumerator1 = Item1.GetEnumerator())
            using (var Enumerator2 = Item2.GetEnumerator())
                for (var (MoveNext1
                    , MoveNext2) = (
                        Enumerator1.MoveNext()
                        , Enumerator2.MoveNext());
                    MoveNext1
                    || MoveNext2;
                    (MoveNext1
                    , MoveNext2) = (
                        Enumerator1.MoveNext()
                        , Enumerator2.MoveNext()))
                    yield return (MoveNext1 ? Enumerator1.Current : DefaultValue1
                        , MoveNext2 ? Enumerator2.Current : DefaultValue2);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    internal class ZipTupleEnumerable<T1, T2, T3>
        : IEnumerable<(T1 Item1, T2 Item2, T3 Item3)> {
        readonly IEnumerable<T1> Item1;
        readonly IEnumerable<T2> Item2;
        readonly IEnumerable<T3> Item3;
        readonly ZipNotEnough NotEnough;
        public ZipTupleEnumerable(IEnumerable<T1> Item1
            , IEnumerable<T2> Item2
            , IEnumerable<T3> Item3
            , ZipNotEnough NotEnough = default)
            => (this.Item1, this.Item2, this.Item3, this.NotEnough)
            = (Item1, Item2, Item3, NotEnough);

        public IEnumerator<(T1, T2, T3)> GetEnumerator()
        {
            switch (NotEnough) {
            case ZipNotEnough.Break:
                return GetEnumeratorOrBreak();
            case ZipNotEnough.Default:
                return GetEnumeratorOrDefault();
            }
            throw new NotSupportedException($"{nameof(NotEnough)}({NotEnough}) is NotSupport.");
        }
        private IEnumerator<(T1, T2, T3)> GetEnumeratorOrBreak()
        {
            using (var Enumerator1 = Item1?.GetEnumerator())
            using (var Enumerator2 = Item2?.GetEnumerator())
            using (var Enumerator3 = Item3?.GetEnumerator())
                while (Enumerator1.MoveNext()
                    && Enumerator2.MoveNext()
                    && Enumerator3.MoveNext())
                    yield return
                        (Enumerator1.Current
                        , Enumerator2.Current
                        , Enumerator3.Current);
        }
        private IEnumerator<(T1, T2, T3)> GetEnumeratorOrDefault()
        {
            var DefaultValue1 = default(T1)!;
            var DefaultValue2 = default(T2)!;
            var DefaultValue3 = default(T3)!;	
            using (var Enumerator1 = Item1.GetEnumerator())
            using (var Enumerator2 = Item2.GetEnumerator())
            using (var Enumerator3 = Item3.GetEnumerator())
                for (var (MoveNext1
                    , MoveNext2
                    , MoveNext3) = (
                        Enumerator1.MoveNext()
                        , Enumerator2.MoveNext()
                        , Enumerator3.MoveNext());
                    MoveNext1
                    || MoveNext2
                    || MoveNext3;
                    (MoveNext1
                    , MoveNext2
                    , MoveNext3) = (
                        Enumerator1.MoveNext()
                        , Enumerator2.MoveNext()
                        , Enumerator3.MoveNext()))
                    yield return (MoveNext1 ? Enumerator1.Current : DefaultValue1
                        , MoveNext2 ? Enumerator2.Current : DefaultValue2
                        , MoveNext3 ? Enumerator3.Current : DefaultValue3);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    internal class ZipTupleEnumerable<T1, T2, T3, T4>
        : IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4)> {
        readonly IEnumerable<T1> Item1;
        readonly IEnumerable<T2> Item2;
        readonly IEnumerable<T3> Item3;
        readonly IEnumerable<T4> Item4;
        readonly ZipNotEnough NotEnough;
        public ZipTupleEnumerable(IEnumerable<T1> Item1
            , IEnumerable<T2> Item2
            , IEnumerable<T3> Item3
            , IEnumerable<T4> Item4
            , ZipNotEnough NotEnough = default)
            => (this.Item1, this.Item2, this.Item3, this.Item4, this.NotEnough)
            = (Item1, Item2, Item3, Item4, NotEnough);

        public IEnumerator<(T1, T2, T3, T4)> GetEnumerator()
        {
            switch (NotEnough) {
            case ZipNotEnough.Break:
                return GetEnumeratorOrBreak();
            case ZipNotEnough.Default:
                return GetEnumeratorOrDefault();
            }
            throw new NotSupportedException($"{nameof(NotEnough)}({NotEnough}) is NotSupport.");
        }
        private IEnumerator<(T1, T2, T3, T4)> GetEnumeratorOrBreak()
        {
            using (var Enumerator1 = Item1?.GetEnumerator())
            using (var Enumerator2 = Item2?.GetEnumerator())
            using (var Enumerator3 = Item3?.GetEnumerator())
            using (var Enumerator4 = Item4?.GetEnumerator())
                while (Enumerator1.MoveNext()
                    && Enumerator2.MoveNext()
                    && Enumerator3.MoveNext()
                    && Enumerator4.MoveNext())
                    yield return
                        (Enumerator1.Current
                        , Enumerator2.Current
                        , Enumerator3.Current
                        , Enumerator4.Current);
        }
        private IEnumerator<(T1, T2, T3, T4)> GetEnumeratorOrDefault()
        {
            var DefaultValue1 = default(T1)!;
            var DefaultValue2 = default(T2)!;
            var DefaultValue3 = default(T3)!;
            var DefaultValue4 = default(T4)!;	
            using (var Enumerator1 = Item1.GetEnumerator())
            using (var Enumerator2 = Item2.GetEnumerator())
            using (var Enumerator3 = Item3.GetEnumerator())
            using (var Enumerator4 = Item4.GetEnumerator())
                for (var (MoveNext1
                    , MoveNext2
                    , MoveNext3
                    , MoveNext4) = (
                        Enumerator1.MoveNext()
                        , Enumerator2.MoveNext()
                        , Enumerator3.MoveNext()
                        , Enumerator4.MoveNext());
                    MoveNext1
                    || MoveNext2
                    || MoveNext3
                    || MoveNext4;
                    (MoveNext1
                    , MoveNext2
                    , MoveNext3
                    , MoveNext4) = (
                        Enumerator1.MoveNext()
                        , Enumerator2.MoveNext()
                        , Enumerator3.MoveNext()
                        , Enumerator4.MoveNext()))
                    yield return (MoveNext1 ? Enumerator1.Current : DefaultValue1
                        , MoveNext2 ? Enumerator2.Current : DefaultValue2
                        , MoveNext3 ? Enumerator3.Current : DefaultValue3
                        , MoveNext4 ? Enumerator4.Current : DefaultValue4);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    internal class ZipTupleEnumerable<T1, T2, T3, T4, T5>
        : IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5)> {
        readonly IEnumerable<T1> Item1;
        readonly IEnumerable<T2> Item2;
        readonly IEnumerable<T3> Item3;
        readonly IEnumerable<T4> Item4;
        readonly IEnumerable<T5> Item5;
        readonly ZipNotEnough NotEnough;
        public ZipTupleEnumerable(IEnumerable<T1> Item1
            , IEnumerable<T2> Item2
            , IEnumerable<T3> Item3
            , IEnumerable<T4> Item4
            , IEnumerable<T5> Item5
            , ZipNotEnough NotEnough = default)
            => (this.Item1, this.Item2, this.Item3, this.Item4, this.Item5, this.NotEnough)
            = (Item1, Item2, Item3, Item4, Item5, NotEnough);

        public IEnumerator<(T1, T2, T3, T4, T5)> GetEnumerator()
        {
            switch (NotEnough) {
            case ZipNotEnough.Break:
                return GetEnumeratorOrBreak();
            case ZipNotEnough.Default:
                return GetEnumeratorOrDefault();
            }
            throw new NotSupportedException($"{nameof(NotEnough)}({NotEnough}) is NotSupport.");
        }
        private IEnumerator<(T1, T2, T3, T4, T5)> GetEnumeratorOrBreak()
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
                    yield return
                        (Enumerator1.Current
                        , Enumerator2.Current
                        , Enumerator3.Current
                        , Enumerator4.Current
                        , Enumerator5.Current);
        }
        private IEnumerator<(T1, T2, T3, T4, T5)> GetEnumeratorOrDefault()
        {
            var DefaultValue1 = default(T1)!;
            var DefaultValue2 = default(T2)!;
            var DefaultValue3 = default(T3)!;
            var DefaultValue4 = default(T4)!;
            var DefaultValue5 = default(T5)!;	
            using (var Enumerator1 = Item1.GetEnumerator())
            using (var Enumerator2 = Item2.GetEnumerator())
            using (var Enumerator3 = Item3.GetEnumerator())
            using (var Enumerator4 = Item4.GetEnumerator())
            using (var Enumerator5 = Item5.GetEnumerator())
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
                    yield return (MoveNext1 ? Enumerator1.Current : DefaultValue1
                        , MoveNext2 ? Enumerator2.Current : DefaultValue2
                        , MoveNext3 ? Enumerator3.Current : DefaultValue3
                        , MoveNext4 ? Enumerator4.Current : DefaultValue4
                        , MoveNext5 ? Enumerator5.Current : DefaultValue5);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    internal class ZipTupleEnumerable<T1, T2, T3, T4, T5, T6>
        : IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5, T6 Item6)> {
        readonly IEnumerable<T1> Item1;
        readonly IEnumerable<T2> Item2;
        readonly IEnumerable<T3> Item3;
        readonly IEnumerable<T4> Item4;
        readonly IEnumerable<T5> Item5;
        readonly IEnumerable<T6> Item6;
        readonly ZipNotEnough NotEnough;
        public ZipTupleEnumerable(IEnumerable<T1> Item1
            , IEnumerable<T2> Item2
            , IEnumerable<T3> Item3
            , IEnumerable<T4> Item4
            , IEnumerable<T5> Item5
            , IEnumerable<T6> Item6
            , ZipNotEnough NotEnough = default)
            => (this.Item1, this.Item2, this.Item3, this.Item4, this.Item5, this.Item6, this.NotEnough)
            = (Item1, Item2, Item3, Item4, Item5, Item6, NotEnough);

        public IEnumerator<(T1, T2, T3, T4, T5, T6)> GetEnumerator()
        {
            switch (NotEnough) {
            case ZipNotEnough.Break:
                return GetEnumeratorOrBreak();
            case ZipNotEnough.Default:
                return GetEnumeratorOrDefault();
            }
            throw new NotSupportedException($"{nameof(NotEnough)}({NotEnough}) is NotSupport.");
        }
        private IEnumerator<(T1, T2, T3, T4, T5, T6)> GetEnumeratorOrBreak()
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
                    yield return
                        (Enumerator1.Current
                        , Enumerator2.Current
                        , Enumerator3.Current
                        , Enumerator4.Current
                        , Enumerator5.Current
                        , Enumerator6.Current);
        }
        private IEnumerator<(T1, T2, T3, T4, T5, T6)> GetEnumeratorOrDefault()
        {
            var DefaultValue1 = default(T1)!;
            var DefaultValue2 = default(T2)!;
            var DefaultValue3 = default(T3)!;
            var DefaultValue4 = default(T4)!;
            var DefaultValue5 = default(T5)!;
            var DefaultValue6 = default(T6)!;	
            using (var Enumerator1 = Item1.GetEnumerator())
            using (var Enumerator2 = Item2.GetEnumerator())
            using (var Enumerator3 = Item3.GetEnumerator())
            using (var Enumerator4 = Item4.GetEnumerator())
            using (var Enumerator5 = Item5.GetEnumerator())
            using (var Enumerator6 = Item6.GetEnumerator())
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
                    yield return (MoveNext1 ? Enumerator1.Current : DefaultValue1
                        , MoveNext2 ? Enumerator2.Current : DefaultValue2
                        , MoveNext3 ? Enumerator3.Current : DefaultValue3
                        , MoveNext4 ? Enumerator4.Current : DefaultValue4
                        , MoveNext5 ? Enumerator5.Current : DefaultValue5
                        , MoveNext6 ? Enumerator6.Current : DefaultValue6);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    internal class ZipTupleEnumerable<T1, T2, T3, T4, T5, T6, T7>
        : IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5, T6 Item6, T7 Item7)> {
        readonly IEnumerable<T1> Item1;
        readonly IEnumerable<T2> Item2;
        readonly IEnumerable<T3> Item3;
        readonly IEnumerable<T4> Item4;
        readonly IEnumerable<T5> Item5;
        readonly IEnumerable<T6> Item6;
        readonly IEnumerable<T7> Item7;
        readonly ZipNotEnough NotEnough;
        public ZipTupleEnumerable(IEnumerable<T1> Item1
            , IEnumerable<T2> Item2
            , IEnumerable<T3> Item3
            , IEnumerable<T4> Item4
            , IEnumerable<T5> Item5
            , IEnumerable<T6> Item6
            , IEnumerable<T7> Item7
            , ZipNotEnough NotEnough = default)
            => (this.Item1, this.Item2, this.Item3, this.Item4, this.Item5, this.Item6, this.Item7, this.NotEnough)
            = (Item1, Item2, Item3, Item4, Item5, Item6, Item7, NotEnough);

        public IEnumerator<(T1, T2, T3, T4, T5, T6, T7)> GetEnumerator()
        {
            switch (NotEnough) {
            case ZipNotEnough.Break:
                return GetEnumeratorOrBreak();
            case ZipNotEnough.Default:
                return GetEnumeratorOrDefault();
            }
            throw new NotSupportedException($"{nameof(NotEnough)}({NotEnough}) is NotSupport.");
        }
        private IEnumerator<(T1, T2, T3, T4, T5, T6, T7)> GetEnumeratorOrBreak()
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
                    yield return
                        (Enumerator1.Current
                        , Enumerator2.Current
                        , Enumerator3.Current
                        , Enumerator4.Current
                        , Enumerator5.Current
                        , Enumerator6.Current
                        , Enumerator7.Current);
        }
        private IEnumerator<(T1, T2, T3, T4, T5, T6, T7)> GetEnumeratorOrDefault()
        {
            var DefaultValue1 = default(T1)!;
            var DefaultValue2 = default(T2)!;
            var DefaultValue3 = default(T3)!;
            var DefaultValue4 = default(T4)!;
            var DefaultValue5 = default(T5)!;
            var DefaultValue6 = default(T6)!;
            var DefaultValue7 = default(T7)!;	
            using (var Enumerator1 = Item1.GetEnumerator())
            using (var Enumerator2 = Item2.GetEnumerator())
            using (var Enumerator3 = Item3.GetEnumerator())
            using (var Enumerator4 = Item4.GetEnumerator())
            using (var Enumerator5 = Item5.GetEnumerator())
            using (var Enumerator6 = Item6.GetEnumerator())
            using (var Enumerator7 = Item7.GetEnumerator())
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
                    yield return (MoveNext1 ? Enumerator1.Current : DefaultValue1
                        , MoveNext2 ? Enumerator2.Current : DefaultValue2
                        , MoveNext3 ? Enumerator3.Current : DefaultValue3
                        , MoveNext4 ? Enumerator4.Current : DefaultValue4
                        , MoveNext5 ? Enumerator5.Current : DefaultValue5
                        , MoveNext6 ? Enumerator6.Current : DefaultValue6
                        , MoveNext7 ? Enumerator7.Current : DefaultValue7);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    internal class ZipTupleEnumerable<T1, T2, T3, T4, T5, T6, T7, T8>
        : IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5, T6 Item6, T7 Item7, T8 Item8)> {
        readonly IEnumerable<T1> Item1;
        readonly IEnumerable<T2> Item2;
        readonly IEnumerable<T3> Item3;
        readonly IEnumerable<T4> Item4;
        readonly IEnumerable<T5> Item5;
        readonly IEnumerable<T6> Item6;
        readonly IEnumerable<T7> Item7;
        readonly IEnumerable<T8> Item8;
        readonly ZipNotEnough NotEnough;
        public ZipTupleEnumerable(IEnumerable<T1> Item1
            , IEnumerable<T2> Item2
            , IEnumerable<T3> Item3
            , IEnumerable<T4> Item4
            , IEnumerable<T5> Item5
            , IEnumerable<T6> Item6
            , IEnumerable<T7> Item7
            , IEnumerable<T8> Item8
            , ZipNotEnough NotEnough = default)
            => (this.Item1, this.Item2, this.Item3, this.Item4, this.Item5, this.Item6, this.Item7, this.Item8, this.NotEnough)
            = (Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, NotEnough);

        public IEnumerator<(T1, T2, T3, T4, T5, T6, T7, T8)> GetEnumerator()
        {
            switch (NotEnough) {
            case ZipNotEnough.Break:
                return GetEnumeratorOrBreak();
            case ZipNotEnough.Default:
                return GetEnumeratorOrDefault();
            }
            throw new NotSupportedException($"{nameof(NotEnough)}({NotEnough}) is NotSupport.");
        }
        private IEnumerator<(T1, T2, T3, T4, T5, T6, T7, T8)> GetEnumeratorOrBreak()
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
                    yield return
                        (Enumerator1.Current
                        , Enumerator2.Current
                        , Enumerator3.Current
                        , Enumerator4.Current
                        , Enumerator5.Current
                        , Enumerator6.Current
                        , Enumerator7.Current
                        , Enumerator8.Current);
        }
        private IEnumerator<(T1, T2, T3, T4, T5, T6, T7, T8)> GetEnumeratorOrDefault()
        {
            var DefaultValue1 = default(T1)!;
            var DefaultValue2 = default(T2)!;
            var DefaultValue3 = default(T3)!;
            var DefaultValue4 = default(T4)!;
            var DefaultValue5 = default(T5)!;
            var DefaultValue6 = default(T6)!;
            var DefaultValue7 = default(T7)!;
            var DefaultValue8 = default(T8)!;	
            using (var Enumerator1 = Item1.GetEnumerator())
            using (var Enumerator2 = Item2.GetEnumerator())
            using (var Enumerator3 = Item3.GetEnumerator())
            using (var Enumerator4 = Item4.GetEnumerator())
            using (var Enumerator5 = Item5.GetEnumerator())
            using (var Enumerator6 = Item6.GetEnumerator())
            using (var Enumerator7 = Item7.GetEnumerator())
            using (var Enumerator8 = Item8.GetEnumerator())
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
                    yield return (MoveNext1 ? Enumerator1.Current : DefaultValue1
                        , MoveNext2 ? Enumerator2.Current : DefaultValue2
                        , MoveNext3 ? Enumerator3.Current : DefaultValue3
                        , MoveNext4 ? Enumerator4.Current : DefaultValue4
                        , MoveNext5 ? Enumerator5.Current : DefaultValue5
                        , MoveNext6 ? Enumerator6.Current : DefaultValue6
                        , MoveNext7 ? Enumerator7.Current : DefaultValue7
                        , MoveNext8 ? Enumerator8.Current : DefaultValue8);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    internal class ZipTupleEnumerable<T1, T2, T3, T4, T5, T6, T7, T8, T9>
        : IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5, T6 Item6, T7 Item7, T8 Item8, T9 Item9)> {
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
        public ZipTupleEnumerable(IEnumerable<T1> Item1
            , IEnumerable<T2> Item2
            , IEnumerable<T3> Item3
            , IEnumerable<T4> Item4
            , IEnumerable<T5> Item5
            , IEnumerable<T6> Item6
            , IEnumerable<T7> Item7
            , IEnumerable<T8> Item8
            , IEnumerable<T9> Item9
            , ZipNotEnough NotEnough = default)
            => (this.Item1, this.Item2, this.Item3, this.Item4, this.Item5, this.Item6, this.Item7, this.Item8, this.Item9, this.NotEnough)
            = (Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9, NotEnough);

        public IEnumerator<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> GetEnumerator()
        {
            switch (NotEnough) {
            case ZipNotEnough.Break:
                return GetEnumeratorOrBreak();
            case ZipNotEnough.Default:
                return GetEnumeratorOrDefault();
            }
            throw new NotSupportedException($"{nameof(NotEnough)}({NotEnough}) is NotSupport.");
        }
        private IEnumerator<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> GetEnumeratorOrBreak()
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
                    yield return
                        (Enumerator1.Current
                        , Enumerator2.Current
                        , Enumerator3.Current
                        , Enumerator4.Current
                        , Enumerator5.Current
                        , Enumerator6.Current
                        , Enumerator7.Current
                        , Enumerator8.Current
                        , Enumerator9.Current);
        }
        private IEnumerator<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> GetEnumeratorOrDefault()
        {
            var DefaultValue1 = default(T1)!;
            var DefaultValue2 = default(T2)!;
            var DefaultValue3 = default(T3)!;
            var DefaultValue4 = default(T4)!;
            var DefaultValue5 = default(T5)!;
            var DefaultValue6 = default(T6)!;
            var DefaultValue7 = default(T7)!;
            var DefaultValue8 = default(T8)!;
            var DefaultValue9 = default(T9)!;	
            using (var Enumerator1 = Item1.GetEnumerator())
            using (var Enumerator2 = Item2.GetEnumerator())
            using (var Enumerator3 = Item3.GetEnumerator())
            using (var Enumerator4 = Item4.GetEnumerator())
            using (var Enumerator5 = Item5.GetEnumerator())
            using (var Enumerator6 = Item6.GetEnumerator())
            using (var Enumerator7 = Item7.GetEnumerator())
            using (var Enumerator8 = Item8.GetEnumerator())
            using (var Enumerator9 = Item9.GetEnumerator())
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
                    yield return (MoveNext1 ? Enumerator1.Current : DefaultValue1
                        , MoveNext2 ? Enumerator2.Current : DefaultValue2
                        , MoveNext3 ? Enumerator3.Current : DefaultValue3
                        , MoveNext4 ? Enumerator4.Current : DefaultValue4
                        , MoveNext5 ? Enumerator5.Current : DefaultValue5
                        , MoveNext6 ? Enumerator6.Current : DefaultValue6
                        , MoveNext7 ? Enumerator7.Current : DefaultValue7
                        , MoveNext8 ? Enumerator8.Current : DefaultValue8
                        , MoveNext9 ? Enumerator9.Current : DefaultValue9);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    internal class ZipTupleEnumerable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
        : IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5, T6 Item6, T7 Item7, T8 Item8, T9 Item9, T10 Item10)> {
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
            , ZipNotEnough NotEnough = default)
            => (this.Item1, this.Item2, this.Item3, this.Item4, this.Item5, this.Item6, this.Item7, this.Item8, this.Item9, this.Item10, this.NotEnough)
            = (Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9, Item10, NotEnough);

        public IEnumerator<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> GetEnumerator()
        {
            switch (NotEnough) {
            case ZipNotEnough.Break:
                return GetEnumeratorOrBreak();
            case ZipNotEnough.Default:
                return GetEnumeratorOrDefault();
            }
            throw new NotSupportedException($"{nameof(NotEnough)}({NotEnough}) is NotSupport.");
        }
        private IEnumerator<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> GetEnumeratorOrBreak()
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
                        , Enumerator10.Current);
        }
        private IEnumerator<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> GetEnumeratorOrDefault()
        {
            var DefaultValue1 = default(T1)!;
            var DefaultValue2 = default(T2)!;
            var DefaultValue3 = default(T3)!;
            var DefaultValue4 = default(T4)!;
            var DefaultValue5 = default(T5)!;
            var DefaultValue6 = default(T6)!;
            var DefaultValue7 = default(T7)!;
            var DefaultValue8 = default(T8)!;
            var DefaultValue9 = default(T9)!;
            var DefaultValue10 = default(T10)!;	
            using (var Enumerator1 = Item1.GetEnumerator())
            using (var Enumerator2 = Item2.GetEnumerator())
            using (var Enumerator3 = Item3.GetEnumerator())
            using (var Enumerator4 = Item4.GetEnumerator())
            using (var Enumerator5 = Item5.GetEnumerator())
            using (var Enumerator6 = Item6.GetEnumerator())
            using (var Enumerator7 = Item7.GetEnumerator())
            using (var Enumerator8 = Item8.GetEnumerator())
            using (var Enumerator9 = Item9.GetEnumerator())
            using (var Enumerator10 = Item10.GetEnumerator())
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
                    yield return (MoveNext1 ? Enumerator1.Current : DefaultValue1
                        , MoveNext2 ? Enumerator2.Current : DefaultValue2
                        , MoveNext3 ? Enumerator3.Current : DefaultValue3
                        , MoveNext4 ? Enumerator4.Current : DefaultValue4
                        , MoveNext5 ? Enumerator5.Current : DefaultValue5
                        , MoveNext6 ? Enumerator6.Current : DefaultValue6
                        , MoveNext7 ? Enumerator7.Current : DefaultValue7
                        , MoveNext8 ? Enumerator8.Current : DefaultValue8
                        , MoveNext9 ? Enumerator9.Current : DefaultValue9
                        , MoveNext10 ? Enumerator10.Current : DefaultValue10);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    internal class ZipTupleEnumerable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
        : IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5, T6 Item6, T7 Item7, T8 Item8, T9 Item9, T10 Item10, T11 Item11)> {
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
            , ZipNotEnough NotEnough = default)
            => (this.Item1, this.Item2, this.Item3, this.Item4, this.Item5, this.Item6, this.Item7, this.Item8, this.Item9, this.Item10, this.Item11, this.NotEnough)
            = (Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9, Item10, Item11, NotEnough);

        public IEnumerator<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)> GetEnumerator()
        {
            switch (NotEnough) {
            case ZipNotEnough.Break:
                return GetEnumeratorOrBreak();
            case ZipNotEnough.Default:
                return GetEnumeratorOrDefault();
            }
            throw new NotSupportedException($"{nameof(NotEnough)}({NotEnough}) is NotSupport.");
        }
        private IEnumerator<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)> GetEnumeratorOrBreak()
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
                        , Enumerator11.Current);
        }
        private IEnumerator<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)> GetEnumeratorOrDefault()
        {
            var DefaultValue1 = default(T1)!;
            var DefaultValue2 = default(T2)!;
            var DefaultValue3 = default(T3)!;
            var DefaultValue4 = default(T4)!;
            var DefaultValue5 = default(T5)!;
            var DefaultValue6 = default(T6)!;
            var DefaultValue7 = default(T7)!;
            var DefaultValue8 = default(T8)!;
            var DefaultValue9 = default(T9)!;
            var DefaultValue10 = default(T10)!;
            var DefaultValue11 = default(T11)!;	
            using (var Enumerator1 = Item1.GetEnumerator())
            using (var Enumerator2 = Item2.GetEnumerator())
            using (var Enumerator3 = Item3.GetEnumerator())
            using (var Enumerator4 = Item4.GetEnumerator())
            using (var Enumerator5 = Item5.GetEnumerator())
            using (var Enumerator6 = Item6.GetEnumerator())
            using (var Enumerator7 = Item7.GetEnumerator())
            using (var Enumerator8 = Item8.GetEnumerator())
            using (var Enumerator9 = Item9.GetEnumerator())
            using (var Enumerator10 = Item10.GetEnumerator())
            using (var Enumerator11 = Item11.GetEnumerator())
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
                    yield return (MoveNext1 ? Enumerator1.Current : DefaultValue1
                        , MoveNext2 ? Enumerator2.Current : DefaultValue2
                        , MoveNext3 ? Enumerator3.Current : DefaultValue3
                        , MoveNext4 ? Enumerator4.Current : DefaultValue4
                        , MoveNext5 ? Enumerator5.Current : DefaultValue5
                        , MoveNext6 ? Enumerator6.Current : DefaultValue6
                        , MoveNext7 ? Enumerator7.Current : DefaultValue7
                        , MoveNext8 ? Enumerator8.Current : DefaultValue8
                        , MoveNext9 ? Enumerator9.Current : DefaultValue9
                        , MoveNext10 ? Enumerator10.Current : DefaultValue10
                        , MoveNext11 ? Enumerator11.Current : DefaultValue11);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    internal class ZipTupleEnumerable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
        : IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5, T6 Item6, T7 Item7, T8 Item8, T9 Item9, T10 Item10, T11 Item11, T12 Item12)> {
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
            , ZipNotEnough NotEnough = default)
            => (this.Item1, this.Item2, this.Item3, this.Item4, this.Item5, this.Item6, this.Item7, this.Item8, this.Item9, this.Item10, this.Item11, this.Item12, this.NotEnough)
            = (Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9, Item10, Item11, Item12, NotEnough);

        public IEnumerator<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)> GetEnumerator()
        {
            switch (NotEnough) {
            case ZipNotEnough.Break:
                return GetEnumeratorOrBreak();
            case ZipNotEnough.Default:
                return GetEnumeratorOrDefault();
            }
            throw new NotSupportedException($"{nameof(NotEnough)}({NotEnough}) is NotSupport.");
        }
        private IEnumerator<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)> GetEnumeratorOrBreak()
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
                        , Enumerator12.Current);
        }
        private IEnumerator<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)> GetEnumeratorOrDefault()
        {
            var DefaultValue1 = default(T1)!;
            var DefaultValue2 = default(T2)!;
            var DefaultValue3 = default(T3)!;
            var DefaultValue4 = default(T4)!;
            var DefaultValue5 = default(T5)!;
            var DefaultValue6 = default(T6)!;
            var DefaultValue7 = default(T7)!;
            var DefaultValue8 = default(T8)!;
            var DefaultValue9 = default(T9)!;
            var DefaultValue10 = default(T10)!;
            var DefaultValue11 = default(T11)!;
            var DefaultValue12 = default(T12)!;	
            using (var Enumerator1 = Item1.GetEnumerator())
            using (var Enumerator2 = Item2.GetEnumerator())
            using (var Enumerator3 = Item3.GetEnumerator())
            using (var Enumerator4 = Item4.GetEnumerator())
            using (var Enumerator5 = Item5.GetEnumerator())
            using (var Enumerator6 = Item6.GetEnumerator())
            using (var Enumerator7 = Item7.GetEnumerator())
            using (var Enumerator8 = Item8.GetEnumerator())
            using (var Enumerator9 = Item9.GetEnumerator())
            using (var Enumerator10 = Item10.GetEnumerator())
            using (var Enumerator11 = Item11.GetEnumerator())
            using (var Enumerator12 = Item12.GetEnumerator())
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
                    yield return (MoveNext1 ? Enumerator1.Current : DefaultValue1
                        , MoveNext2 ? Enumerator2.Current : DefaultValue2
                        , MoveNext3 ? Enumerator3.Current : DefaultValue3
                        , MoveNext4 ? Enumerator4.Current : DefaultValue4
                        , MoveNext5 ? Enumerator5.Current : DefaultValue5
                        , MoveNext6 ? Enumerator6.Current : DefaultValue6
                        , MoveNext7 ? Enumerator7.Current : DefaultValue7
                        , MoveNext8 ? Enumerator8.Current : DefaultValue8
                        , MoveNext9 ? Enumerator9.Current : DefaultValue9
                        , MoveNext10 ? Enumerator10.Current : DefaultValue10
                        , MoveNext11 ? Enumerator11.Current : DefaultValue11
                        , MoveNext12 ? Enumerator12.Current : DefaultValue12);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    internal class ZipTupleEnumerable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
        : IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5, T6 Item6, T7 Item7, T8 Item8, T9 Item9, T10 Item10, T11 Item11, T12 Item12, T13 Item13)> {
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
            , ZipNotEnough NotEnough = default)
            => (this.Item1, this.Item2, this.Item3, this.Item4, this.Item5, this.Item6, this.Item7, this.Item8, this.Item9, this.Item10, this.Item11, this.Item12, this.Item13, this.NotEnough)
            = (Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9, Item10, Item11, Item12, Item13, NotEnough);

        public IEnumerator<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)> GetEnumerator()
        {
            switch (NotEnough) {
            case ZipNotEnough.Break:
                return GetEnumeratorOrBreak();
            case ZipNotEnough.Default:
                return GetEnumeratorOrDefault();
            }
            throw new NotSupportedException($"{nameof(NotEnough)}({NotEnough}) is NotSupport.");
        }
        private IEnumerator<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)> GetEnumeratorOrBreak()
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
                        , Enumerator13.Current);
        }
        private IEnumerator<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)> GetEnumeratorOrDefault()
        {
            var DefaultValue1 = default(T1)!;
            var DefaultValue2 = default(T2)!;
            var DefaultValue3 = default(T3)!;
            var DefaultValue4 = default(T4)!;
            var DefaultValue5 = default(T5)!;
            var DefaultValue6 = default(T6)!;
            var DefaultValue7 = default(T7)!;
            var DefaultValue8 = default(T8)!;
            var DefaultValue9 = default(T9)!;
            var DefaultValue10 = default(T10)!;
            var DefaultValue11 = default(T11)!;
            var DefaultValue12 = default(T12)!;
            var DefaultValue13 = default(T13)!;	
            using (var Enumerator1 = Item1.GetEnumerator())
            using (var Enumerator2 = Item2.GetEnumerator())
            using (var Enumerator3 = Item3.GetEnumerator())
            using (var Enumerator4 = Item4.GetEnumerator())
            using (var Enumerator5 = Item5.GetEnumerator())
            using (var Enumerator6 = Item6.GetEnumerator())
            using (var Enumerator7 = Item7.GetEnumerator())
            using (var Enumerator8 = Item8.GetEnumerator())
            using (var Enumerator9 = Item9.GetEnumerator())
            using (var Enumerator10 = Item10.GetEnumerator())
            using (var Enumerator11 = Item11.GetEnumerator())
            using (var Enumerator12 = Item12.GetEnumerator())
            using (var Enumerator13 = Item13.GetEnumerator())
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
                    yield return (MoveNext1 ? Enumerator1.Current : DefaultValue1
                        , MoveNext2 ? Enumerator2.Current : DefaultValue2
                        , MoveNext3 ? Enumerator3.Current : DefaultValue3
                        , MoveNext4 ? Enumerator4.Current : DefaultValue4
                        , MoveNext5 ? Enumerator5.Current : DefaultValue5
                        , MoveNext6 ? Enumerator6.Current : DefaultValue6
                        , MoveNext7 ? Enumerator7.Current : DefaultValue7
                        , MoveNext8 ? Enumerator8.Current : DefaultValue8
                        , MoveNext9 ? Enumerator9.Current : DefaultValue9
                        , MoveNext10 ? Enumerator10.Current : DefaultValue10
                        , MoveNext11 ? Enumerator11.Current : DefaultValue11
                        , MoveNext12 ? Enumerator12.Current : DefaultValue12
                        , MoveNext13 ? Enumerator13.Current : DefaultValue13);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    internal class ZipTupleEnumerable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
        : IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5, T6 Item6, T7 Item7, T8 Item8, T9 Item9, T10 Item10, T11 Item11, T12 Item12, T13 Item13, T14 Item14)> {
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
            , ZipNotEnough NotEnough = default)
            => (this.Item1, this.Item2, this.Item3, this.Item4, this.Item5, this.Item6, this.Item7, this.Item8, this.Item9, this.Item10, this.Item11, this.Item12, this.Item13, this.Item14, this.NotEnough)
            = (Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9, Item10, Item11, Item12, Item13, Item14, NotEnough);

        public IEnumerator<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)> GetEnumerator()
        {
            switch (NotEnough) {
            case ZipNotEnough.Break:
                return GetEnumeratorOrBreak();
            case ZipNotEnough.Default:
                return GetEnumeratorOrDefault();
            }
            throw new NotSupportedException($"{nameof(NotEnough)}({NotEnough}) is NotSupport.");
        }
        private IEnumerator<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)> GetEnumeratorOrBreak()
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
                        , Enumerator14.Current);
        }
        private IEnumerator<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)> GetEnumeratorOrDefault()
        {
            var DefaultValue1 = default(T1)!;
            var DefaultValue2 = default(T2)!;
            var DefaultValue3 = default(T3)!;
            var DefaultValue4 = default(T4)!;
            var DefaultValue5 = default(T5)!;
            var DefaultValue6 = default(T6)!;
            var DefaultValue7 = default(T7)!;
            var DefaultValue8 = default(T8)!;
            var DefaultValue9 = default(T9)!;
            var DefaultValue10 = default(T10)!;
            var DefaultValue11 = default(T11)!;
            var DefaultValue12 = default(T12)!;
            var DefaultValue13 = default(T13)!;
            var DefaultValue14 = default(T14)!;	
            using (var Enumerator1 = Item1.GetEnumerator())
            using (var Enumerator2 = Item2.GetEnumerator())
            using (var Enumerator3 = Item3.GetEnumerator())
            using (var Enumerator4 = Item4.GetEnumerator())
            using (var Enumerator5 = Item5.GetEnumerator())
            using (var Enumerator6 = Item6.GetEnumerator())
            using (var Enumerator7 = Item7.GetEnumerator())
            using (var Enumerator8 = Item8.GetEnumerator())
            using (var Enumerator9 = Item9.GetEnumerator())
            using (var Enumerator10 = Item10.GetEnumerator())
            using (var Enumerator11 = Item11.GetEnumerator())
            using (var Enumerator12 = Item12.GetEnumerator())
            using (var Enumerator13 = Item13.GetEnumerator())
            using (var Enumerator14 = Item14.GetEnumerator())
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
                    yield return (MoveNext1 ? Enumerator1.Current : DefaultValue1
                        , MoveNext2 ? Enumerator2.Current : DefaultValue2
                        , MoveNext3 ? Enumerator3.Current : DefaultValue3
                        , MoveNext4 ? Enumerator4.Current : DefaultValue4
                        , MoveNext5 ? Enumerator5.Current : DefaultValue5
                        , MoveNext6 ? Enumerator6.Current : DefaultValue6
                        , MoveNext7 ? Enumerator7.Current : DefaultValue7
                        , MoveNext8 ? Enumerator8.Current : DefaultValue8
                        , MoveNext9 ? Enumerator9.Current : DefaultValue9
                        , MoveNext10 ? Enumerator10.Current : DefaultValue10
                        , MoveNext11 ? Enumerator11.Current : DefaultValue11
                        , MoveNext12 ? Enumerator12.Current : DefaultValue12
                        , MoveNext13 ? Enumerator13.Current : DefaultValue13
                        , MoveNext14 ? Enumerator14.Current : DefaultValue14);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    internal class ZipTupleEnumerable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
        : IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5, T6 Item6, T7 Item7, T8 Item8, T9 Item9, T10 Item10, T11 Item11, T12 Item12, T13 Item13, T14 Item14, T15 Item15)> {
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
            , ZipNotEnough NotEnough = default)
            => (this.Item1, this.Item2, this.Item3, this.Item4, this.Item5, this.Item6, this.Item7, this.Item8, this.Item9, this.Item10, this.Item11, this.Item12, this.Item13, this.Item14, this.Item15, this.NotEnough)
            = (Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9, Item10, Item11, Item12, Item13, Item14, Item15, NotEnough);

        public IEnumerator<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)> GetEnumerator()
        {
            switch (NotEnough) {
            case ZipNotEnough.Break:
                return GetEnumeratorOrBreak();
            case ZipNotEnough.Default:
                return GetEnumeratorOrDefault();
            }
            throw new NotSupportedException($"{nameof(NotEnough)}({NotEnough}) is NotSupport.");
        }
        private IEnumerator<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)> GetEnumeratorOrBreak()
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
                        , Enumerator15.Current);
        }
        private IEnumerator<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)> GetEnumeratorOrDefault()
        {
            var DefaultValue1 = default(T1)!;
            var DefaultValue2 = default(T2)!;
            var DefaultValue3 = default(T3)!;
            var DefaultValue4 = default(T4)!;
            var DefaultValue5 = default(T5)!;
            var DefaultValue6 = default(T6)!;
            var DefaultValue7 = default(T7)!;
            var DefaultValue8 = default(T8)!;
            var DefaultValue9 = default(T9)!;
            var DefaultValue10 = default(T10)!;
            var DefaultValue11 = default(T11)!;
            var DefaultValue12 = default(T12)!;
            var DefaultValue13 = default(T13)!;
            var DefaultValue14 = default(T14)!;
            var DefaultValue15 = default(T15)!;	
            using (var Enumerator1 = Item1.GetEnumerator())
            using (var Enumerator2 = Item2.GetEnumerator())
            using (var Enumerator3 = Item3.GetEnumerator())
            using (var Enumerator4 = Item4.GetEnumerator())
            using (var Enumerator5 = Item5.GetEnumerator())
            using (var Enumerator6 = Item6.GetEnumerator())
            using (var Enumerator7 = Item7.GetEnumerator())
            using (var Enumerator8 = Item8.GetEnumerator())
            using (var Enumerator9 = Item9.GetEnumerator())
            using (var Enumerator10 = Item10.GetEnumerator())
            using (var Enumerator11 = Item11.GetEnumerator())
            using (var Enumerator12 = Item12.GetEnumerator())
            using (var Enumerator13 = Item13.GetEnumerator())
            using (var Enumerator14 = Item14.GetEnumerator())
            using (var Enumerator15 = Item15.GetEnumerator())
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
                    yield return (MoveNext1 ? Enumerator1.Current : DefaultValue1
                        , MoveNext2 ? Enumerator2.Current : DefaultValue2
                        , MoveNext3 ? Enumerator3.Current : DefaultValue3
                        , MoveNext4 ? Enumerator4.Current : DefaultValue4
                        , MoveNext5 ? Enumerator5.Current : DefaultValue5
                        , MoveNext6 ? Enumerator6.Current : DefaultValue6
                        , MoveNext7 ? Enumerator7.Current : DefaultValue7
                        , MoveNext8 ? Enumerator8.Current : DefaultValue8
                        , MoveNext9 ? Enumerator9.Current : DefaultValue9
                        , MoveNext10 ? Enumerator10.Current : DefaultValue10
                        , MoveNext11 ? Enumerator11.Current : DefaultValue11
                        , MoveNext12 ? Enumerator12.Current : DefaultValue12
                        , MoveNext13 ? Enumerator13.Current : DefaultValue13
                        , MoveNext14 ? Enumerator14.Current : DefaultValue14
                        , MoveNext15 ? Enumerator15.Current : DefaultValue15);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    internal class ZipTupleEnumerable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
        : IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4, T5 Item5, T6 Item6, T7 Item7, T8 Item8, T9 Item9, T10 Item10, T11 Item11, T12 Item12, T13 Item13, T14 Item14, T15 Item15, T16 Item16)> {
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
            , ZipNotEnough NotEnough = default)
            => (this.Item1, this.Item2, this.Item3, this.Item4, this.Item5, this.Item6, this.Item7, this.Item8, this.Item9, this.Item10, this.Item11, this.Item12, this.Item13, this.Item14, this.Item15, this.Item16, this.NotEnough)
            = (Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9, Item10, Item11, Item12, Item13, Item14, Item15, Item16, NotEnough);

        public IEnumerator<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16)> GetEnumerator()
        {
            switch (NotEnough) {
            case ZipNotEnough.Break:
                return GetEnumeratorOrBreak();
            case ZipNotEnough.Default:
                return GetEnumeratorOrDefault();
            }
            throw new NotSupportedException($"{nameof(NotEnough)}({NotEnough}) is NotSupport.");
        }
        private IEnumerator<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16)> GetEnumeratorOrBreak()
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
                        , Enumerator16.Current);
        }
        private IEnumerator<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16)> GetEnumeratorOrDefault()
        {
            var DefaultValue1 = default(T1)!;
            var DefaultValue2 = default(T2)!;
            var DefaultValue3 = default(T3)!;
            var DefaultValue4 = default(T4)!;
            var DefaultValue5 = default(T5)!;
            var DefaultValue6 = default(T6)!;
            var DefaultValue7 = default(T7)!;
            var DefaultValue8 = default(T8)!;
            var DefaultValue9 = default(T9)!;
            var DefaultValue10 = default(T10)!;
            var DefaultValue11 = default(T11)!;
            var DefaultValue12 = default(T12)!;
            var DefaultValue13 = default(T13)!;
            var DefaultValue14 = default(T14)!;
            var DefaultValue15 = default(T15)!;
            var DefaultValue16 = default(T16)!;	
            using (var Enumerator1 = Item1.GetEnumerator())
            using (var Enumerator2 = Item2.GetEnumerator())
            using (var Enumerator3 = Item3.GetEnumerator())
            using (var Enumerator4 = Item4.GetEnumerator())
            using (var Enumerator5 = Item5.GetEnumerator())
            using (var Enumerator6 = Item6.GetEnumerator())
            using (var Enumerator7 = Item7.GetEnumerator())
            using (var Enumerator8 = Item8.GetEnumerator())
            using (var Enumerator9 = Item9.GetEnumerator())
            using (var Enumerator10 = Item10.GetEnumerator())
            using (var Enumerator11 = Item11.GetEnumerator())
            using (var Enumerator12 = Item12.GetEnumerator())
            using (var Enumerator13 = Item13.GetEnumerator())
            using (var Enumerator14 = Item14.GetEnumerator())
            using (var Enumerator15 = Item15.GetEnumerator())
            using (var Enumerator16 = Item16.GetEnumerator())
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
                    yield return (MoveNext1 ? Enumerator1.Current : DefaultValue1
                        , MoveNext2 ? Enumerator2.Current : DefaultValue2
                        , MoveNext3 ? Enumerator3.Current : DefaultValue3
                        , MoveNext4 ? Enumerator4.Current : DefaultValue4
                        , MoveNext5 ? Enumerator5.Current : DefaultValue5
                        , MoveNext6 ? Enumerator6.Current : DefaultValue6
                        , MoveNext7 ? Enumerator7.Current : DefaultValue7
                        , MoveNext8 ? Enumerator8.Current : DefaultValue8
                        , MoveNext9 ? Enumerator9.Current : DefaultValue9
                        , MoveNext10 ? Enumerator10.Current : DefaultValue10
                        , MoveNext11 ? Enumerator11.Current : DefaultValue11
                        , MoveNext12 ? Enumerator12.Current : DefaultValue12
                        , MoveNext13 ? Enumerator13.Current : DefaultValue13
                        , MoveNext14 ? Enumerator14.Current : DefaultValue14
                        , MoveNext15 ? Enumerator15.Current : DefaultValue15
                        , MoveNext16 ? Enumerator16.Current : DefaultValue16);
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
            => (this.Item1, this.Item2, this.Item3, this.Item4, this.Item5, this.Item6, this.Item7, this.Item8, this.Item9, this.Item10, this.Item11, this.Item12, this.Item13, this.Item14, this.Item15, this.Item16, this.Item17, this.NotEnough)
            = (Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9, Item10, Item11, Item12, Item13, Item14, Item15, Item16, Item17, NotEnough);

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
            var DefaultValue1 = default(T1)!;
            var DefaultValue2 = default(T2)!;
            var DefaultValue3 = default(T3)!;
            var DefaultValue4 = default(T4)!;
            var DefaultValue5 = default(T5)!;
            var DefaultValue6 = default(T6)!;
            var DefaultValue7 = default(T7)!;
            var DefaultValue8 = default(T8)!;
            var DefaultValue9 = default(T9)!;
            var DefaultValue10 = default(T10)!;
            var DefaultValue11 = default(T11)!;
            var DefaultValue12 = default(T12)!;
            var DefaultValue13 = default(T13)!;
            var DefaultValue14 = default(T14)!;
            var DefaultValue15 = default(T15)!;
            var DefaultValue16 = default(T16)!;
            var DefaultValue17 = default(T17)!;	
            using (var Enumerator1 = Item1.GetEnumerator())
            using (var Enumerator2 = Item2.GetEnumerator())
            using (var Enumerator3 = Item3.GetEnumerator())
            using (var Enumerator4 = Item4.GetEnumerator())
            using (var Enumerator5 = Item5.GetEnumerator())
            using (var Enumerator6 = Item6.GetEnumerator())
            using (var Enumerator7 = Item7.GetEnumerator())
            using (var Enumerator8 = Item8.GetEnumerator())
            using (var Enumerator9 = Item9.GetEnumerator())
            using (var Enumerator10 = Item10.GetEnumerator())
            using (var Enumerator11 = Item11.GetEnumerator())
            using (var Enumerator12 = Item12.GetEnumerator())
            using (var Enumerator13 = Item13.GetEnumerator())
            using (var Enumerator14 = Item14.GetEnumerator())
            using (var Enumerator15 = Item15.GetEnumerator())
            using (var Enumerator16 = Item16.GetEnumerator())
            using (var Enumerator17 = Item17.GetEnumerator())
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
                    yield return (MoveNext1 ? Enumerator1.Current : DefaultValue1
                        , MoveNext2 ? Enumerator2.Current : DefaultValue2
                        , MoveNext3 ? Enumerator3.Current : DefaultValue3
                        , MoveNext4 ? Enumerator4.Current : DefaultValue4
                        , MoveNext5 ? Enumerator5.Current : DefaultValue5
                        , MoveNext6 ? Enumerator6.Current : DefaultValue6
                        , MoveNext7 ? Enumerator7.Current : DefaultValue7
                        , MoveNext8 ? Enumerator8.Current : DefaultValue8
                        , MoveNext9 ? Enumerator9.Current : DefaultValue9
                        , MoveNext10 ? Enumerator10.Current : DefaultValue10
                        , MoveNext11 ? Enumerator11.Current : DefaultValue11
                        , MoveNext12 ? Enumerator12.Current : DefaultValue12
                        , MoveNext13 ? Enumerator13.Current : DefaultValue13
                        , MoveNext14 ? Enumerator14.Current : DefaultValue14
                        , MoveNext15 ? Enumerator15.Current : DefaultValue15
                        , MoveNext16 ? Enumerator16.Current : DefaultValue16
                        , MoveNext17 ? Enumerator17.Current : DefaultValue17);
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
            => (this.Item1, this.Item2, this.Item3, this.Item4, this.Item5, this.Item6, this.Item7, this.Item8, this.Item9, this.Item10, this.Item11, this.Item12, this.Item13, this.Item14, this.Item15, this.Item16, this.Item17, this.Item18, this.NotEnough)
            = (Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9, Item10, Item11, Item12, Item13, Item14, Item15, Item16, Item17, Item18, NotEnough);

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
            var DefaultValue1 = default(T1)!;
            var DefaultValue2 = default(T2)!;
            var DefaultValue3 = default(T3)!;
            var DefaultValue4 = default(T4)!;
            var DefaultValue5 = default(T5)!;
            var DefaultValue6 = default(T6)!;
            var DefaultValue7 = default(T7)!;
            var DefaultValue8 = default(T8)!;
            var DefaultValue9 = default(T9)!;
            var DefaultValue10 = default(T10)!;
            var DefaultValue11 = default(T11)!;
            var DefaultValue12 = default(T12)!;
            var DefaultValue13 = default(T13)!;
            var DefaultValue14 = default(T14)!;
            var DefaultValue15 = default(T15)!;
            var DefaultValue16 = default(T16)!;
            var DefaultValue17 = default(T17)!;
            var DefaultValue18 = default(T18)!;	
            using (var Enumerator1 = Item1.GetEnumerator())
            using (var Enumerator2 = Item2.GetEnumerator())
            using (var Enumerator3 = Item3.GetEnumerator())
            using (var Enumerator4 = Item4.GetEnumerator())
            using (var Enumerator5 = Item5.GetEnumerator())
            using (var Enumerator6 = Item6.GetEnumerator())
            using (var Enumerator7 = Item7.GetEnumerator())
            using (var Enumerator8 = Item8.GetEnumerator())
            using (var Enumerator9 = Item9.GetEnumerator())
            using (var Enumerator10 = Item10.GetEnumerator())
            using (var Enumerator11 = Item11.GetEnumerator())
            using (var Enumerator12 = Item12.GetEnumerator())
            using (var Enumerator13 = Item13.GetEnumerator())
            using (var Enumerator14 = Item14.GetEnumerator())
            using (var Enumerator15 = Item15.GetEnumerator())
            using (var Enumerator16 = Item16.GetEnumerator())
            using (var Enumerator17 = Item17.GetEnumerator())
            using (var Enumerator18 = Item18.GetEnumerator())
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
                    yield return (MoveNext1 ? Enumerator1.Current : DefaultValue1
                        , MoveNext2 ? Enumerator2.Current : DefaultValue2
                        , MoveNext3 ? Enumerator3.Current : DefaultValue3
                        , MoveNext4 ? Enumerator4.Current : DefaultValue4
                        , MoveNext5 ? Enumerator5.Current : DefaultValue5
                        , MoveNext6 ? Enumerator6.Current : DefaultValue6
                        , MoveNext7 ? Enumerator7.Current : DefaultValue7
                        , MoveNext8 ? Enumerator8.Current : DefaultValue8
                        , MoveNext9 ? Enumerator9.Current : DefaultValue9
                        , MoveNext10 ? Enumerator10.Current : DefaultValue10
                        , MoveNext11 ? Enumerator11.Current : DefaultValue11
                        , MoveNext12 ? Enumerator12.Current : DefaultValue12
                        , MoveNext13 ? Enumerator13.Current : DefaultValue13
                        , MoveNext14 ? Enumerator14.Current : DefaultValue14
                        , MoveNext15 ? Enumerator15.Current : DefaultValue15
                        , MoveNext16 ? Enumerator16.Current : DefaultValue16
                        , MoveNext17 ? Enumerator17.Current : DefaultValue17
                        , MoveNext18 ? Enumerator18.Current : DefaultValue18);
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
            => (this.Item1, this.Item2, this.Item3, this.Item4, this.Item5, this.Item6, this.Item7, this.Item8, this.Item9, this.Item10, this.Item11, this.Item12, this.Item13, this.Item14, this.Item15, this.Item16, this.Item17, this.Item18, this.Item19, this.NotEnough)
            = (Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9, Item10, Item11, Item12, Item13, Item14, Item15, Item16, Item17, Item18, Item19, NotEnough);

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
            var DefaultValue1 = default(T1)!;
            var DefaultValue2 = default(T2)!;
            var DefaultValue3 = default(T3)!;
            var DefaultValue4 = default(T4)!;
            var DefaultValue5 = default(T5)!;
            var DefaultValue6 = default(T6)!;
            var DefaultValue7 = default(T7)!;
            var DefaultValue8 = default(T8)!;
            var DefaultValue9 = default(T9)!;
            var DefaultValue10 = default(T10)!;
            var DefaultValue11 = default(T11)!;
            var DefaultValue12 = default(T12)!;
            var DefaultValue13 = default(T13)!;
            var DefaultValue14 = default(T14)!;
            var DefaultValue15 = default(T15)!;
            var DefaultValue16 = default(T16)!;
            var DefaultValue17 = default(T17)!;
            var DefaultValue18 = default(T18)!;
            var DefaultValue19 = default(T19)!;	
            using (var Enumerator1 = Item1.GetEnumerator())
            using (var Enumerator2 = Item2.GetEnumerator())
            using (var Enumerator3 = Item3.GetEnumerator())
            using (var Enumerator4 = Item4.GetEnumerator())
            using (var Enumerator5 = Item5.GetEnumerator())
            using (var Enumerator6 = Item6.GetEnumerator())
            using (var Enumerator7 = Item7.GetEnumerator())
            using (var Enumerator8 = Item8.GetEnumerator())
            using (var Enumerator9 = Item9.GetEnumerator())
            using (var Enumerator10 = Item10.GetEnumerator())
            using (var Enumerator11 = Item11.GetEnumerator())
            using (var Enumerator12 = Item12.GetEnumerator())
            using (var Enumerator13 = Item13.GetEnumerator())
            using (var Enumerator14 = Item14.GetEnumerator())
            using (var Enumerator15 = Item15.GetEnumerator())
            using (var Enumerator16 = Item16.GetEnumerator())
            using (var Enumerator17 = Item17.GetEnumerator())
            using (var Enumerator18 = Item18.GetEnumerator())
            using (var Enumerator19 = Item19.GetEnumerator())
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
                    yield return (MoveNext1 ? Enumerator1.Current : DefaultValue1
                        , MoveNext2 ? Enumerator2.Current : DefaultValue2
                        , MoveNext3 ? Enumerator3.Current : DefaultValue3
                        , MoveNext4 ? Enumerator4.Current : DefaultValue4
                        , MoveNext5 ? Enumerator5.Current : DefaultValue5
                        , MoveNext6 ? Enumerator6.Current : DefaultValue6
                        , MoveNext7 ? Enumerator7.Current : DefaultValue7
                        , MoveNext8 ? Enumerator8.Current : DefaultValue8
                        , MoveNext9 ? Enumerator9.Current : DefaultValue9
                        , MoveNext10 ? Enumerator10.Current : DefaultValue10
                        , MoveNext11 ? Enumerator11.Current : DefaultValue11
                        , MoveNext12 ? Enumerator12.Current : DefaultValue12
                        , MoveNext13 ? Enumerator13.Current : DefaultValue13
                        , MoveNext14 ? Enumerator14.Current : DefaultValue14
                        , MoveNext15 ? Enumerator15.Current : DefaultValue15
                        , MoveNext16 ? Enumerator16.Current : DefaultValue16
                        , MoveNext17 ? Enumerator17.Current : DefaultValue17
                        , MoveNext18 ? Enumerator18.Current : DefaultValue18
                        , MoveNext19 ? Enumerator19.Current : DefaultValue19);
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
            => (this.Item1, this.Item2, this.Item3, this.Item4, this.Item5, this.Item6, this.Item7, this.Item8, this.Item9, this.Item10, this.Item11, this.Item12, this.Item13, this.Item14, this.Item15, this.Item16, this.Item17, this.Item18, this.Item19, this.Item20, this.NotEnough)
            = (Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9, Item10, Item11, Item12, Item13, Item14, Item15, Item16, Item17, Item18, Item19, Item20, NotEnough);

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
            var DefaultValue1 = default(T1)!;
            var DefaultValue2 = default(T2)!;
            var DefaultValue3 = default(T3)!;
            var DefaultValue4 = default(T4)!;
            var DefaultValue5 = default(T5)!;
            var DefaultValue6 = default(T6)!;
            var DefaultValue7 = default(T7)!;
            var DefaultValue8 = default(T8)!;
            var DefaultValue9 = default(T9)!;
            var DefaultValue10 = default(T10)!;
            var DefaultValue11 = default(T11)!;
            var DefaultValue12 = default(T12)!;
            var DefaultValue13 = default(T13)!;
            var DefaultValue14 = default(T14)!;
            var DefaultValue15 = default(T15)!;
            var DefaultValue16 = default(T16)!;
            var DefaultValue17 = default(T17)!;
            var DefaultValue18 = default(T18)!;
            var DefaultValue19 = default(T19)!;
            var DefaultValue20 = default(T20)!;	
            using (var Enumerator1 = Item1.GetEnumerator())
            using (var Enumerator2 = Item2.GetEnumerator())
            using (var Enumerator3 = Item3.GetEnumerator())
            using (var Enumerator4 = Item4.GetEnumerator())
            using (var Enumerator5 = Item5.GetEnumerator())
            using (var Enumerator6 = Item6.GetEnumerator())
            using (var Enumerator7 = Item7.GetEnumerator())
            using (var Enumerator8 = Item8.GetEnumerator())
            using (var Enumerator9 = Item9.GetEnumerator())
            using (var Enumerator10 = Item10.GetEnumerator())
            using (var Enumerator11 = Item11.GetEnumerator())
            using (var Enumerator12 = Item12.GetEnumerator())
            using (var Enumerator13 = Item13.GetEnumerator())
            using (var Enumerator14 = Item14.GetEnumerator())
            using (var Enumerator15 = Item15.GetEnumerator())
            using (var Enumerator16 = Item16.GetEnumerator())
            using (var Enumerator17 = Item17.GetEnumerator())
            using (var Enumerator18 = Item18.GetEnumerator())
            using (var Enumerator19 = Item19.GetEnumerator())
            using (var Enumerator20 = Item20.GetEnumerator())
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
                    yield return (MoveNext1 ? Enumerator1.Current : DefaultValue1
                        , MoveNext2 ? Enumerator2.Current : DefaultValue2
                        , MoveNext3 ? Enumerator3.Current : DefaultValue3
                        , MoveNext4 ? Enumerator4.Current : DefaultValue4
                        , MoveNext5 ? Enumerator5.Current : DefaultValue5
                        , MoveNext6 ? Enumerator6.Current : DefaultValue6
                        , MoveNext7 ? Enumerator7.Current : DefaultValue7
                        , MoveNext8 ? Enumerator8.Current : DefaultValue8
                        , MoveNext9 ? Enumerator9.Current : DefaultValue9
                        , MoveNext10 ? Enumerator10.Current : DefaultValue10
                        , MoveNext11 ? Enumerator11.Current : DefaultValue11
                        , MoveNext12 ? Enumerator12.Current : DefaultValue12
                        , MoveNext13 ? Enumerator13.Current : DefaultValue13
                        , MoveNext14 ? Enumerator14.Current : DefaultValue14
                        , MoveNext15 ? Enumerator15.Current : DefaultValue15
                        , MoveNext16 ? Enumerator16.Current : DefaultValue16
                        , MoveNext17 ? Enumerator17.Current : DefaultValue17
                        , MoveNext18 ? Enumerator18.Current : DefaultValue18
                        , MoveNext19 ? Enumerator19.Current : DefaultValue19
                        , MoveNext20 ? Enumerator20.Current : DefaultValue20);
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
            => (this.Item1, this.Item2, this.Item3, this.Item4, this.Item5, this.Item6, this.Item7, this.Item8, this.Item9, this.Item10, this.Item11, this.Item12, this.Item13, this.Item14, this.Item15, this.Item16, this.Item17, this.Item18, this.Item19, this.Item20, this.Item21, this.NotEnough)
            = (Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9, Item10, Item11, Item12, Item13, Item14, Item15, Item16, Item17, Item18, Item19, Item20, Item21, NotEnough);

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
            var DefaultValue1 = default(T1)!;
            var DefaultValue2 = default(T2)!;
            var DefaultValue3 = default(T3)!;
            var DefaultValue4 = default(T4)!;
            var DefaultValue5 = default(T5)!;
            var DefaultValue6 = default(T6)!;
            var DefaultValue7 = default(T7)!;
            var DefaultValue8 = default(T8)!;
            var DefaultValue9 = default(T9)!;
            var DefaultValue10 = default(T10)!;
            var DefaultValue11 = default(T11)!;
            var DefaultValue12 = default(T12)!;
            var DefaultValue13 = default(T13)!;
            var DefaultValue14 = default(T14)!;
            var DefaultValue15 = default(T15)!;
            var DefaultValue16 = default(T16)!;
            var DefaultValue17 = default(T17)!;
            var DefaultValue18 = default(T18)!;
            var DefaultValue19 = default(T19)!;
            var DefaultValue20 = default(T20)!;
            var DefaultValue21 = default(T21)!;	
            using (var Enumerator1 = Item1.GetEnumerator())
            using (var Enumerator2 = Item2.GetEnumerator())
            using (var Enumerator3 = Item3.GetEnumerator())
            using (var Enumerator4 = Item4.GetEnumerator())
            using (var Enumerator5 = Item5.GetEnumerator())
            using (var Enumerator6 = Item6.GetEnumerator())
            using (var Enumerator7 = Item7.GetEnumerator())
            using (var Enumerator8 = Item8.GetEnumerator())
            using (var Enumerator9 = Item9.GetEnumerator())
            using (var Enumerator10 = Item10.GetEnumerator())
            using (var Enumerator11 = Item11.GetEnumerator())
            using (var Enumerator12 = Item12.GetEnumerator())
            using (var Enumerator13 = Item13.GetEnumerator())
            using (var Enumerator14 = Item14.GetEnumerator())
            using (var Enumerator15 = Item15.GetEnumerator())
            using (var Enumerator16 = Item16.GetEnumerator())
            using (var Enumerator17 = Item17.GetEnumerator())
            using (var Enumerator18 = Item18.GetEnumerator())
            using (var Enumerator19 = Item19.GetEnumerator())
            using (var Enumerator20 = Item20.GetEnumerator())
            using (var Enumerator21 = Item21.GetEnumerator())
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
                    yield return (MoveNext1 ? Enumerator1.Current : DefaultValue1
                        , MoveNext2 ? Enumerator2.Current : DefaultValue2
                        , MoveNext3 ? Enumerator3.Current : DefaultValue3
                        , MoveNext4 ? Enumerator4.Current : DefaultValue4
                        , MoveNext5 ? Enumerator5.Current : DefaultValue5
                        , MoveNext6 ? Enumerator6.Current : DefaultValue6
                        , MoveNext7 ? Enumerator7.Current : DefaultValue7
                        , MoveNext8 ? Enumerator8.Current : DefaultValue8
                        , MoveNext9 ? Enumerator9.Current : DefaultValue9
                        , MoveNext10 ? Enumerator10.Current : DefaultValue10
                        , MoveNext11 ? Enumerator11.Current : DefaultValue11
                        , MoveNext12 ? Enumerator12.Current : DefaultValue12
                        , MoveNext13 ? Enumerator13.Current : DefaultValue13
                        , MoveNext14 ? Enumerator14.Current : DefaultValue14
                        , MoveNext15 ? Enumerator15.Current : DefaultValue15
                        , MoveNext16 ? Enumerator16.Current : DefaultValue16
                        , MoveNext17 ? Enumerator17.Current : DefaultValue17
                        , MoveNext18 ? Enumerator18.Current : DefaultValue18
                        , MoveNext19 ? Enumerator19.Current : DefaultValue19
                        , MoveNext20 ? Enumerator20.Current : DefaultValue20
                        , MoveNext21 ? Enumerator21.Current : DefaultValue21);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
