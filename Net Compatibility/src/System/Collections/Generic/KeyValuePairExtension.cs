namespace System.Collections.Generic
{
    public static class KeyValuePairExtension
    {
        /// <summary>
        /// Deconstruction of <seealso cref="KeyValuePair{TKey, TValue}"/>.
        /// </summary>
        public static void Deconstruct<TKey, TValue>(this KeyValuePair<TKey, TValue> source, out TKey key, out TValue value)
        // https://stackoverflow.com/questions/42549491/deconstruction-in-foreach-over-dictionary
        {
            key = source.Key;
            value = source.Value;
        }
    }
}