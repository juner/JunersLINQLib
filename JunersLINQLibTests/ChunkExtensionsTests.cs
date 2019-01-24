using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Juners.Linq.Tests {
    [TestClass]
    public class ChunkExtensionsTests {
        [TestMethod,TestCategory("ShortTime")]
        public void ChunkTest()
        {
            var Array1 = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            var ExpectArray2 = new[] { new[] { 1, 2 }, new[] { 3, 4 }, new[] { 5, 6 }, new[] { 7, 8 }, new[] { 9 } };
            Trace.WriteLine($"{nameof(ExpectArray2)}:[{string.Join(", ", ExpectArray2.Select(v => $"[{string.Join(", ", v)}]"))}]");
            var Array2 = Array1.Chunk(2).ToArray();
            Trace.WriteLine($"{nameof(Array2)}:[{string.Join(", ", Array2.Select(v => $"[{string.Join(", ", v)}]"))}]");
            Assert.AreEqual($"[{string.Join(", ", ExpectArray2.Select(v => $"[{string.Join(", ", v)}]"))}]", $"[{string.Join(", ", Array2.Select(v => $"[{string.Join(", ", v)}]"))}]");
            var ExpectArray3 = new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } };
            Trace.WriteLine($"{nameof(ExpectArray3)}:[{string.Join(", ", ExpectArray3.Select(v => $"[{string.Join(", ", v)}]"))}]");
            var Array3 = Array1.Chunk(3).ToArray();
            Trace.WriteLine($"{nameof(Array3)}:[{string.Join(", ", Array3.Select(v => $"[{string.Join(", ", v)}]"))}]");
            Assert.AreEqual($"[{string.Join(", ", ExpectArray3.Select(v => $"[{string.Join(", ", v)}]"))}]", $"[{string.Join(", ", Array3.Select(v => $"[{string.Join(", ", v)}]"))}]");
            var ExpectArray4 = new[] { new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, }};
            Trace.WriteLine($"{nameof(ExpectArray4)}:[{string.Join(", ", ExpectArray4.Select(v => $"[{string.Join(", ", v)}]"))}]");
            var Array4 = Array1.Chunk(10).ToArray();
            Trace.WriteLine($"{nameof(Array4)}:[{string.Join(", ", Array4.Select(v => $"[{string.Join(", ", v)}]"))}]");
            Assert.AreEqual($"[{string.Join(", ", ExpectArray4.Select(v => $"[{string.Join(", ", v)}]"))}]", $"[{string.Join(", ", Array4.Select(v => $"[{string.Join(", ", v)}]"))}]");
        }
        [TestMethod,TestCategory("LongTime")]
        public async Task ChunkLongSupportTest()
        {
            await Task.Run(() => {
                var LongArray1 = Enumerable.Range(0, int.MaxValue).Loop().Take(int.MaxValue + 1L);
                foreach (var value in LongArray1.Chunk(10).Select(v => v.ToArray()))
                    ;
            });
            ;
        }
    }
}
