namespace System.Collections.Generic
{
    public static class StackExtensions
    {
        public static bool TryPop<T>(this Stack<T> source, out T result)
        {
            if (source.Count > 0)
            {
                result = source.Pop();
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryPeek<T>(this Stack<T> source, out T result)
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
