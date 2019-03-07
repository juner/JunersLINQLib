using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Juners.Linq.Tests {
    [TestClass]
    public class CrossJoinTests {
        static IEnumerable<object[]> CrossJoinTupleTestData {
            get {
                yield return new object[] {
                    new int[]{ 1, 2, 3},
                    new string[] { "一", "二", "三" },
                    new (int,string)[] {
                        (1, "一"),
                        (1, "二"),
                        (1, "三"),
                        (2, "一"),
                        (2, "二"),
                        (2, "三"),
                        (3, "一"),
                        (3, "二"),
                        (3, "三"),
                    },
                };
            }
        }
        [TestMethod, TestCategory("ShortTime"), DynamicData(nameof(CrossJoinTupleTestData))]
        public void CrossJoinTupleTest(IEnumerable<int> Item1, IEnumerable<string> Item2, IEnumerable<(int, string)> ExpectResult)
        {
            Trace.WriteLine($"{nameof(Item1)}:[{string.Join(", ", Item1)}]");
            Trace.WriteLine($"{nameof(Item2)}:[{string.Join(", ", Item2)}]");
            Trace.WriteLine($"{nameof(ExpectResult)}:[{string.Join(", ", ExpectResult)}]");
            var Result = Item1.CrossJoin(Item2).ToList();
            Trace.WriteLine($"{nameof(Result)}:[{string.Join(", ", Result)}]");
            CollectionAssert.AreEqual(ExpectResult.ToList(), Result);
        }
        [TestMethod, TestCategory("ShortTime"), DynamicData(nameof(CrossJoinTupleTestData))]
        public void CrossJoinTest(IEnumerable<int> Item1, IEnumerable<string> Item2, IEnumerable<(int, string)> ExpectResult)
        {
            Trace.WriteLine($"{nameof(Item1)}:[{string.Join(", ", Item1)}]");
            Trace.WriteLine($"{nameof(Item2)}:[{string.Join(", ", Item2)}]");
            Trace.WriteLine($"{nameof(ExpectResult)}:[{string.Join(", ", ExpectResult)}]");
            var Result = Item1.CrossJoin(Item2, (i1, i2) => (i1, i2)).ToList();
            Trace.WriteLine($"{nameof(Result)}:[{string.Join(", ", Result)}]");
            CollectionAssert.AreEqual(ExpectResult.ToList(), Result);
        }
        static IEnumerable<object[]> CrossJoinTupleTest2Data {
            get {
                yield return new object[] {
                    new int[]{ 1, 2, 3},
                    new string[] { "一", "二", "三" },
                    new double[] { 1d, 2.5d },
                    new (int,string, double)[] {
                        (1, "一", 1d),
                        (1, "一", 2.5d),
                        (1, "二", 1d),
                        (1, "二", 2.5d),
                        (1, "三", 1d),
                        (1, "三", 2.5d),
                        (2, "一", 1d),
                        (2, "一", 2.5d),
                        (2, "二", 1d),
                        (2, "二", 2.5d),
                        (2, "三", 1d),
                        (2, "三", 2.5d),
                        (3, "一", 1d),
                        (3, "一", 2.5d),
                        (3, "二", 1d),
                        (3, "二", 2.5d),
                        (3, "三", 1d),
                        (3, "三", 2.5d),
                    },
                };
            }
        }
        [TestMethod, TestCategory("ShortTime"), DynamicData(nameof(CrossJoinTupleTest2Data))]
        public void CrossJoinTupleTest2(IEnumerable<int> Item1, IEnumerable<string> Item2, IEnumerable<double> Item3, IEnumerable<(int, string, double)> ExpectResult)
        {
            Trace.WriteLine($"{nameof(Item1)}:[{string.Join(", ", Item1)}]");
            Trace.WriteLine($"{nameof(Item2)}:[{string.Join(", ", Item2)}]");
            Trace.WriteLine($"{nameof(Item3)}:[{string.Join(", ", Item3)}]");
            Trace.WriteLine($"{nameof(ExpectResult)}:[{string.Join(", ", ExpectResult)}]");
            var Result = Item1.CrossJoin(Item2, Item3).ToList();
            Trace.WriteLine($"{nameof(Result)}:[{string.Join(", ", Result)}]");
            CollectionAssert.AreEqual(ExpectResult.ToList(), Result);
        }
        [TestMethod, TestCategory("ShortTime"), DynamicData(nameof(CrossJoinTupleTest2Data))]
        public void CrossJoinTest2(IEnumerable<int> Item1, IEnumerable<string> Item2, IEnumerable<double> Item3, IEnumerable<(int, string, double)> ExpectResult)
        {
            Trace.WriteLine($"{nameof(Item1)}:[{string.Join(", ", Item1)}]");
            Trace.WriteLine($"{nameof(Item2)}:[{string.Join(", ", Item2)}]");
            Trace.WriteLine($"{nameof(Item3)}:[{string.Join(", ", Item3)}]");
            Trace.WriteLine($"{nameof(ExpectResult)}:[{string.Join(", ", ExpectResult)}]");
            var Result = Item1.CrossJoin(Item2, Item3, (i1, i2, i3) => (i1, i2, i3)).ToList();
            Trace.WriteLine($"{nameof(Result)}:[{string.Join(", ", Result)}]");
            CollectionAssert.AreEqual(ExpectResult.ToList(), Result);
        }
    }
}
