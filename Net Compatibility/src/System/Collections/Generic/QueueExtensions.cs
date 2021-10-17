namespace System.Collections.Generic
{
    public static class QueueExtensions
    {
        public static bool TryDequeue<T>(this Queue<T> source, out T result)
        {
#if NETSTANDARD2_0
            if (source.Count > 0)
            {
                result = source.Dequeue();
                return true;
            }
            result = default;
            return false;
#else
            return source.TryDequeue(out result);
#endif
        }

        public static bool TryPeek<T>(this Queue<T> source, out T result)
        {
#if NETSTANDARD2_0
            if (source.Count > 0)
            {
                result = source.Peek();
                return true;
            }

            result = default;
            return false;
#else
            return source.TryPeek(out result);
#endif
        }
    }
}