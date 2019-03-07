using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Juners.Linq.Internal.Tests {
    [TestClass]
    public class DisposableTests {
        [TestMethod, TestCategory("ShortTime")]
        public void DisposeTest()
        {
            var Flag = false;
            var disposable = Disposable.Create(() => Flag = true);
            Trace.WriteLine($"prev dispose: {disposable}");
            disposable.Dispose();
            Trace.WriteLine($"dispose after: {disposable}");
            Assert.IsTrue(Flag, "DisposeしてもActionが呼ばれませんでした。");
        }
        [TestMethod, TestCategory("ShortTime")]
        public void DisposeTest2()
        {
            var FlagCount = 0;
            var disposable = Disposable.Create(() => FlagCount++);
            Trace.WriteLine($"prev dispose: {disposable}");
            disposable.Dispose();
            Trace.WriteLine($"dispose after 1: {disposable}");
            disposable.Dispose();
            Trace.WriteLine($"dispose after 2: {disposable}");
            Assert.AreNotEqual(0, FlagCount, "DisposeしてもActionが呼ばれませんでした。");
            Assert.AreEqual(1, FlagCount, "複数回Disposeした際に複数回Actionが呼ばれます。");
        }
    }
}
