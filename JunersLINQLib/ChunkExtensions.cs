using System.Collections.Generic;

namespace Juners.Linq
{
    public static class ChunkExtensions
    {
        /// <summary>
        /// IEnumerable を先頭から<paramref name="ChunkSize"/>個ずつに分割する
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Item"></param>
        /// <param name="ChunkSize"></param>
        /// <returns></returns>
        public static IEnumerable<IEnumerable<T>> Chunk<T>(this IEnumerable<T> Item, int ChunkSize)
            => new ChunkEnumerable<T>(Item, ChunkSize);
    }
}
