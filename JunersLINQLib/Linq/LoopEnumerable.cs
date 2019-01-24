using System;
using System.Collections;
using System.Collections.Generic;

namespace Juners.Linq {
    /// <summary>
    /// 無限ループさせる
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class LoopEnumerable<T> : IEnumerable<T> {
        readonly IEnumerable<T> Item;
        public LoopEnumerable(IEnumerable<T> Item)
            => this.Item = Item ?? throw new ArgumentNullException(nameof(Item));
        public IEnumerator<T> GetEnumerator()
        {
            while (true) {
                foreach (var i in Item)
                    yield return i;
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
