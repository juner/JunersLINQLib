using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Juners.Linq.Tests {
    [TestClass]
    public class LoopExtensionsTests {
        public static string DynamicDataDisplayName(MethodInfo MethodInfo, object[] Parameters) => TestUtils.DynamicDataDisplayName(MethodInfo, Parameters);
        static IEnumerable<object[]> RoopTestData {
            get {
                yield return new object[] {
                    new[] { 1,2,3 }.Cast<object>(),
                    20,
                    new[] { 1,2,3,1,2,3,1,2,3,1,2,3,1,2,3,1,2,3,1,2 }.Cast<object>(),
                };
            }
        }
        [TestMethod, TestCategory("ShortTime"), DynamicData(nameof(RoopTestData), DynamicDataDisplayName = nameof(DynamicDataDisplayName))]
        public void LoopTest(IEnumerable<object> Item, int Take, IEnumerable<object> ExpectResult)
        {
            Trace.WriteLine($"{nameof(ExpectResult)}:{string.Join(", ", ExpectResult)}");
            var Result = Item.Loop().Take(Take).ToArray();
            Trace.WriteLine($"{nameof(Result)}:{string.Join(", ", Result)}");
            CollectionAssert.AreEqual(ExpectResult.ToArray(), Result);

        }
    }
}
