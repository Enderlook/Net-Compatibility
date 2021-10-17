namespace System.Collections.Generic
{
    public static class StackExtensions
    {
        public static bool TryPop<T>(this Stack<T> source, out T result)
        {
#if NETSTANDARD2_0
            if (source.Count > 0)
            {
                result = source.Pop();
                return true;
            }
            result = default;
            return false;
#else
            return source.TryPop(out result);
#endif
        }

        public static bool TryPeek<T>(this Stack<T> source, out T result)
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