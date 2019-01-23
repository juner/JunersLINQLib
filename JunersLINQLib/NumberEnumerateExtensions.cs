using System;
using System.Collections.Generic;
using System.Numerics;

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
        /// <summary>
        /// <paramref name="Figure"/>を元に少ない桁から順番に列挙する
        /// </summary>
        /// <param name="Self">数値自身</param>
        /// <param name="Figure">桁</param>
        /// <returns></returns>
        public static IEnumerable<byte> Figure(this byte Self, byte Figure)
        {
            if (Figure < 2)
                throw new ArgumentException($"not support {nameof(Figure)}:{Figure} < 2", nameof(Figure));
            if (Self == 0)
                yield return 0;
            while (Self > 0) {
                var Value = (byte)(Self % Figure);
                yield return Value;
                Self = (byte)((Self - Value) / Figure);
            }
        }
        /// <summary>
        /// <paramref name="Figure"/>を元に少ない桁から順番に列挙する
        /// </summary>
        /// <param name="Self">数値自身</param>
        /// <param name="Figure">桁</param>
        /// <returns></returns>
        public static IEnumerable<sbyte> Figure(this sbyte Self, sbyte Figure)
        {
            if (Self < 0)
                throw new ArgumentException($"not support {nameof(Self)}:{Self} < 0", nameof(Self));
            if (Figure < 2)
                throw new ArgumentException($"not support {nameof(Figure)}:{Figure} < 2", nameof(Figure));
            if (Self == 0)
                yield return 0;
            while (Self > 0) {
                var Value = (sbyte)(Self % Figure);
                yield return Value;
                Self = (sbyte)((Self - Value) / Figure);
            }
        }
        /// <summary>
        /// <paramref name="Figure"/>を元に少ない桁から順番に列挙する
        /// </summary>
        /// <param name="Self">数値自身</param>
        /// <param name="Figure">桁</param>
        /// <returns></returns>
        public static IEnumerable<char> Figure(this char Self, char Figure)
        {
            if (Self < 0)
                throw new ArgumentException($"not support {nameof(Self)}:{Self} < 0", nameof(Self));
            if (Figure < 2)
                throw new ArgumentException($"not support {nameof(Figure)}:{Figure} < 2", nameof(Figure));
            if (Self == 0)
                yield return (char)0;
            while (Self > 0) {
                var Value = (char)(Self % Figure);
                yield return Value;
                Self = (char)((Self - Value) / Figure);
            }
        }
        /// <summary>
        /// <paramref name="Figure"/>を元に少ない桁から順番に列挙する
        /// </summary>
        /// <param name="Self">数値自身</param>
        /// <param name="Figure">桁</param>
        /// <returns></returns>
        public static IEnumerable<short> Figure(this short Self, short Figure)
        {
            if (Self < 0)
                throw new ArgumentException($"not support {nameof(Self)}:{Self} < 0", nameof(Self));
            if (Figure < 2)
                throw new ArgumentException($"not support {nameof(Figure)}:{Figure} < 2", nameof(Figure));
            if (Self == 0)
                yield return 0;
            while (Self > 0) {
                var Value = (short)(Self % Figure);
                yield return Value;
                Self = (short)((Self - Value) / Figure);
            }
        }
        /// <summary>
        /// <paramref name="Figure"/>を元に少ない桁から順番に列挙する
        /// </summary>
        /// <param name="Self">数値自身</param>
        /// <param name="Figure">桁</param>
        /// <returns></returns>
        public static IEnumerable<ushort> Figure(this ushort Self, ushort Figure)
        {
            if (Self < 0)
                throw new ArgumentException($"not support {nameof(Self)}:{Self} < 0", nameof(Self));
            if (Figure < 2)
                throw new ArgumentException($"not support {nameof(Figure)}:{Figure} < 2", nameof(Figure));
            if (Self == 0)
                yield return 0;
            while (Self > 0) {
                var Value = (ushort)(Self % Figure);
                yield return Value;
                Self = (ushort)((Self - Value) / Figure);
            }
        }
        /// <summary>
        /// <paramref name="Figure"/>を元に少ない桁から順番に列挙する
        /// </summary>
        /// <param name="Self">数値自身</param>
        /// <param name="Figure">桁</param>
        /// <returns></returns>
        public static IEnumerable<double> Figure(this double Self, double Figure)
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
        public static IEnumerable<BigInteger> Figure(this BigInteger Self, BigInteger Figure)
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
    }
}
