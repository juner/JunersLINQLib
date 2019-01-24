using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Linq;

namespace Juners.Linq.Tests
{
    [TestClass]
    public class ZipTests
    {
        /// <summary>
        /// 同じ型
        /// </summary>
        [TestMethod, TestCategory("ShortTime")]
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
        [TestMethod, TestCategory("ShortTime")]
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
        [TestMethod, TestCategory("ShortTime")]
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
        [TestMethod, TestCategory("ShortTime")]
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
        [TestMethod]
        public void ZipOrBreakTest3()
        {
            var Array1 = new[] { 1, 2, 3, 4, 5 };
            var Array2 = new[] { "foo", "bar", "poo" };
            var Array3 = new[] { 1, 2, 3, 4 };
            var ExpectResult = new[] { "1foo1", "2bar2", "3poo3" };
            Trace.WriteLine($"{nameof(ExpectResult)}:{string.Join(", ", ExpectResult)}");
            var Result = Array1.Zip(Array2, Array3, (a1, a2, a3) => $"{a1}{a2}{a3}").ToArray();
            Trace.WriteLine($"{nameof(Result)}:{string.Join(", ", Result)}");
            CollectionAssert.AreEqual(ExpectResult, Result);
        }
        [TestMethod]
        public void ZipOrDefaultTest3()
        {
            var Array1 = new[] { 1, 2, 3, 4, 5 };
            var Array2 = new[] { "foo", "bar", "poo" };
            var Array3 = new int?[] { 1, 2, 3, 4 };
            var ExpectResult = new[] { "1foo1", "2bar2", "3poo3", "44", "5" };
            Trace.WriteLine($"{nameof(ExpectResult)}:{string.Join(", ", ExpectResult)}");
            var Result = Array1.Zip(Array2, Array3, (a1, a2, a3) => $"{a1}{a2}{a3}", ZipNotEnough.Default).ToArray();
            Trace.WriteLine($"{nameof(Result)}:{string.Join(", ", Result)}");
            CollectionAssert.AreEqual(ExpectResult, Result);
        }
        [TestMethod]
        public void ZipOrBreakTest4()
        {
            var Array1 = new[] { 1, 2, 3, 4, 5 };
            var Array2 = new[] { "foo", "bar", "poo" };
            var Array3 = new int?[] { 1, 2, 3, 4 };
            var Array4 = new[] { 1.1, 2.2, 3.3, 4.4 };
            var ExpectResult = new[] { "1foo11.1", "2bar22.2", "3poo33.3" };
            Trace.WriteLine($"{nameof(ExpectResult)}:{string.Join(", ", ExpectResult)}");
            var Result = Array1.Zip(Array2, Array3, Array4, (a1, a2, a3, a4) => $"{a1}{a2}{a3}{a4}").ToArray();
            Trace.WriteLine($"{nameof(Result)}:{string.Join(", ", Result)}");
            CollectionAssert.AreEqual(ExpectResult, Result);
        }
        [TestMethod]
        public void ZipOrDefaultTest4()
        {
            var Array1 = new[] { 1, 2, 3, 4, 5 };
            var Array2 = new[] { "foo", "bar", "poo" };
            var Array3 = new int?[] { 1, 2, 3, 4 };
            var Array4 = new[] { 1.1, 2.2, 3.3, 4.4 };
            var ExpectResult = new[] { "1foo11.1", "2bar22.2", "3poo33.3", "444.4", "50" };
            Trace.WriteLine($"{nameof(ExpectResult)}:{string.Join(", ", ExpectResult)}");
            var Result = Array1.Zip(Array2, Array3, Array4, (a1, a2, a3, a4) => $"{a1}{a2}{a3}{a4}", ZipNotEnough.Default).ToArray();
            Trace.WriteLine($"{nameof(Result)}:{string.Join(", ", Result)}");
            CollectionAssert.AreEqual(ExpectResult, Result);
        }
        [TestMethod]
        public void ZipOrBreakTest5()
        {
            var Array1 = new[] { 1, 2, 3, 4, 5 };
            var Array2 = new[] { "foo", "bar", "poo" };
            var Array3 = new int?[] { 1, 2, 3, 4 };
            var Array4 = new[] { 1.1, 2.2, 3.3, 4.4 };
            var Array5 = new[] { 'c', 'b', 'd', 'a', 'z', 'q' };
            var ExpectResult = new[] { "1foo11.1c", "2bar22.2b", "3poo33.3d" };
            Trace.WriteLine($"{nameof(ExpectResult)}:{string.Join(", ", ExpectResult)}");
            var Result = Array1.Zip(Array2, Array3, Array4, Array5, (a1, a2, a3, a4, a5) => $"{a1}{a2}{a3}{a4}{a5}").ToArray();
            Trace.WriteLine($"{nameof(Result)}:{string.Join(", ", Result)}");
            CollectionAssert.AreEqual(ExpectResult, Result);
        }
        [TestMethod]
        public void ZipOrDefaultTest5()
        {
            var Array1 = new[] { 1, 2, 3, 4, 5 };
            var Array2 = new[] { "foo", "bar", "poo" };
            var Array3 = new int?[] { 1, 2, 3, 4 };
            var Array4 = new[] { 1.1, 2.2, 3.3, 4.4 };
            var Array5 = new[] { 'c', 'b', 'd', 'a', 'z', 'q' };
            var ExpectResult = new[] { "1foo11.1c", "2bar22.2b", "3poo33.3d", "444.4a", "50z", "00q" };
            Trace.WriteLine($"{nameof(ExpectResult)}:{string.Join(", ", ExpectResult)}");
            var Result = Array1.Zip(Array2, Array3, Array4, Array5, (a1, a2, a3, a4, a5) => $"{a1}{a2}{a3}{a4}{a5}", ZipNotEnough.Default).ToArray();
            Trace.WriteLine($"{nameof(Result)}:{string.Join(", ", Result)}");
            CollectionAssert.AreEqual(ExpectResult, Result);
        }
    }
}
