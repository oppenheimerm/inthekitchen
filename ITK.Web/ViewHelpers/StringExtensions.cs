namespace ITK.Web.ViewHelpers
{
    public static class StringExtensions
    {

        /// <summary>
        /// Efficient way to remove ALL whitespace from String
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string RemoveWhitespace(this string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }

        /// <summary>
        /// Truncate a string to a set size.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="maxLength"></param>
        /// <returns></returns>
        /// public static string Truncate(this string value, int maxLength)
        public static string Truncate(string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) return value;
            return value.Length <= maxLength ? value : value.Substring(0, maxLength);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        /// <param name="maxlen"></param>
        /// <returns></returns>
        /// public static string ShortenAndFormatText(this string val, int maxlen)
        public static string ShortenAndFormatText(string val, int maxlen)
        {
            const string postFix = "...";

            if (string.IsNullOrEmpty(val)) return val;

            if (val.Length > maxlen)
            {
                var truncateFirst = Truncate(val, (maxlen - postFix.Length));
                var truncateLast = truncateFirst + postFix;
                return truncateLast;
            }
            else
            {
                return val;
            }
        }
    }
}
