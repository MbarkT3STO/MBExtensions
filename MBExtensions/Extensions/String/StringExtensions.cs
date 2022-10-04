namespace MBExtensions.Extensions.String
{
    public static class StringExtensions
    {
        /// <summary>
        /// <inheritdoc cref="string.IsNullOrEmpty"/>
        /// </summary>
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }
        
        /// <summary>
        /// Converts a string to a <see cref="System.int"/>
        /// </summary>
        public static int ToInt(this string value)
        {
            return int.Parse(value);
        }
    }
}