using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices
{
    /// <summary>
    /// An unsafe class that provides a set of methods to access the underlying data representations of collections.
    /// </summary>
    public static class CollectionsMarshal
    {
        private sealed class RawList
        {
            public Array Items;
            public int Size;
            public int Version;
        }

        [StructLayout(LayoutKind.Explicit)]
        private struct RawListHelper
        {
            [FieldOffset(0)]
            public object AsObject;

            [FieldOffset(0)]
            public RawList AsRawList;
        }

        /// <summary>
        /// Get a <see cref="Span{T}"/> view over a <see cref="List{T}"/>'s data.
        /// Items should not be added or removed from the <see cref="List{T}"/> while the <see cref="Span{T}"/> is in use.
        /// </summary>
        public static Span<T> AsSpan<T>(List<T> list)
        {
            RawList raw = new RawListHelper { AsObject = list }.AsRawList;
            return new Span<T>(Unsafe.As<T[]>(raw.Items), 0, list.Count);
        }
    }
}