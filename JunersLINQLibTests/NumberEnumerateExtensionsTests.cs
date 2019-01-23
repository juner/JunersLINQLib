using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static System.Linq.Enumerable;

namespace Juners.Linq.Tests {
    [TestClass]
    public class NumberEnumerateExtensionsTests {
        public static string DynamicDataDisplayName(MethodInfo MethodInfo, object[] Parameters) => TestUtils.DynamicDataDisplayName(MethodInfo, Parameters);
        static IEnumerable<object[]> FigureTestInt32Data {
            get {
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
        [TestMethod, DynamicData(nameof(FigureTestInt32Data), DynamicDataDisplayName = nameof(DynamicDataDisplayName))]
        public void FigureTestInt32(int Number, int Figure, IEnumerable<int> ExpectResults)
        {
            Trace.WriteLine($"{nameof(ExpectResults)}:{ExpectResults.ToJoinString(", ")}");
            var Results = Number.Figure(Figure);
            Trace.WriteLine($"{nameof(Results)}:{Results.ToJoinString(", ")}");
            CollectionAssert.AreEqual(ExpectResults.ToArray(), Results.ToArray());
        }
        static IEnumerable<object[]> FigureTestUInt32Data {
            get {
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
        [TestMethod, DynamicData(nameof(FigureTestUInt32Data), DynamicDataDisplayName = nameof(DynamicDataDisplayName))]
        public void FigureTestUInt32(uint Number, uint Figure, IEnumerable<uint> ExpectResults)
        {
            Trace.WriteLine($"{nameof(ExpectResults)}:{ExpectResults.ToJoinString(", ")}");
            var Results = Number.Figure(Figure);
            Trace.WriteLine($"{nameof(Results)}:{Results.ToJoinString(", ")}");
            CollectionAssert.AreEqual(ExpectResults.ToArray(), Results.ToArray());
        }
        static IEnumerable<object[]> FigureTestInt64Data {
            get {
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
        [TestMethod, DynamicData(nameof(FigureTestInt64Data), DynamicDataDisplayName = nameof(DynamicDataDisplayName))]
        public void FigureTestInt64(long Number, long Figure, IEnumerable<long> ExpectResults)
        {
            Trace.WriteLine($"{nameof(ExpectResults)}:{ExpectResults.ToJoinString(", ")}");
            var Results = Number.Figure(Figure);
            Trace.WriteLine($"{nameof(Results)}:{Results.ToJoinString(", ")}");
            CollectionAssert.AreEqual(ExpectResults.ToArray(), Results.ToArray());
        }
        static IEnumerable<object[]> FigureTestUInt64Data {
            get {
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
        [TestMethod, DynamicData(nameof(FigureTestUInt64Data), DynamicDataDisplayName = nameof(DynamicDataDisplayName))]
        public void FigureTestUInt64(ulong Number, ulong Figure, IEnumerable<ulong> ExpectResults)
        {
            Trace.WriteLine($"{nameof(ExpectResults)}:{ExpectResults.ToJoinString(", ")}");
            var Results = Number.Figure(Figure);
            Trace.WriteLine($"{nameof(Results)}:{Results.ToJoinString(", ")}");
            CollectionAssert.AreEqual(ExpectResults.ToArray(), Results.ToArray());
        }
        static IEnumerable<object[]> FigureTestDecimalData {
            get {
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
        [TestMethod, DynamicData(nameof(FigureTestDecimalData), DynamicDataDisplayName = nameof(DynamicDataDisplayName))]
        public void FigureTestDecimal(decimal Number, decimal Figure, IEnumerable<decimal> ExpectResults)
        {
            Trace.WriteLine($"{nameof(ExpectResults)}:{ExpectResults.ToJoinString(", ")}");
            var Results = Number.Figure(Figure);
            Trace.WriteLine($"{nameof(Results)}:{Results.ToJoinString(", ")}");
            CollectionAssert.AreEqual(ExpectResults.ToArray(), Results.ToArray());
        }
        static IEnumerable<object[]> FigureTestByteData {
            get {
                yield return new object[]
                {
                    (byte)1,
                    (byte)10,
                    new byte []{1 },
                };
                yield return new object[]
                {
                    (byte)0,
                    (byte)10,
                    new byte []{0 },
                };
                yield return new object[]
                {
                    (byte)100,
                    (byte)10,
                    new byte []{0,0,1 },
                };
                yield return new object[]
                {
                    (byte)100,
                    (byte)2,
                    new byte []{0,0,1,0,0,1,1 },
                };
                yield return new object[]
                {
                    (byte)100,
                    (byte)8,
                    new byte []{4,4,1},
                };
                yield return new object[]
                {
                    (byte)100,
                    (byte)16,
                    new byte []{4, 6},
                };
            }
        }
        [TestMethod, DynamicData(nameof(FigureTestByteData), DynamicDataDisplayName = nameof(DynamicDataDisplayName))]
        public void FigureTestByte(byte Number, byte Figure, IEnumerable<byte> ExpectResults)
        {
            Trace.WriteLine($"{nameof(ExpectResults)}:{ExpectResults.ToJoinString(", ")}");
            var Results = Number.Figure(Figure);
            Trace.WriteLine($"{nameof(Results)}:{Results.ToJoinString(", ")}");
            CollectionAssert.AreEqual(ExpectResults.ToArray(), Results.ToArray());
        }
        static IEnumerable<object[]> FigureTestSByteData {
            get {
                yield return new object[]
                {
                    (sbyte)1,
                    (sbyte)10,
                    new sbyte []{1 },
                };
                yield return new object[]
                {
                    (sbyte)0,
                    (sbyte)10,
                    new sbyte []{0 },
                };
                yield return new object[]
                {
                    (sbyte)100,
                    (sbyte)10,
                    new sbyte []{0,0,1 },
                };
                yield return new object[]
                {
                    (sbyte)100,
                    (sbyte)2,
                    new sbyte []{0,0,1,0,0,1,1 },
                };
                yield return new object[]
                {
                    (sbyte)100,
                    (sbyte)8,
                    new sbyte []{4,4,1},
                };
                yield return new object[]
                {
                    (sbyte)100,
                    (sbyte)16,
                    new sbyte []{4, 6},
                };
            }
        }
        [TestMethod, DynamicData(nameof(FigureTestSByteData), DynamicDataDisplayName = nameof(DynamicDataDisplayName))]
        public void FigureTestSByte(sbyte Number, sbyte Figure, IEnumerable<sbyte> ExpectResults)
        {
            Trace.WriteLine($"{nameof(ExpectResults)}:{ExpectResults.ToJoinString(", ")}");
            var Results = Number.Figure(Figure);
            Trace.WriteLine($"{nameof(Results)}:{Results.ToJoinString(", ")}");
            CollectionAssert.AreEqual(ExpectResults.ToArray(), Results.ToArray());
        }
        static IEnumerable<object[]> FigureTestCharData {
            get {
                yield return new object[]
                {
                    (char)1,
                    (char)10,
                    new char []{(char)1 },
                };
                yield return new object[]
                {
                    (char)0,
                    (char)10,
                    new char []{ (char)0 },
                };
                yield return new object[]
                {
                    (char)100,
                    (char)10,
                    new char []{ (char)0, (char)0, (char)1 },
                };
                yield return new object[]
                {
                    (char)100,
                    (char)2,
                    new char []{ (char)0, (char)0, (char)1, (char)0, (char)0, (char)1, (char)1 },
                };
                yield return new object[]
                {
                    (char)100,
                    (char)8,
                    new char []{ (char)4, (char)4, (char)1 },
                };
                yield return new object[]
                {
                    (char)100,
                    (char)16,
                    new char []{ (char)4, (char)6 },
                };
            }
        }
        [TestMethod, DynamicData(nameof(FigureTestCharData), DynamicDataDisplayName = nameof(DynamicDataDisplayName))]
        public void FigureTestChar(char Number, char Figure, IEnumerable<char> ExpectResults)
        {
            Trace.WriteLine($"{nameof(ExpectResults)}:{ExpectResults.ToJoinString(", ")}");
            var Results = Number.Figure(Figure);
            Trace.WriteLine($"{nameof(Results)}:{Results.ToJoinString(", ")}");
            CollectionAssert.AreEqual(ExpectResults.ToArray(), Results.ToArray());
        }
        static IEnumerable<object[]> FigureTestInt16Data {
            get {
                yield return new object[]
                {
                    (short)1,
                    (short)10,
                    new short []{1 },
                };
                yield return new object[]
                {
                    (short)0,
                    (short)10,
                    new short []{0 },
                };
                yield return new object[]
                {
                    (short)100,
                    (short)10,
                    new short []{0,0,1 },
                };
                yield return new object[]
                {
                    (short)100,
                    (short)2,
                    new short []{0,0,1,0,0,1,1 },
                };
                yield return new object[]
                {
                    (short)100,
                    (short)8,
                    new short []{4,4,1},
                };
                yield return new object[]
                {
                    (short)100,
                    (short)16,
                    new short []{4, 6},
                };
            }
        }
        [TestMethod, DynamicData(nameof(FigureTestInt16Data), DynamicDataDisplayName = nameof(DynamicDataDisplayName))]
        public void FigureTestInt16(short Number, short Figure, IEnumerable<short> ExpectResults)
        {
            Trace.WriteLine($"{nameof(ExpectResults)}:{ExpectResults.ToJoinString(", ")}");
            var Results = Number.Figure(Figure);
            Trace.WriteLine($"{nameof(Results)}:{Results.ToJoinString(", ")}");
            CollectionAssert.AreEqual(ExpectResults.ToArray(), Results.ToArray());
        }
        static IEnumerable<object[]> FigureTestUInt16Data {
            get {
                yield return new object[]
                {
                    (ushort)1,
                    (ushort)10,
                    new ushort []{1 },
                };
                yield return new object[]
                {
                    (ushort)0,
                    (ushort)10,
                    new ushort []{0 },
                };
                yield return new object[]
                {
                    (ushort)100,
                    (ushort)10,
                    new ushort []{0,0,1 },
                };
                yield return new object[]
                {
                    (ushort)100,
                    (ushort)2,
                    new ushort []{0,0,1,0,0,1,1 },
                };
                yield return new object[]
                {
                    (ushort)100,
                    (ushort)8,
                    new ushort []{4,4,1},
                };
                yield return new object[]
                {
                    (ushort)100,
                    (ushort)16,
                    new ushort []{4, 6},
                };
            }
        }
        [TestMethod, DynamicData(nameof(FigureTestUInt16Data), DynamicDataDisplayName = nameof(DynamicDataDisplayName))]
        public void FigureTestUInt16(ushort Number, ushort Figure, IEnumerable<ushort> ExpectResults)
        {
            Trace.WriteLine($"{nameof(ExpectResults)}:{ExpectResults.ToJoinString(", ")}");
            var Results = Number.Figure(Figure);
            Trace.WriteLine($"{nameof(Results)}:{Results.ToJoinString(", ")}");
            CollectionAssert.AreEqual(ExpectResults.ToArray(), Results.ToArray());
        }
        static IEnumerable<object[]> FigureTestDoubleData {
            get {
                yield return new object[]
                {
                    1d,
                    10d,
                    new double []{1 },
                };
                yield return new object[]
                {
                    0d,
                    10d,
                    new double []{0 },
                };
                yield return new object[]
                {
                    100d,
                    10d,
                    new double []{0,0,1 },
                };
                yield return new object[]
                {
                    100d,
                    2d,
                    new double []{0,0,1,0,0,1,1 },
                };
                yield return new object[]
                {
                    100d,
                    8d,
                    new double []{4,4,1},
                };
                yield return new object[]
                {
                    100d,
                    16d,
                    new double []{4, 6},
                };
            }
        }
        [TestMethod, DynamicData(nameof(FigureTestDoubleData), DynamicDataDisplayName = nameof(DynamicDataDisplayName))]
        public void FigureTestDouble(double Number, double Figure, IEnumerable<double> ExpectResults)
        {
            Trace.WriteLine($"{nameof(ExpectResults)}:{ExpectResults.ToJoinString(", ")}");
            var Results = Number.Figure(Figure);
            Trace.WriteLine($"{nameof(Results)}:{Results.ToJoinString(", ")}");
            CollectionAssert.AreEqual(ExpectResults.ToArray(), Results.ToArray());
        }
        static IEnumerable<object[]> FigureTestSingleData {
            get {
                yield return new object[]
                {
                    1f,
                    10f,
                    new float []{1 },
                };
                yield return new object[]
                {
                    0f,
                    10f,
                    new float []{0 },
                };
                yield return new object[]
                {
                    100f,
                    10f,
                    new float []{0,0,1 },
                };
                yield return new object[]
                {
                    100f,
                    2f,
                    new float []{0,0,1,0,0,1,1 },
                };
                yield return new object[]
                {
                    100f,
                    8f,
                    new float []{4,4,1},
                };
                yield return new object[]
                {
                    100f,
                    16f,
                    new float []{4, 6},
                };
            }
        }
        [TestMethod, DynamicData(nameof(FigureTestSingleData), DynamicDataDisplayName = nameof(DynamicDataDisplayName))]
        public void FigureTestSingle(float Number, float Figure, IEnumerable<float> ExpectResults)
        {
            Trace.WriteLine($"{nameof(ExpectResults)}:{ExpectResults.ToJoinString(", ")}");
            var Results = Number.Figure(Figure);
            Trace.WriteLine($"{nameof(Results)}:{Results.ToJoinString(", ")}");
            CollectionAssert.AreEqual(ExpectResults.ToArray(), Results.ToArray());
        }
        static IEnumerable<object[]> FigureTestBigIntegerData {
            get {
                yield return new object[]
                {
                    (BigInteger)1,
                    (BigInteger)10,
                    new BigInteger []{1 },
                };
                yield return new object[]
                {
                    (BigInteger)0,
                    (BigInteger)10,
                    new BigInteger []{0 },
                };
                yield return new object[]
                {
                    (BigInteger)100,
                    (BigInteger)10,
                    new BigInteger []{0,0,1 },
                };
                yield return new object[]
                {
                    (BigInteger)100,
                    (BigInteger)2,
                    new BigInteger []{0,0,1,0,0,1,1 },
                };
                yield return new object[]
                {
                    (BigInteger)100,
                    (BigInteger)8,
                    new BigInteger []{4,4,1},
                };
                yield return new object[]
                {
                    (BigInteger)100,
                    (BigInteger)16,
                    new BigInteger []{4, 6},
                };
            }
        }
        [TestMethod, DynamicData(nameof(FigureTestBigIntegerData), DynamicDataDisplayName = nameof(DynamicDataDisplayName))]
        public void FigureTestBigInteger(BigInteger Number, BigInteger Figure, IEnumerable<BigInteger> ExpectResults)
        {
            Trace.WriteLine($"{nameof(ExpectResults)}:{ExpectResults.ToJoinString(", ")}");
            var Results = Number.Figure(Figure);
            Trace.WriteLine($"{nameof(Results)}:{Results.ToJoinString(", ")}");
            CollectionAssert.AreEqual(ExpectResults.ToArray(), Results.ToArray());
        }
    }
}
