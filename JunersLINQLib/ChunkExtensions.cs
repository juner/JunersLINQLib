using System.Collections.Generic;

namespace Juners.Linq
{
    public static class ChunkExtensions
    {
        public static IEnumerable<IReadOnlyList<T>> Chunk<T>(this IEnumerable<T> Item, int Chunk)
            => new ChunkEnumerable<T>(Chunk, Item);
    }
}
