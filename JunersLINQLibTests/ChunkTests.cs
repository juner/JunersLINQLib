using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Juners.Linq.Tests
{
    [TestClass]
    public class ChunkTests
    {
        [TestMethod]
        public void ChunkTest()
        {
            var Array1 = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            var ExpectArray2 = new[] { new[] { 1, 2 }, new[] { 3, 4 }, new[] { 5, 6 }, new[] { 7, 8 }, new[] { 9 } };
            Trace.WriteLine($"{nameof(ExpectArray2)}:[{string.Join(", ", ExpectArray2.Select(v => $"[{string.Join(", ",v)}]"))}]");
            var Array2 = Array1.Chunk(2).ToArray();
            Trace.WriteLine($"{nameof(Array2)}:[{string.Join(", ", Array2.Select(v => $"[{string.Join(", ", v)}]"))}]");
            Assert.AreEqual($"[{string.Join(", ", ExpectArray2.Select(v => $"[{string.Join(", ", v)}]"))}]", $"[{string.Join(", ", Array2.Select(v => $"[{string.Join(", ", v)}]"))}]");
            var ExpectArray3 = new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } };
            Trace.WriteLine($"{nameof(ExpectArray3)}:[{string.Join(", ", ExpectArray3.Select(v => $"[{string.Join(", ", v)}]"))}]");
            var Array3 = Array1.Chunk(3).ToArray();
            Trace.WriteLine($"{nameof(Array3)}:[{string.Join(", ", Array3.Select(v => $"[{string.Join(", ", v)}]"))}]");
            Assert.AreEqual($"[{string.Join(", ", ExpectArray3.Select(v => $"[{string.Join(", ", v)}]"))}]", $"[{string.Join(", ", Array3.Select(v => $"[{string.Join(", ", v)}]"))}]");

        }
    }
}
