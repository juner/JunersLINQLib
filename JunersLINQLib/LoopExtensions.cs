using System;
using System.Collections.Generic;

namespace Juners.Linq {
    public static class RoopExtensions {
        /// <summary>
        /// 指定された IEnumerable により 無限ループを行う
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Self"></param>
        /// <returns></returns>
        public static IEnumerable<T> Loop<T>(this IEnumerable<T> Self)
            => new LoopEnumerable<T>(Self ?? throw new ArgumentNullException(nameof(Self)));
    }
}
