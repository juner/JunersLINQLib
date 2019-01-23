using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using static System.Linq.Enumerable;

namespace Juners.Linq.Tests
{
    internal static class TestUtils
    {
        public static string DynamicDataDisplayName(MethodInfo MethodInfo, object[] Parameters)
        {
            var builder = new StringBuilder();
            builder.Append($"{MethodInfo.Name}(");
            var Params = MethodInfo.GetParameters();
            var Array = new List<string>();
            foreach (var (p, o) in Range(0, Params.Length).Select(index => (Params[index], Parameters[index])))
            {
                var Value = o is string str ? str
                    : o is IEnumerable enumerable ? "[" + string.Join(", ", enumerable.Cast<object>().Select(v => v?.ToString())) + "]"
                    : o?.ToString();
                Array.Add($"{p.Name}:{Value}");
            }
            return $"{MethodInfo.Name}({string.Join(", ", Array)})";
        }
    }
}
