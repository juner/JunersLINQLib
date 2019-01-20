using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Juners.Linq
{
    internal class ChunkEnumerable<T> : IEnumerable<IReadOnlyList<T>>
    {
        readonly IEnumerable<T> Item;
        readonly int Chunk;
        public ChunkEnumerable(int Chunk, IEnumerable<T> Item)
            => (this.Chunk, this.Item) = (Chunk, Item);
        public IEnumerator<IReadOnlyList<T>> GetEnumerator()
        {
            var Chunk = new List<T>(this.Chunk);
            var Index = 0;
            foreach (var i in Item)
            {
                Chunk.Add(i);
                if (++Index % this.Chunk == 0)
                {
                    yield return Chunk.AsReadOnly();
                    Chunk = new List<T>(this.Chunk);
                }
            }
            if (Chunk.Any())
                yield return Chunk.AsReadOnly();
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
