using System.Runtime.CompilerServices;;

namespace Ice.iMpact
{
    /// <summary>
    ///  Options Style
    /// </summary>

    public struct OptionsStyle
    {
        /// <summary>
        ///  American
        /// </summary>
        public const char American = 'A';

        /// <summary>
        ///  European
        /// </summary>
        public const char European = 'E';

        /// <summary>
        ///  None
        /// </summary>
        public const char None = '0';

        /// <summary>
        ///  Asian
        /// </summary>
        public const char Asian = '3';

        /// <summary>
        ///  One Time
        /// </summary>
        public const char OneTime = '4';

        /// <summary>
        ///  Length of Options Style in bytes
        /// </summary>
        public const int Length = 1;
    }
}