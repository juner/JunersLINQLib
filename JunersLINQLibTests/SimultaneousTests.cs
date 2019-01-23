using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Linq;

namespace Juners.Linq.Tests
{
    [TestClass]
    public class SimultaneousTests
    {
        /// <summary>
        /// 同じ型
        /// </summary>
        [TestMethod]
        public void ZipOrBreakTest1()
        {
            var Array1 = new[] { 1, 2, 3, 4};
            var Array2 = new[] { 5, 6, 7, 8, 9 };
            var ExpectArray3 = new[] { 6, 8, 10, 12 };
            Trace.WriteLine($"{nameof(ExpectArray3)}:{string.Join(", ", ExpectArray3)}");
            var Array3 = Array1.Zip(ZipNotEnough.Break, a => a[0] + a[1], Array2).ToArray();
            Trace.WriteLine($"{nameof(Array3)}:{string.Join(", ", Array3)}");
            CollectionAssert.AreEqual(ExpectArray3, Array3);
        }
        [TestMethod]
        public void ZipOrDefaultTest1()
        {
            var Array1 = new[] { 1, 2, 3, 4 };
            var Array2 = new[] { 5, 6, 7, 8, 9 };
            var ExpectArray3 = new[] { 6, 8, 10, 12, 9 };
            Trace.WriteLine($"{nameof(ExpectArray3)}:{string.Join(", ", ExpectArray3)}");
            var Array3 = Array1.Zip(ZipNotEnough.Default, a => a[0] + a[1], Array2).ToArray();
            Trace.WriteLine($"{nameof(Array3)}:{string.Join(", ", Array3)}");
            CollectionAssert.AreEqual(ExpectArray3, Array3);
        }
        [TestMethod]
        public void ZipOrBreakTest2()
        {
            var Array1 = new[] { 1, 2, 3, 4, 5 };
            var Array2 = new[] { "foo", "bar", "poo" };
            var ExpectArray3 = new[] { "1foo", "2bar", "3poo" };
            Trace.WriteLine($"{nameof(ExpectArray3)}:{string.Join(", ", ExpectArray3)}");
            var Array3 = Array1.Zip(Array2, (a1, a2) => $"{a1}{a2}").ToArray();
            Trace.WriteLine($"{nameof(Array3)}:{string.Join(", ", Array3)}");
            CollectionAssert.AreEqual(ExpectArray3, Array3);
        }
        [TestMethod]
        public void ZipOrDefaultTest2()
        {
            var Array1 = new[] { 1, 2, 3, 4, 5 };
            var Array2 = new[] { "foo", "bar", "poo" };
            var ExpectArray3 = new[] { "1foo", "2bar", "3poo", "4", "5" };
            Trace.WriteLine($"{nameof(ExpectArray3)}:{string.Join(", ", ExpectArray3)}");
            var Array3 = Array1.Zip(Array2, (a1, a2) => $"{a1}{a2}", ZipNotEnough.Default).ToArray();
            Trace.WriteLine($"{nameof(Array3)}:{string.Join(", ", Array3)}");
            CollectionAssert.AreEqual(ExpectArray3, Array3);
        }
    }
}
