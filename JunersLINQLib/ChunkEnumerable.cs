using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Juners.Linq {
    internal class ChunkEnumerable<T> : IEnumerable<IEnumerable<T>> {
        readonly IEnumerable<T> Items;
        readonly int ChunkSize;
        public ChunkEnumerable(IEnumerable<T> Items, int ChunkSize)
            => (this.Items, this.ChunkSize) = (Items, ChunkSize);
        public IEnumerator<IEnumerable<T>> GetEnumerator()
        {
            var ChunkCount = ChunkSize;
            var Results = new List<T>();
            foreach (var Item in Items) {
                Results.Add(Item);
                if (--ChunkCount <= 0) {
                    yield return Results.AsReadOnly();
                    Results = new List<T>();
                    ChunkCount = ChunkSize;
                }
            }
            if (ChunkCount < ChunkSize)
                yield return Results.AsReadOnly();
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
