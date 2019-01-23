using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static System.Linq.Enumerable;

namespace Juners.Linq.Tests
{
    [TestClass]
    public class NumberEnumerateExtensionsTests
    {
        public static string DynamicDataDisplayName(MethodInfo MethodInfo, object[] Parameters) => TestUtils.DynamicDataDisplayName(MethodInfo, Parameters);
        static IEnumerable<object[]> FigureTest1Data
        {
            get
            {
                yield return new object[]
                {
                    1,
                    10,
                    new int []{1 },
                };
                yield return new object[]
                {
                    0,
                    10,
                    new int []{0 },
                };
                yield return new object[]
                {
                    100,
                    10,
                    new int []{0,0,1 },
                };
                yield return new object[]
                {
                    100,
                    2,
                    new int []{0,0,1,0,0,1,1 },
                };
                yield return new object[]
                {
                    100,
                    8,
                    new int []{4,4,1},
                };
                yield return new object[]
                {
                    100,
                    16,
                    new int []{4, 6},
                };
            }
        }
        [TestMethod, DynamicData(nameof(FigureTest1Data), DynamicDataDisplayName = nameof(DynamicDataDisplayName))]
        public void FigureTest1(int Number, int Figure, IEnumerable<int> ExpectResults)
        {
            Trace.WriteLine($"{nameof(ExpectResults)}:{ExpectResults.ToJoinString(", ")}");
            var Results = Number.Figure(Figure);
            Trace.WriteLine($"{nameof(Results)}:{Results.ToJoinString(", ")}");
            CollectionAssert.AreEqual(ExpectResults.ToArray(), Results.ToArray());
        }
        static IEnumerable<object[]> FigureTest2Data
        {
            get
            {
                yield return new object[]
                {
                    1u,
                    10u,
                    new uint []{1 },
                };
                yield return new object[]
                {
                    0u,
                    10u,
                    new uint []{0 },
                };
                yield return new object[]
                {
                    100u,
                    10u,
                    new uint []{0,0,1 },
                };
                yield return new object[]
                {
                    100u,
                    2u,
                    new uint []{0,0,1,0,0,1,1 },
                };
                yield return new object[]
                {
                    100u,
                    8u,
                    new uint []{4,4,1},
                };
                yield return new object[]
                {
                    100u,
                    16u,
                    new uint []{4, 6},
                };
            }
        }
        [TestMethod, DynamicData(nameof(FigureTest2Data), DynamicDataDisplayName = nameof(DynamicDataDisplayName))]
        public void FigureTest2(uint Number, uint Figure, IEnumerable<uint> ExpectResults)
        {
            Trace.WriteLine($"{nameof(ExpectResults)}:{ExpectResults.ToJoinString(", ")}");
            var Results = Number.Figure(Figure);
            Trace.WriteLine($"{nameof(Results)}:{Results.ToJoinString(", ")}");
            CollectionAssert.AreEqual(ExpectResults.ToArray(), Results.ToArray());
        }
        static IEnumerable<object[]> FigureTest3Data
        {
            get
            {
                yield return new object[]
                {
                    1L,
                    10L,
                    new long []{1 },
                };
                yield return new object[]
                {
                    0L,
                    10L,
                    new long []{0 },
                };
                yield return new object[]
                {
                    100L,
                    10L,
                    new long []{0,0,1 },
                };
                yield return new object[]
                {
                    100L,
                    2L,
                    new long []{0,0,1,0,0,1,1 },
                };
                yield return new object[]
                {
                    100L,
                    8L,
                    new long []{4,4,1},
                };
                yield return new object[]
                {
                    100L,
                    16L,
                    new long []{4, 6},
                };
            }
        }
        [TestMethod, DynamicData(nameof(FigureTest3Data), DynamicDataDisplayName = nameof(DynamicDataDisplayName))]
        public void FigureTest3(long Number, long Figure, IEnumerable<long> ExpectResults)
        {
            Trace.WriteLine($"{nameof(ExpectResults)}:{ExpectResults.ToJoinString(", ")}");
            var Results = Number.Figure(Figure);
            Trace.WriteLine($"{nameof(Results)}:{Results.ToJoinString(", ")}");
            CollectionAssert.AreEqual(ExpectResults.ToArray(), Results.ToArray());
        }
        static IEnumerable<object[]> FigureTest4Data
        {
            get
            {
                yield return new object[]
                {
                    1uL,
                    10uL,
                    new ulong []{1 },
                };
                yield return new object[]
                {
                    0uL,
                    10uL,
                    new ulong []{0 },
                };
                yield return new object[]
                {
                    100uL,
                    10uL,
                    new ulong []{0,0,1 },
                };
                yield return new object[]
                {
                    100uL,
                    2uL,
                    new ulong []{0,0,1,0,0,1,1 },
                };
                yield return new object[]
                {
                    100uL,
                    8uL,
                    new ulong []{4,4,1},
                };
                yield return new object[]
                {
                    100uL,
                    16uL,
                    new ulong []{4, 6},
                };
            }
        }
        [TestMethod, DynamicData(nameof(FigureTest4Data), DynamicDataDisplayName = nameof(DynamicDataDisplayName))]
        public void FigureTest4(ulong Number, ulong Figure, IEnumerable<ulong> ExpectResults)
        {
            Trace.WriteLine($"{nameof(ExpectResults)}:{ExpectResults.ToJoinString(", ")}");
            var Results = Number.Figure(Figure);
            Trace.WriteLine($"{nameof(Results)}:{Results.ToJoinString(", ")}");
            CollectionAssert.AreEqual(ExpectResults.ToArray(), Results.ToArray());
        }
        static IEnumerable<object[]> FigureTest5Data
        {
            get
            {
                yield return new object[]
                {
                    1m,
                    10m,
                    new decimal []{1 },
                };
                yield return new object[]
                {
                    0m,
                    10m,
                    new decimal []{0 },
                };
                yield return new object[]
                {
                    100m,
                    10m,
                    new decimal []{0,0,1 },
                };
                yield return new object[]
                {
                    100m,
                    2m,
                    new decimal []{0,0,1,0,0,1,1 },
                };
                yield return new object[]
                {
                    100m,
                    8m,
                    new decimal []{4,4,1},
                };
                yield return new object[]
                {
                    100m,
                    16m,
                    new decimal []{4, 6},
                };
            }
        }
        [TestMethod, DynamicData(nameof(FigureTest5Data), DynamicDataDisplayName = nameof(DynamicDataDisplayName))]
        public void FigureTest5(decimal Number, decimal Figure, IEnumerable<decimal> ExpectResults)
        {
            Trace.WriteLine($"{nameof(ExpectResults)}:{ExpectResults.ToJoinString(", ")}");
            var Results = Number.Figure(Figure);
            Trace.WriteLine($"{nameof(Results)}:{Results.ToJoinString(", ")}");
            CollectionAssert.AreEqual(ExpectResults.ToArray(), Results.ToArray());
        }
    }
}
