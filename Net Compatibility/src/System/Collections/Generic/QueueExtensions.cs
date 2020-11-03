namespace System.Collections.Generic
{
    public static class QueueExtensions
    {
        public static bool TryDequeue<T>(this Queue<T> source, out T result)
        {
            if (source.Count > 0)
            {
                result = source.Dequeue();
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryPeek<T>(this Queue<T> source, out T result)
        {
            if (source.Count > 0)
            {
                result = source.Peek();
                return true;
            }

            result = default;
            return false;
        }
    }
}
