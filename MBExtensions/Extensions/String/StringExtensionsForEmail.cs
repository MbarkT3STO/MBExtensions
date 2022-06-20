namespace MBExtensions.Extensions.String
{
    public class StringExtensionsForEmail
    {
        /// <summary>
        /// Checks if a string is a valid email
        /// </summary>
        /// <param name="value">Text to be checked</param>
        public static bool IsValidEmailAddress(this string value)
        {
            var trimmedValue = value.Trim();
            const string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                                   + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                                   + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            var regex = new Regex(pattern, RegexOptions.IgnoreCase);

            return regex.IsMatch(trimmedValue);
        }
    }
}