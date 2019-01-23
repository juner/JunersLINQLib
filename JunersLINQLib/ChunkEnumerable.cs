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
            var Index = 0;
            var PrevChunk = 0;
            var Results = new List<T>();
            foreach (var Item in Items) {
                var Chunk = Index++ / ChunkSize;
                if (PrevChunk != Chunk) {
                    yield return Results.AsReadOnly();
                    Results = new List<T>();
                }
                Results.Add(Item);
            }
            if (Results.Any())
                yield return Results.AsReadOnly();
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
