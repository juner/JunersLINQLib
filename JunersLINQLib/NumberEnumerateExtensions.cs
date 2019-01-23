using System;
using System.Collections.Generic;

namespace Juners.Linq {
    public static class NumberEnumerateExtensions {
        /// <summary>
        /// <paramref name="Figure"/>を元に少ない桁から順番に列挙する
        /// </summary>
        /// <param name="Self">数値自身</param>
        /// <param name="Figure">桁</param>
        /// <returns></returns>
        public static IEnumerable<int> Figure(this int Self, int Figure)
        {
            if (Self < 0)
                throw new ArgumentException($"not support {nameof(Self)}:{Self} < 0", nameof(Self));
            if (Figure < 2)
                throw new ArgumentException($"not support {nameof(Figure)}:{Figure} < 2", nameof(Figure));
            if (Self == 0)
                yield return 0;
            while (Self > 0) {
                var Value = Self % Figure;
                yield return Value;
                Self = (Self - Value) / Figure;
            }
        }
        /// <summary>
        /// <paramref name="Figure"/>を元に少ない桁から順番に列挙する
        /// </summary>
        /// <param name="Self">数値自身</param>
        /// <param name="Figure">桁</param>
        /// <returns></returns>
        public static IEnumerable<uint> Figure(this uint Self, uint Figure)
        {
            if (Figure < 2)
                throw new ArgumentException($"not support {nameof(Figure)}:{Figure} < 2", nameof(Figure));
            if (Self == 0)
                yield return 0;
            while (Self > 0) {
                var Value = Self % Figure;
                yield return Value;
                Self = (Self - Value) / Figure;
            }
        }
        /// <summary>
        /// <paramref name="Figure"/>を元に少ない桁から順番に列挙する
        /// </summary>
        /// <param name="Self">数値自身</param>
        /// <param name="Figure">桁</param>
        /// <returns></returns>
        public static IEnumerable<long> Figure(this long Self, long Figure)
        {
            if (Self < 0)
                throw new ArgumentException($"not support {nameof(Self)}:{Self} < 0", nameof(Self));
            if (Figure < 2)
                throw new ArgumentException($"not support {nameof(Figure)}:{Figure} < 2", nameof(Figure));
            if (Self == 0)
                yield return 0;
            while (Self > 0) {
                var Value = Self % Figure;
                yield return Value;
                Self = (Self - Value) / Figure;
            }
        }
        /// <summary>
        /// <paramref name="Figure"/>を元に少ない桁から順番に列挙する
        /// </summary>
        /// <param name="Self">数値自身</param>
        /// <param name="Figure">桁</param>
        /// <returns></returns>
        public static IEnumerable<ulong> Figure(this ulong Self, ulong Figure)
        {
            if (Figure < 2)
                throw new ArgumentException($"not support {nameof(Figure)}:{Figure} < 2", nameof(Figure));
            if (Self == 0)
                yield return 0;
            while (Self > 0) {
                var Value = Self % Figure;
                yield return Value;
                Self = (Self - Value) / Figure;
            }
        }
        /// <summary>
        /// <paramref name="Figure"/>を元に少ない桁から順番に列挙する
        /// </summary>
        /// <param name="Self">数値自身</param>
        /// <param name="Figure">桁</param>
        /// <returns></returns>
        public static IEnumerable<decimal> Figure(this decimal Self, decimal Figure)
        {
            if (Figure < 2)
                throw new ArgumentException($"not support {nameof(Figure)}:{Figure} < 2", nameof(Figure));
            if (Self == 0)
                yield return 0;
            while (Self > 0) {
                var Value = Self % Figure;
                yield return Value;
                Self = (Self - Value) / Figure;
            }
        }
    }
}
