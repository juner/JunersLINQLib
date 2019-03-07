using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Juners.Linq.Internal.Tests {
    [TestClass]
    public class DisposableTests {
        [TestMethod, TestCategory("ShortTime")]
        public void DisposeTest()
        {
            var Flag = false;
            var disposable = Disposable.Create(() => Flag = true);
            disposable.Dispose();
            Assert.IsTrue(Flag);
        }
    }
}
